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

namespace CUI_Display
{
    public partial class Form1 : Form
    {
        /****************************************************************/
        public Form1()
        {
            InitializeComponent();
            graphTrendData.Visible = false;
             txtBoxtxt = new TextBox();


            dateTimePicker1 = new DateTimePicker();
            graphTrendData.Controls.Add(dateTimePicker1);

             picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(1177, 692),
                //Location = new Point(14, 17),
                Image = Image.FromFile(@"C:\Users\212612447\Documents\CUI\CUI_Display_updated1\CUI_Display_updated\CUI_Display\ge_oil_gas1.jpg"),
                SizeMode = PictureBoxSizeMode.CenterImage
                

            };
            tableLayoutPanel1.Controls.Add(picture);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Visible = true;
           
            //tableLayoutPanel1.Controls.Add(txtBoxtxt);

        }

        /****************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

          



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

            LineItem myCurve = myPane.AddCurve("Raw Sensor Signal",
                                                  obDataPoints,
                                                  Color.Red,
                                                  SymbolType.None);

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
        private void btnOpenData_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Error: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            graphTrendData.Visible = true;

            picture.Visible = false;
           
        }

        private void btnResetView_Click(object sender, EventArgs e)
        {
            ClearGraphData();
            graphTrendData.Visible = false;
            picture.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void graphTrendData_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbIsRawData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
