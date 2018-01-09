using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;
using Kent.Boogaart.KBCsv;
using System.Runtime.InteropServices;
using ComClassExample;
using System.Security.AccessControl;
using System.Diagnostics;
//using System.Diagnostics;

namespace CUI_Display
{
    public partial class mainform : Form
    {
        String tagname;
        double wavevelocity;
        double deltat;
        double window;
        double readytime;
        string default_path;
        string configfilename;
        Process process;

        VNAConfiguration vnaconf;
       public static string Curr_dir = "";
        public mainform()
        {             
            Curr_dir = AppDefaultSetting.getDefaultPath();         
            InitializeComponent();
            ////testing
            //cui_data_inject x = new cui_data_inject();
            //  x.Show();

            this.Icon = new Icon(Directory.GetCurrentDirectory() + @"\Resources\bhge_icon.ico");
            this.pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\bhge.png");
            this.defaultpath.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\path_select.jpg");
            AppDefaultSetting.setDefaultPath("");
            Configure.Visible = false;
            DAQ.Visible = false;
            Home_page.Visible = true;
            graphTrendData.Visible = false;
            txtBoxtxt = new TextBox();
            vnaconf = new VNAConfiguration();
            //  dateTimePicker1 = new DateTimePicker();
            //  graphTrendData.Controls.Add(dateTimePicker1);
            picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(1177, 692),
                //Location = new Point(14, 17),
                // Image = Image.FromFile(@"C:\Users\212612447\Documents\CUI\CUI_Display_updated1\CUI_Display_updated\CUI_Display\ge_cover_img4.jpg"),
                Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\ge_cover_img4.jpg"),
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            tableLayoutPanel1.Controls.Add(picture);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            panel3.Visible = false;
            picture.Visible = true;
        }

        /****************************************************************/
        //public static void ExecuteCommandSync(object command,String argument)
        //{
        //    try
        //    {
        //        // create the ProcessStartInfo using "cmd" as the program to be run,
        //        // and "/c " as the parameters.
        //        // Incidentally, /c tells cmd that we want it to execute the command that follows,
        //        // and then exit.
        //        System.Diagnostics.ProcessStartInfo procStartInfo =
        //            new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + command);

        //        // The following commands are needed to redirect the standard output.
        //        // This means that it will be redirected to the Process.StandardOutput StreamReader.
        //        procStartInfo.RedirectStandardOutput = true;
        //        procStartInfo.UseShellExecute = false;
        //        procStartInfo.Arguments = argument;
        //        procStartInfo.Verb = "runas";
        //        // Do not create the black window.
        //        procStartInfo.CreateNoWindow = false;
        //        // Now we create a process, assign its ProcessStartInfo and start it
        //        System.Diagnostics.Process proc = new System.Diagnostics.Process();

