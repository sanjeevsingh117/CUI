using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Collections;



namespace CUI_Display
{
    public partial class cui_data_inject : Form
    {
        private static cui_data_inject cui_data_inject_obj;
        public cui_data_inject()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetCurrentDirectory() + @"\Resources\bhge_icon.ico");
            ////this.WindowState = MinimumSize;
            //PictureBox picture = new PictureBox
            //{
            //    Name = "pictureBox",
            //    Size = new Size(1177, 692),
            //    //Location = new Point(14, 17),
            //    // Image = Image.FromFile(@"C:\Users\212612447\Documents\CUI\CUI_Display_updated1\CUI_Display_updated\CUI_Display\ge_cover_img4.jpg"),
            //    Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\ge_cover_img4.jpg"),
            //    SizeMode = PictureBoxSizeMode.CenterImage
            //};
            //tableLayoutPanel1.Controls.Add(picture);
            //picture.SizeMode = PictureBoxSizeMode.StretchImage;
            //cui_data_inject_pnl.Visible = false;
            //picture.Visible = true;

        }
        public void create_resource_configuration()
        {
            using (ResXResourceWriter resx = new ResXResourceWriter(Directory.GetCurrentDirectory() + @"\Resources\\cui_data_inject.resx"))
            {
                try
                {
                    resx.AddResource("client.id" ,client_id_txt.Text);
                    resx.AddResource("client.secret",client_Secret_txt.Text);

                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
             
            }
        }

        public bool validate_user_configuration()
        {
            
            using (ResXResourceReader resxReader = new ResXResourceReader(Directory.GetCurrentDirectory() + @"\Resources\\cui_data_inject.resx"))
            {
                string id = string.Empty;
                string pwd = string.Empty;
                try
                {
                    foreach (DictionaryEntry entry in resxReader)
                    {
                        if (((string)entry.Key).Equals("client.id"))
                            id = (string)entry.Value;

                        if (((string)entry.Key).Equals("client.secret"))
                            pwd = (string)entry.Value;
                    }
                  //  MessageBox.Show("login details is:" + client_id_txt.Text +" " +id + "  " + pwd+" "+ client_Secret_txt.Text);
                  
                    if (((id.Equals(client_id_txt.Text)) && (pwd.Equals(client_Secret_txt.Text))) || ((id.Equals(pwd_client_txt.Text)) && (pwd.Equals(pwd_client_secret_txt.Text))))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return false;
                }

            }
        }




        public void create_inject_configuration()
        {


            using (StreamWriter writetext = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\predix-timeseries.properties"))
            {
                writetext.WriteLine("# Predix Timeseries configuration.\n# DO NOT MODIFY WITHOUT CONSULTING PREDIX SUPPORT");
                writetext.WriteLine("predix.timeseries.maxTagsPerQuery=" + 5);
                writetext.WriteLine("predix.timeseries.maxIngestionMessageSize=" + 512000);
                writetext.WriteLine("# Predix Timeseries configuration.\n");
                writetext.WriteLine("# Purchased Plan restrictions.");
                writetext.WriteLine("# MODIFY TO SUIT YOUR PLAN. GOING OVER MIGHT RESULT IN ADDED CHARGES");
                writetext.WriteLine("plan.ingestion.concurrent.connections.max=" + 1);
                writetext.WriteLine("plan.query.concurrent.connections.max=" + 1);

                writetext.WriteLine("# Purchased Plan restrictions \n");

                writetext.WriteLine("# Execution properties.");

                writetext.WriteLine("# MODIFY AS APPROPRIATE. \n");

                writetext.WriteLine("#Execution properties.\n");

                writetext.WriteLine("uaa.uri=" + uaa_uri_txt.Text);
                writetext.WriteLine("ingestion.uri=" + injection_uri_txt.Text);
                writetext.WriteLine("ingestion.zone-http-header-name=" + zone_header_name_txt.Text);
                writetext.WriteLine("ingestion.zone-http-header-value=" + zone_header_val_txt.Text);

                writetext.WriteLine("ingestion.client.id=" +client_id_txt.Text);
                writetext.WriteLine("ingestion.client.secret=" +client_Secret_txt.Text);
                //writetext.WriteLine("ingestion.client.secret.env.variable=TS_PASS");

                writetext.WriteLine("query.uri=" + query_uri_txt.Text);
                writetext.WriteLine("query.zone-http-header-name=Predix-Zone-Id");
                writetext.WriteLine("query.zone-http-header-value=c701c89a-320c-4811-a524-b68d3a27d0e4");
                writetext.WriteLine("query.client.id="+client_id_txt.Text);
                writetext.WriteLine("query.client.secret="+client_Secret_txt.Text);
                //writetext.WriteLine("query.client.secret.env.variable=TS_PASS");

                writetext.WriteLine("proxy.uri=" + proxy_uri_txt.Text);
                writetext.WriteLine("#proxy.user=proxyuser");
                writetext.WriteLine("#proxy.password=proxypass.");
                writetext.WriteLine("#ingestion.response.wait.timeout=300");

            }
        }


        public static cui_data_inject getInstance()
        {
            if (cui_data_inject_obj == null)
            {
                Console.WriteLine("helpobject is null");
                cui_data_inject_obj = new cui_data_inject();
            }
            return cui_data_inject_obj;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (new_user_radio.Checked)
            {
                cui_data_inject_pnl.Visible = true;
                grant_pnl.Visible = true;
            }
        
        }
        private void existing_user_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            if (existing_user_radio.Checked)
            {
                cui_data_inject_pnl.Visible = false;
                grant_pnl.Visible = true;

            }
          
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (new_user_radio.Checked)
                {
                    cui_data_inject_pnl.Visible = true;


                    DialogResult result = MessageBox.Show(Messages.CONF_SAVE_CONFIRM, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //to create configuration details
                        create_inject_configuration();
                        //to store login details in resource file .
                        create_resource_configuration();
                    }
                }
                if (existing_user_radio.Checked)
                {
                    if (!File.Exists(Directory.GetCurrentDirectory() + "\\Resources\\predix-timeseries.properties"))
                    {
                        MessageBox.Show("Injection specification not exist. Please create new specification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return;
                    }

                }

                //string command = @"call java -jar " + Directory.GetCurrentDirectory() + "\\Resources\\TSI_CSV.jar " + mainform.Curr_dir + "\\Data" + " " + "/predix-timeseries.properties 1,2>C:\\Users\\212612447\\Desktop\\output.txt";
                //MessageBox.Show(command);
                //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
                //startInfo.Verb = "runas";
                //System.Diagnostics.Process.Start(startInfo);

                //string MyBatchFile = @"C:\Users\212612447\Desktop\Final_TSI\TSI_CSV.bat";
               
                //validting user credential of exisitng user
                if (!validate_user_configuration())
                {
                    MessageBox.Show("You are not authorized user.Please check login credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("CUI Data is ready to push on cloud. It may take a few minutes."
                                , "Message", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor;
                string _sourcePath = mainform.Curr_dir+"\\Data";
                string _tempTargetPath = @"/predix-timeseries.properties";
                string command = "call java -jar \"" +Directory.GetCurrentDirectory() + "\\Resources\\TSI_CSV.jar\" " + "\""+_sourcePath + "\""+" " +"\""+ _tempTargetPath+"\"";
               // MessageBox.Show(command);
                var processInfo = new ProcessStartInfo("cmd.exe", "/C" + command);
                //var processInfo = new ProcessStartInfo(command);
                processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;
                //   processInfo.Arguments = @"C:\Users\212612448\Desktop\Final_TSI\Data /predix-timeseries.properties";
                var process = Process.Start(processInfo);
                //process.Start();
                process.WaitForExit();
                Cursor.Current = Cursors.Default;
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
               // MessageBox.Show("Error:"+error.ToString());
                Console.WriteLine("The exit code is :" + process.ExitCode.ToString());
                if (process.ExitCode == 202)
                {
                    MessageBox.Show("Success.CUI Data has been injested on cloud successfully"
                                   , "Message", MessageBoxButtons.OK
                                   , MessageBoxIcon.Information);
                    if (!Directory.Exists(mainform.Curr_dir + "\\CUI_Archive_Data"))
                    {
                       // MessageBox.Show("Archive directory got created");
                        Directory.CreateDirectory(mainform.Curr_dir + "\\CUI_Archive_Data");
                    }
                    //MessageBox.Show("Archive directory Already exist");
                    try
                    {
                        Directory.Move(mainform.Curr_dir + "\\Data", mainform.Curr_dir + "\\CUI_Archive_Data\\Data_" + DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data Folder is Open in window. Please close and retry. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Fail to Ingest. Please check connection and reconnect, exit code:" + process.ExitCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                this.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine("exception accured here "+exc.Message);

                Console.WriteLine(exc.StackTrace);
            }
        }
        private void client_cred_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (client_cred_radio.Checked)
            {
                pwd_pnl.Visible = true;
                client_pnl.Visible = true;
            }
        }
        private void password_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (password_radio.Checked)
            {
                client_pnl.Visible = false;
                pwd_pnl.Visible = true;              
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void grant_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