        //        proc.StartInfo = procStartInfo;
        //        proc.Start();
        //        proc.WaitForExit();
        //        Console.WriteLine("exit code returned is:" + proc.ExitCode);
        //        int status = proc.ExitCode;
        //        if (status == 2)
        //        {
        //            MessageBox.Show("Time out. Please reconnect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        if (status == 1)
        //        {
        //            MessageBox.Show("Error establishing DAQ Communication.Check the DAQ Connections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Get the output into a string
        //        string result = proc.StandardOutput.ReadToEnd();
        //        // Display the command output.
        //        Console.WriteLine("result is " + result);
        //    }
        //    catch (Exception objException)
        //    {
        //        Console.WriteLine("exception has been accured" + objException.StackTrace);
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, new Size(this.Icon.Width * 5, this.Height * 5));
            // to maximize window
            // this.WindowState = FormWindowState.Maximized;
            //graphTrendData.Visible = false;
            graphTrendData.BackColor = Color.DarkSlateGray;
            MasterPane myMaster = graphTrendData.MasterPane;
            //Auto layout the new GraphPanes
            myMaster.SetLayout(this.CreateGraphics(), PaneLayout.SingleRow);
            // Calculate the Axis Scale Ranges
            graphTrendData.AxisChange();
            // Allow user to drag the points to change Y value
            graphTrendData.IsEnableVEdit = true;
            graphTrendData.ContextMenuBuilder += new ZedGraphControl.ContextMenuBuilderEventHandler(graphTrendData_ContextMenuBuilder);
            GraphPane myPane = graphTrendData.MasterPane.PaneList[0];
            myPane.Title.Text = "Raw Sensor Signal";
            myPane.XAxis.Title.Text = "Samples";
            myPane.YAxis.Title.Text = "Signal Level";





        }
        /************************************************************************/
        void ClearGraphData()
        {
            foreach (GraphPane obPane in this.graphTrendData.MasterPane.PaneList)
            {
                int iNumCurves = obPane.CurveList.Count;
                for (int _i = 0; _i < iNumCurves; ++_i)
                {
                    obPane.CurveList.Remove(obPane.CurveList[0]);
                }
            }
        }
        /************************************************************************/
        void FillGraphData(PointPairList obDataPoints)
        {
            ClearGraphData();
            

            
              // Update all curve data points
            GraphPane myPane = graphTrendData.MasterPane.PaneList[0];
            myPane.Fill = new Fill(Color.LightGray);
            myPane.Chart.Fill = new Fill(Color.LightGray);
            LineItem myCurve = myPane.AddCurve("Tag Name:" + vnaconf.tagname
                                                            ,obDataPoints
                                                            ,Color.Red
                                                            ,SymbolType.None
                                              );
            
            // Set equal spacing for the frequency values on base axis
            myCurve.BaseAxis(myPane).Type = AxisType.LinearAsOrdinal;
            
            myCurve.BaseAxis(myPane).ScaleFormatEvent += new Axis.ScaleFormatHandler(this.BaseAxisScaleFormatHandler);
            myCurve.ValueAxis(myPane).ScaleFormatEvent += new Axis.ScaleFormatHandler(this.ValueAxisScaleFormatHandler);

            // activate the cardinal spline smoothing
            myCurve.Line.IsSmooth = true;
            myCurve.Line.SmoothTension = 0.0F;

            // Calculate the Axis Scale Ranges
            graphTrendData.AxisChange();
            graphTrendData.Refresh();
            graphTrendData.Visible = true;
            

        }
        /****************************************************************/
        private string ValueAxisScaleFormatHandler(GraphPane pane, Axis axis, double val, int index)
        {
            //return val.ToString("g");
            return val.ToString("g");
        }
        /****************************************************************/
        private string BaseAxisScaleFormatHandler(GraphPane pane, Axis axis, double val, int index)
        {
            string strScaleLabel = val.ToString();
            if (val > 1000)
            {
                val /= 1000.0f;
                strScaleLabel = val.ToString() + "K";
            }
            return strScaleLabel;
        }
        /****************************************************************/
        private void graphTrendData_ContextMenuBuilder(ZedGraphControl sender, ContextMenuStrip menuStrip, Point mousePt, ZedGraphControl.ContextMenuObjectState objState)
        {
            menuStrip.Items["set_default"].Visible = false;
        }
        /****************************************************************/
        public void setlocalconf(string tagname = null, double deltat = 0, double window = 0, double readytime = 0, double wavevelocity = 0, string configfilename = null,string default_path=null)
        {
            this.tagname = tagname;
            this.deltat = deltat;
            this.window = window;
            this.readytime = readytime;
            this.wavevelocity = wavevelocity;
            this.configfilename = configfilename;
            this.default_path = default_path;
        }
        /****************************************************************/
        private bool isvalidconf()
        {
            //function to check validity of configuration 
            //against the input format.
            /*
                                               Field : allowed value.
                                          Tag Number : Any text value.(can not be empty)
                                 Ready time(seconds) : Non negative whole number.(can not be empty)
                                             Delta T : Non negative whole number.(can not be empty)
                                       Wave Velocity : Non negative whole number.(can not be empty).
                                              Window : Non negative whole number.(can not be empty)

            */
            if (textBox8.Text == String.Empty
                    || textBox7.Text == String.Empty
                    || textBox6.Text == String.Empty
                    || textBox5.Text == String.Empty
                    || textBox4.Text == String.Empty
                    || setdefpath_txt.Text==String.Empty
               )
            {
                MessageBox.Show(Messages.CONF_FIELDS_EMPTY_ERR,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // var regex = new System.Text.RegularExpressions.Regex(@"^[0-9]*(?.[0-9]*)?$");
                if (!(System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "^[0-9]+[.][0-9]+$")
                            || System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "^[0-9]+$")
                        )
                   )
                {
                    MessageBox.Show(Messages.CONF_READYTIME_NEGVAL_ERR
                                    , "Error"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                    return false;
                }
                if (!(System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "^[0-9]+[.][0-9]+$")
                            || System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "^[0-9]+$")
                         )
                   )
                {
                    MessageBox.Show(Messages.CONF_DELTAT_NEGVAL_ERR
                                   , "Error"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                    return false;
                }
                if (!(System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "^[0-9]+[.][0-9]+$")
                            || System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "^[0-9]+$")
                        )
                   )
                {
                    MessageBox.Show(Messages.CONF_WAVE_NEGVAL_ERR
                                    , "Error"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                    return false;
                }
                if (!(System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[0-9]+[.][0-9]+$")
                            || System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[0-9]+$")
                         )
                    )
                {
                    MessageBox.Show(Messages.CONF_WINDOW_NEGVAL_ERR
                                    , "Error"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

        }

        /****************************************************************/
        private void configuration_Click(object sender, EventArgs e)
        {

            graphTrendData.Visible = false;
            picture.Visible = false;
            panel3.Visible = true;
            Configure.Visible = true;
            setdefpath_txt.Text = Curr_dir;
        }
        /****************************************************************/
        private void startDAQ_Click(object sender, EventArgs e)
        {
            if (vnaconf.isConfigured())
            {
                picture.Visible = false;
                panel3.Visible = false;
                graphTrendData.Visible = true;
                Home_page.Visible = true;
                Configure.Visible = true;
                DAQ.Visible = true;
            }
            else
            {
                MessageBox.Show(Messages.CONF_COMPLETION_WARN
                                , "Warning"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
            }
        }
        /****************************************************************/
        private void button3_Click(object sender, EventArgs e)
        {
            if (
                 (MessageBox.Show(Messages.RESET_CONFIRM
                                 , "Confirmation"
                                 , MessageBoxButtons.YesNo
                                 , MessageBoxIcon.Question
                 )
                                 == DialogResult.Yes)
              )
            {
                graphTrendData.Visible = false;
                panel3.Visible = false;
                picture.Visible = true;
                this.setlocalconf(); //this resets local configuration
                vnaconf.resetconfig();
                Console.WriteLine("local configuration reseted"
                                    + this.configfilename
                                    + " " + this.tagname
                                    + " " + this.readytime
                                    + " " + this.deltat + " "
                                    + this.wavevelocity + " "
                                    + this.window + " "
                                    + this.default_path);

                MessageBox.Show(Messages.CONF_RESET_SUCC
                                   , "Message", MessageBoxButtons.OK
                                   , MessageBoxIcon.Information);


            }
            else
            {
                return;
            }


        }

        /****************************************************************/
        private void homehelp_Click_1(object sender, EventArgs e)
        {
           Homehelp help = Homehelp.getinstance();
            help.Show();
        }
        /****************************************************************/
        private void configuration_MouseEnter(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.BackColor = Color.LightSkyBlue;
            b.ForeColor = Color.White;
        }
        /****************************************************************/
        private void configuration_MouseLeave(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.BackColor = Color.DimGray;
            b.ForeColor = Color.Silver;
        }
        /****************************************************************/
        private void helpconf_Click(object sender, EventArgs e)
        {
            Confighelp hp = Confighelp.getinstance();
            hp.Show();
        }
        /****************************************************************/
        private void loadconf_Click(object sender, EventArgs e)
        {
            //code added to read configuration  file for VNA machine
            if (!isvalidconf())
                return;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog2.Filter = "config files (*.config)|*.config|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.setlocalconf(textBox8.Text
                                  , Convert.ToDouble(textBox6.Text)
                                  , Convert.ToDouble(textBox4.Text)
                                  , Convert.ToDouble(textBox7.Text)
                                  , Convert.ToDouble(textBox5.Text)
                                  , openFileDialog2.FileName,
                                  setdefpath_txt.Text
                                  );
                saveconf.Enabled = true;
                Console.WriteLine("local configuration set"
                                    + this.configfilename + " "
                                    + this.tagname + " "
                                    + this.readytime + " "
                                    + this.deltat + " "
                                    + this.wavevelocity + " "
                                    + this.window+" "
                                    +this.default_path);
            }
        }
        /****************************************************************/
        private void saveconf_Click(object sender, EventArgs e)
        {
            //code to save local configuration to instance....
            if (vnaconf == null)
            {
                vnaconf = new VNAConfiguration();
            }
            if (
                 (MessageBox.Show(Messages.CONF_SAVE_CONFIRM
                                 , "Confirmation"
                                 , MessageBoxButtons.YesNo
                                 , MessageBoxIcon.Question
                 )
                                 == DialogResult.Yes)
              )
            {
                vnaconf.setconfig(this.tagname, this.deltat, this.window, this.readytime, this.wavevelocity, this.configfilename, default_path);
                vnaconf.getconfig();
                MessageBox.Show(Messages.CONF_SAVE_SUCC
                                , "Message", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                saveconf.Enabled = false;
                Configure.Visible = false;
                Home_page.Visible = true;
            }

            graphTrendData.Visible = false;
            picture.Visible = false;
            panel3.Visible = true;
            //code added to check COM sever functionality

            /*      ComClassExample.ComClassExample x=new ComClassExample.ComClassExample();
                String p=x.show();
                MessageBox.Show(p);
            */
            //code will be used after doing daq

            /*
                        if (!isvalidconf())

                       {
                            return;
                       }
                        OpenFileDialog openFileDialog1 = new OpenFileDialog();
                        //openFileDialog1.InitialDirectory = "c:\\";
                        openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                        openFileDialog1.FilterIndex = 2;
                        openFileDialog1.RestoreDirectory = true;
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                using (var streamReader = new StreamReader(openFileDialog1.FileName))
                                using (var csvReader = new CsvReader(streamReader))
                                {
                                    HeaderRecord header = csvReader.ReadHeaderRecord();

                                    PointPairList obDataPoints = new PointPairList();
                                    uint uiRowIndex = 0U;

                                    while (csvReader.HasMoreRecords)
                                    {
                                        DataRecord record = csvReader.ReadDataRecord();
                                        var data = record[1];

                                        obDataPoints.Add(Convert.ToDouble(uiRowIndex), Convert.ToDouble(data));
                                    }

                                    FillGraphData(obDataPoints);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                            }
                        }*/
        }
        /****************************************************************/
        private void homeconf_Click(object sender, EventArgs e)
        {
            Configure.Visible = false;
            Home_page.Visible = true;
            panel3.Visible = false;
            graphTrendData.Visible = false;
            picture.Visible = true;

        }
        /****************************************************************/
        private void resetconf_Click(object sender, EventArgs e)
        {
            this.setlocalconf(); //this reset local configuration
            vnaconf.resetconfig();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            setdefpath_txt.Clear();
            saveconf.Enabled = false;
            Console.WriteLine("local configuration reseted"
                                + this.configfilename
                                + " " + this.tagname
                                + " " + this.readytime
                                + " " + this.deltat
                                + " " + this.wavevelocity
                                + " " + this.window
                                +"  " +this.default_path
                                );
        }
        /****************************************************************/
        private void Configure_Paint(object sender, PaintEventArgs e)
        {

        }
        /****************************************************************/
        private void DAQhome_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            graphTrendData.Visible = false;
            picture.Visible = true;
            DAQ.Visible = false;
            Configure.Visible = false;
            Home_page.Visible = true;
        }
        /****************************************************************/

        /****************************************************************/
        private void configconnect_Click(object sender, EventArgs e)
        {
            //this function connects to the VNA device and fetches the data against the last saved configuration.
            //saves the data in temp.csv locally.
            //also plots the data on the zgraph control.
            //also records the timestamp and saves in the config class object.
            // ExecuteCommandSync(@"C:\VNA\PlanarTR1300\Examples\COM\CPP\Release\Example5.exe > C:\Users\212612447\Desktop\vna_data.csv");
           // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            try
            {
                MessageBox.Show("Please wait for connection. This may take few minutes."
                                , "Message", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                               
                var p = new System.Diagnostics.Process();

                p.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\Resources\\Example5.exe";
                // these are command parameter to be passed to vna program for configuration .Vna will recive paramenter as command line argument starting from 1
               //  you can add variable in below order to be passed to vna 
               
                // tagname -->>argv[1]
                //readytime-->>argv[2] 
                //deltat -->>argv[3]
                //wavevelocity -->>argv[4]
                //window-->>argv[5]
                //default_path-->>argv[6]
                //configfilename -->>argv[7]
                //Directory.GetCurrentDirectory() + "\\Resources\\temp.cs-->>argv[8]

                string param =  tagname + " "
                              + readytime + " "
                              + deltat + " "
                              + wavevelocity + " " 
                              + window + " "
                              + default_path+" "
                              + configfilename+" "
                              + Directory.GetCurrentDirectory() + "\\Resources\\temp.csv";
                Console.WriteLine("passed parameter as command line arguments are:"+param);
                p.StartInfo.Arguments = param;
                // p.StartInfo.Arguments = readytime+" "+ Directory.GetCurrentDirectory()+"\\Resources\\temp.csv" ;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
            //    Cursor.Current = Cursors.WaitCursor;
                p.Start();
                p.WaitForExit();
               // Cursor.Current = Cursors.Default;
                int status = p.ExitCode;
                
                
            //temperory changes
                if (status == 2)
                {
                    MessageBox.Show("Time out. Please check connection with DAQ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (status == 1)
                {
                    MessageBox.Show("Error establishing DAQ Communication.Check the DAQ Connections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception objException)
            {
                Console.WriteLine("exception has been accured"+ objException.StackTrace);
            }
           // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            try
            {
                //string path = Curr_dir + @"\Data\" + vnaconf.tagname + "_" + DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss") + ".csv";
                //Console.WriteLine(path);
                //temperory changes
                using (var streamReader = new StreamReader(Directory.GetCurrentDirectory() + "\\Resources\\temp.csv")) 
                {
                    vnaconf.timestamp = DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss");
                    //  HeaderRecord header = csvReader.ReadHeaderRecord();
                    PointPairList obDataPoints = new PointPairList();
                    //uint uiRowIndex = 0U;
                    string line;
                    string[] row = new string[5];
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        row = line.Split(',');
                       // Console.WriteLine(row[0]+" "+row[1]);
                        obDataPoints.Add(Convert.ToDouble(row[0]), Convert.ToDouble(row[1]));
                    }                   
                    FillGraphData(obDataPoints);
                    savedata.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.FILE_READ_ERR +ex.Message,
                                    "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }
        /****************************************************************/
        public void save_config_data(string Curr_dir_path)
        {
            //first check if default path set or not...if not ask user to set defualt path....
            /*************************************************************************************************************/
            if (Curr_dir_path == String.Empty){             
                MessageBox.Show(Messages.DEFAULT_PATH_MISSING_ERR);
                FolderBrowserDialog update_default_path = new FolderBrowserDialog();
                if (update_default_path.ShowDialog() != DialogResult.OK){
                     MessageBox.Show(Messages.SELECT_FOLDER_WARN
                                     , "Warnining", MessageBoxButtons.OK
                                     , MessageBoxIcon.Warning);
                    return;
                }
                else{
                    Curr_dir = update_default_path.SelectedPath;
                    Curr_dir_path = Curr_dir;
                    if (!hasWriteAccessToFolder(Curr_dir)){
                        MessageBox.Show(Messages.FILE_WRITE_ACCESS_ERR + Curr_dir
                                         , "Error", MessageBoxButtons.OK
                                         , MessageBoxIcon.Error
                                         );
                         Curr_dir = "";
                         return;
                    }
                    AppDefaultSetting.setDefaultPath(Curr_dir);
                }
                MessageBox.Show(Messages.DEF_SELECTED_MESSAGE + Curr_dir);
                //AppDefaultSetting.setDefaultPath();
            }
            /*************************************************************************************************************/
            string tagpath = Curr_dir_path + @"\Data\"+ vnaconf.tagname + @"\";
            //populate buffer to data files and store at curr_dir(default path)
            try{
                if (!Directory.Exists(tagpath)){
                    Directory.CreateDirectory(Curr_dir_path + @"\Data\" + vnaconf.tagname + @"\");
                }
                /*************************************************************************************************************/
                /* //this is old logic
                using (var streamWriter = new StreamWriter(tagpath + vnaconf.tagname + "_" + vnaconf.timestamp + ".csv"))
              {
                  
                for (int i = 0; i < 5; i++)
                {
                       
                     var data1 = record_buff[i, 0];
                    var data2 = record_buff[i, 1];
                    var line = string.Format("{0},{1}", data1, data2);
                    streamWriter.WriteLine(line);
                    
                }
               
              }
            }*/
                /*************************************************************************************************************/
              
                //new changes reflected
                /*************************************************************************************************************/
                using (var streamWriter = new StreamWriter(tagpath + vnaconf.tagname + "_" + vnaconf.timestamp + ".csv"))
                using (var streamReader = new StreamReader(Directory.GetCurrentDirectory() + "\\Resources\\temp.csv")) {
                    string line;
                    string[] row;
                    while ((line = streamReader.ReadLine()) != null){
                        row = line.Split(',');
                        var data1 = row[0];
                        var data2 = row[1];
                        var dataline = string.Format("{0},{1}", data1, data2);
                        streamWriter.WriteLine(dataline);
                    }
                }
            }
            /*************************************************************************************************************/
            catch (Exception ex) {
                MessageBox.Show(Messages.FILE_READ_ERR + ex.Message,
                                    "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }

            //code to write configuration parameter in file....like tagname ,,window n all
            /*************************************************************************************************************/
            try
            {
                using (var streamWriter = new StreamWriter(tagpath + vnaconf.tagname + "_" + vnaconf.timestamp + ".cfg"))
                {
                    var tagname = string.Format("{0},{1} \n", "tagname", vnaconf.tagname);
                    streamWriter.WriteLine(tagname);

                    var readytime = string.Format("{0},{1} \n", "Ready time", vnaconf.readytime);
                    streamWriter.WriteLine(readytime);

                    var deltat = string.Format("{0},{1} \n", "delta T", vnaconf.deltat);
                    streamWriter.WriteLine(deltat);

                    var wavevel = string.Format("{0},{1} \n", "Wave velocity", vnaconf.wavevelocity);
                    streamWriter.WriteLine(wavevel);

                    var win = string.Format("{0},{1} \n", "Window", vnaconf.window);
                    streamWriter.WriteLine(win);

                    var def_path = string.Format("{0},{1} \n", "Default Path", vnaconf.default_path);
                    streamWriter.WriteLine(def_path);

                }
                MessageBox.Show(Messages.FILE_SAVED_SUCC + tagpath, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                savedata.Enabled = false;
                button5.Enabled = true;
            }
            catch (Exception ex){
                MessageBox.Show(Messages.FILE_READ_ERR + ex.Message,
                                    "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            /*************************************************************************************************************/
        }
        /*************************************************************************************************************/
        private bool hasWriteAccessToFolder(String path)
        {
            try{
                // string NtAccountName = @"MyDomain\MyUserOrGroup";
                string NtAccountName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;//current logged in user name.
                bool writeAllow = false;
                bool writeDeny = false;
                DirectoryInfo di = new DirectoryInfo(path);
                DirectorySecurity acl = di.GetAccessControl(AccessControlSections.Access);
                // AuthorizationRuleCollection accessRules = acl.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
                AuthorizationRuleCollection accessRules = acl.GetAccessRules(true, true,
                                                                             typeof(System.Security.Principal.SecurityIdentifier));
                if (accessRules == null)
                    return false;
                //iterate through all the rules to find the write allow and deny rules.
                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write)
                        continue;
                    if (rule.AccessControlType == AccessControlType.Allow)
                        writeAllow = true;
                    else if (rule.AccessControlType == AccessControlType.Deny)
                        writeDeny = true;
                }
                /*
                if (writeAllow && !writeDeny)
                {
                    Console.WriteLine(string.Format(@"{0} has write access to {1}", NtAccountName, path));
                    MessageBox.Show(NtAccountName + " has write access to " + path);
                }
                else
                {
                    Console.WriteLine(string.Format(@"{0} doesn't have write access to {1}", NtAccountName, path));
                    MessageBox.Show(@"2>>" + NtAccountName + " doesn't have write access to " + path);

                }
                */
                return writeAllow && !writeDeny;
            }
            catch (UnauthorizedAccessException exc)
            { /*
                Console.WriteLine(string.Format(@"{0} doesn't have write access to {1}", System.Security.Principal.WindowsIdentity.GetCurrent().Name, path));
                MessageBox.Show(@"3>>"+System.Security.Principal.WindowsIdentity.GetCurrent().Name + " doesn't have write access to " + path);
                MessageBox.Show(exc.Message);
                */
                return false;
            }
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            //this function saves the data fetched in last connect action (saves into file)
            //files saved are:
            //1.the data file with name as...\<tagname>_<timestamp>_.csv
            //2.the config file as configfilename_<timestamp>.cfg
            //3.the file containing config parameters.

            //here code commented to hide logic of temperory path selection by user...
          //  DialogResult result = MessageBox.Show(Messages.SAVEON_DEF_PATH_CONFIRM, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
               
                save_config_data(Curr_dir);
               // return;
            //}


            //if (result == DialogResult.No)
            //{

            //    FolderBrowserDialog folderbrowse = new FolderBrowserDialog();

            //    if (folderbrowse.ShowDialog() != DialogResult.OK)
            //    {


            //        MessageBox.Show(Messages.SELECT_FOLDER_WARN
            //                   , "Warning", MessageBoxButtons.OK
            //                   , MessageBoxIcon.Warning);
            //        return;
            //    }
            //    else
            //    {
            //        string temp_path = folderbrowse.SelectedPath;
                   
            //        if (!hasWriteAccessToFolder(Curr_dir))
            //        {

            //            MessageBox.Show(Messages.FILE_WRITE_ACCESS_ERR + Curr_dir
            //                  , "Error", MessageBoxButtons.OK
            //                  , MessageBoxIcon.Error);
            //            return;
            //        }
            //        else
            //        {
            //            save_config_data(temp_path);
            //        }

            //    }
            //}
        }
        /****************************************************************/
        private void DAQhelp_Click(object sender, EventArgs e)
        {
            helpDAQ hp = helpDAQ.getInstance();
            hp.Show();
        }
        /****************************************************************/
        private void button5_Click(object sender, EventArgs e)
        {
            // to be written on inject button
            // to call cui inject
              cui_data_inject cui_inject= cui_data_inject.getInstance();
              cui_inject.Show();
        }

        private void DAQ_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void graphTrendData_Load(object sender, EventArgs e)
        {

        }

        private void defaultpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowse = new FolderBrowserDialog();

            if (folderbrowse.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(Messages.SELECT_FOLDER_WARN
                           , "Warning", MessageBoxButtons.OK
                           , MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Curr_dir = folderbrowse.SelectedPath;               
                if (!hasWriteAccessToFolder(Curr_dir))
                {
                    MessageBox.Show(Messages.FILE_WRITE_ACCESS_ERR + Curr_dir
                          , "Error", MessageBoxButtons.OK
                          , MessageBoxIcon.Error);
                    return;
                }
            }
             AppDefaultSetting.setDefaultPath(Curr_dir);
             MessageBox.Show(Messages.DEF_SELECTED_MESSAGE + Curr_dir);
            setdefpath_txt.Text = Curr_dir;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void setdefpath_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
