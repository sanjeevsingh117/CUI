using System;
namespace CUI_Display
  
{
   partial class mainform
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
        {
            
            if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Home_page = new System.Windows.Forms.Panel();
            this.Configure = new System.Windows.Forms.Panel();
            this.DAQ = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.savedata = new System.Windows.Forms.Button();
            this.resetconf = new System.Windows.Forms.Button();
            this.helpconf = new System.Windows.Forms.Button();
            this.Homeconf = new System.Windows.Forms.Button();
            this.saveconf = new System.Windows.Forms.Button();
            this.loadconf = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.home_reset = new System.Windows.Forms.Button();
            this.startDAQ = new System.Windows.Forms.Button();
            this.configuration = new System.Windows.Forms.Button();
            this.graphTrendData = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbIsRawData = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.setdefpath_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultpath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Home_page.SuspendLayout();
            this.Configure.SuspendLayout();
            this.DAQ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.Home_page, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.graphTrendData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(25, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 596);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Home_page
            // 
            this.Home_page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_page.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home_page.BackColor = System.Drawing.Color.DimGray;
            this.Home_page.Controls.Add(this.Configure);
            this.Home_page.Controls.Add(this.button4);
            this.Home_page.Controls.Add(this.home_reset);
            this.Home_page.Controls.Add(this.startDAQ);
            this.Home_page.Controls.Add(this.configuration);
            this.Home_page.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_page.ForeColor = System.Drawing.Color.White;
            this.Home_page.Location = new System.Drawing.Point(3, 83);
            this.Home_page.Name = "Home_page";
            this.Home_page.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Home_page.Size = new System.Drawing.Size(228, 494);
            this.Home_page.TabIndex = 28;
            // 
            // Configure
            // 
            this.Configure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Configure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Configure.BackColor = System.Drawing.Color.DimGray;
            this.Configure.Controls.Add(this.DAQ);
            this.Configure.Controls.Add(this.resetconf);
            this.Configure.Controls.Add(this.helpconf);
            this.Configure.Controls.Add(this.Homeconf);
            this.Configure.Controls.Add(this.saveconf);
            this.Configure.Controls.Add(this.loadconf);
            this.Configure.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configure.ForeColor = System.Drawing.Color.White;
            this.Configure.Location = new System.Drawing.Point(1, 0);
            this.Configure.Name = "Configure";
            this.Configure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Configure.Size = new System.Drawing.Size(227, 491);
            this.Configure.TabIndex = 29;
            this.Configure.Paint += new System.Windows.Forms.PaintEventHandler(this.Configure_Paint);
            // 
            // DAQ
            // 
            this.DAQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DAQ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DAQ.BackColor = System.Drawing.Color.DimGray;
            this.DAQ.Controls.Add(this.button7);
            this.DAQ.Controls.Add(this.button2);
            this.DAQ.Controls.Add(this.button3);
            this.DAQ.Controls.Add(this.button5);
            this.DAQ.Controls.Add(this.savedata);
            this.DAQ.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAQ.ForeColor = System.Drawing.Color.White;
            this.DAQ.Location = new System.Drawing.Point(-6, 3);
            this.DAQ.Name = "DAQ";
            this.DAQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DAQ.Size = new System.Drawing.Size(233, 793);
            this.DAQ.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(1, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 35);
            this.button7.TabIndex = 5;
            this.button7.Text = "Co&nnect";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.configconnect_Click);
            this.button7.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(-5, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hel&p";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.DAQhelp_Click);
            this.button2.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(5, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.DAQhome_Click_1);
            this.button3.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoEllipsis = true;
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(3, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 41);
            this.button5.TabIndex = 1;
            this.button5.Text = "&Injest";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // savedata
            // 
            this.savedata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedata.BackColor = System.Drawing.Color.DimGray;
            this.savedata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savedata.Enabled = false;
            this.savedata.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.savedata.FlatAppearance.BorderSize = 0;
            this.savedata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedata.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedata.ForeColor = System.Drawing.Color.Silver;
            this.savedata.Location = new System.Drawing.Point(-2, 147);
            this.savedata.Name = "savedata";
            this.savedata.Size = new System.Drawing.Size(236, 35);
            this.savedata.TabIndex = 0;
            this.savedata.Text = "Sa&ve";
            this.savedata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savedata.UseVisualStyleBackColor = false;
            this.savedata.Click += new System.EventHandler(this.savedata_Click);
            this.savedata.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.savedata.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // resetconf
            // 
            this.resetconf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetconf.AutoEllipsis = true;
            this.resetconf.BackColor = System.Drawing.Color.DimGray;
            this.resetconf.FlatAppearance.BorderSize = 0;
            this.resetconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetconf.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetconf.ForeColor = System.Drawing.Color.Silver;
            this.resetconf.Location = new System.Drawing.Point(-4, 310);
            this.resetconf.Name = "resetconf";
            this.resetconf.Size = new System.Drawing.Size(237, 35);
            this.resetconf.TabIndex = 4;
            this.resetconf.Text = "R&eset";
            this.resetconf.UseVisualStyleBackColor = false;
            this.resetconf.Click += new System.EventHandler(this.resetconf_Click);
            this.resetconf.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.resetconf.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // helpconf
            // 
            this.helpconf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpconf.AutoEllipsis = true;
            this.helpconf.BackColor = System.Drawing.Color.DimGray;
            this.helpconf.FlatAppearance.BorderSize = 0;
            this.helpconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpconf.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpconf.ForeColor = System.Drawing.Color.Silver;
            this.helpconf.Location = new System.Drawing.Point(-5, 393);
            this.helpconf.Name = "helpconf";
            this.helpconf.Size = new System.Drawing.Size(238, 36);
            this.helpconf.TabIndex = 3;
            this.helpconf.Text = "Hel&p";
            this.helpconf.UseVisualStyleBackColor = false;
            this.helpconf.Click += new System.EventHandler(this.helpconf_Click);
            this.helpconf.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.helpconf.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // Homeconf
            // 
            this.Homeconf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Homeconf.AutoEllipsis = true;
            this.Homeconf.BackColor = System.Drawing.Color.DimGray;
            this.Homeconf.FlatAppearance.BorderSize = 0;
            this.Homeconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homeconf.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homeconf.ForeColor = System.Drawing.Color.Silver;
            this.Homeconf.Location = new System.Drawing.Point(-3, 223);
            this.Homeconf.Name = "Homeconf";
            this.Homeconf.Size = new System.Drawing.Size(237, 35);
            this.Homeconf.TabIndex = 2;
            this.Homeconf.Text = "&Home";
            this.Homeconf.UseVisualStyleBackColor = false;
            this.Homeconf.Click += new System.EventHandler(this.homeconf_Click);
            this.Homeconf.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.Homeconf.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // saveconf
            // 
            this.saveconf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveconf.AutoEllipsis = true;
            this.saveconf.BackColor = System.Drawing.Color.DimGray;
            this.saveconf.Enabled = false;
            this.saveconf.FlatAppearance.BorderSize = 0;
            this.saveconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveconf.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveconf.ForeColor = System.Drawing.Color.Silver;
            this.saveconf.Location = new System.Drawing.Point(-7, 134);
            this.saveconf.Name = "saveconf";
            this.saveconf.Size = new System.Drawing.Size(234, 38);
            this.saveconf.TabIndex = 1;
            this.saveconf.Text = "S&ave";
            this.saveconf.UseVisualStyleBackColor = false;
            this.saveconf.Click += new System.EventHandler(this.saveconf_Click);
            this.saveconf.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.saveconf.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // loadconf
            // 
            this.loadconf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadconf.BackColor = System.Drawing.Color.DimGray;
            this.loadconf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadconf.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.loadconf.FlatAppearance.BorderSize = 0;
            this.loadconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadconf.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadconf.ForeColor = System.Drawing.Color.Silver;
            this.loadconf.Location = new System.Drawing.Point(-5, 52);
            this.loadconf.Name = "loadconf";
            this.loadconf.Size = new System.Drawing.Size(230, 35);
            this.loadconf.TabIndex = 0;
            this.loadconf.Text = "&Load";
            this.loadconf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadconf.UseVisualStyleBackColor = false;
            this.loadconf.Click += new System.EventHandler(this.loadconf_Click);
            this.loadconf.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.loadconf.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(-2, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hel&p";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.homehelp_Click_1);
            this.button4.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // home_reset
            // 
            this.home_reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_reset.AutoEllipsis = true;
            this.home_reset.BackColor = System.Drawing.Color.DimGray;
            this.home_reset.FlatAppearance.BorderSize = 0;
            this.home_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_reset.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_reset.ForeColor = System.Drawing.Color.Silver;
            this.home_reset.Location = new System.Drawing.Point(-7, 286);
            this.home_reset.Name = "home_reset";
            this.home_reset.Size = new System.Drawing.Size(242, 35);
            this.home_reset.TabIndex = 2;
            this.home_reset.Text = "&Reset";
            this.home_reset.UseVisualStyleBackColor = false;
            this.home_reset.Click += new System.EventHandler(this.button3_Click);
            this.home_reset.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.home_reset.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // startDAQ
            // 
            this.startDAQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDAQ.AutoEllipsis = true;
            this.startDAQ.BackColor = System.Drawing.Color.DimGray;
            this.startDAQ.FlatAppearance.BorderSize = 0;
            this.startDAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDAQ.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDAQ.ForeColor = System.Drawing.Color.Silver;
            this.startDAQ.Location = new System.Drawing.Point(-6, 164);
            this.startDAQ.Name = "startDAQ";
            this.startDAQ.Size = new System.Drawing.Size(237, 38);
            this.startDAQ.TabIndex = 1;
            this.startDAQ.Text = "&Start DAQ";
            this.startDAQ.UseVisualStyleBackColor = false;
            this.startDAQ.Click += new System.EventHandler(this.startDAQ_Click);
            this.startDAQ.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.startDAQ.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // configuration
            // 
            this.configuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configuration.BackColor = System.Drawing.Color.DimGray;
            this.configuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.configuration.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.configuration.FlatAppearance.BorderSize = 0;
            this.configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configuration.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration.ForeColor = System.Drawing.Color.Silver;
            this.configuration.Location = new System.Drawing.Point(0, 52);
            this.configuration.Name = "configuration";
            this.configuration.Size = new System.Drawing.Size(231, 35);
            this.configuration.TabIndex = 0;
            this.configuration.Text = "&Configuration";
            this.configuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.configuration.UseVisualStyleBackColor = false;
            this.configuration.Click += new System.EventHandler(this.configuration_Click);
            this.configuration.MouseEnter += new System.EventHandler(this.configuration_MouseEnter);
            this.configuration.MouseLeave += new System.EventHandler(this.configuration_MouseLeave);
            // 
            // graphTrendData
            // 
            this.graphTrendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphTrendData.AutoScroll = true;
            this.graphTrendData.AutoSize = true;
            this.graphTrendData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphTrendData.BackColor = System.Drawing.Color.Silver;
            this.graphTrendData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphTrendData.BackgroundImage")));
            this.graphTrendData.EditModifierKeys = System.Windows.Forms.Keys.None;
            this.graphTrendData.Location = new System.Drawing.Point(4, 584);
            this.graphTrendData.Margin = new System.Windows.Forms.Padding(4);
            this.graphTrendData.Name = "graphTrendData";
            this.graphTrendData.ScrollGrace = 0D;
            this.graphTrendData.ScrollMaxX = 0D;
            this.graphTrendData.ScrollMaxY = 0D;
            this.graphTrendData.ScrollMaxY2 = 0D;
            this.graphTrendData.ScrollMinX = 0D;
            this.graphTrendData.ScrollMinY = 0D;
            this.graphTrendData.ScrollMinY2 = 0D;
            this.graphTrendData.Size = new System.Drawing.Size(226, 8);
            this.graphTrendData.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(237, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 74);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GE Inspira Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(277, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corrosion Under Insulation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbIsRawData);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.label8);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(234, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 494);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbIsRawData
            // 
            this.cbIsRawData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsRawData.AutoSize = true;
            this.cbIsRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsRawData.Location = new System.Drawing.Point(38, 476);
            this.cbIsRawData.Name = "cbIsRawData";
            this.cbIsRawData.Size = new System.Drawing.Size(51, 17);
            this.cbIsRawData.TabIndex = 23;
            this.cbIsRawData.Text = "Raw";
            this.cbIsRawData.UseVisualStyleBackColor = true;
            this.cbIsRawData.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.setdefpath_txt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.defaultpath);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(93, 133);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(605, 245);
            this.panel4.TabIndex = 25;
            // 
            // setdefpath_txt
            // 
            this.setdefpath_txt.Location = new System.Drawing.Point(152, 183);
            this.setdefpath_txt.Multiline = true;
            this.setdefpath_txt.Name = "setdefpath_txt";
            this.setdefpath_txt.ReadOnly = true;
            this.setdefpath_txt.Size = new System.Drawing.Size(246, 24);
            this.setdefpath_txt.TabIndex = 32;
            this.setdefpath_txt.TextChanged += new System.EventHandler(this.setdefpath_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GE Inspira Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Set Default Data Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Window";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ready Time(S)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Delta T";
            // 
            // defaultpath
            // 
            this.defaultpath.BackColor = System.Drawing.Color.Gray;
            this.defaultpath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.defaultpath.FlatAppearance.BorderSize = 0;
            this.defaultpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultpath.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultpath.ForeColor = System.Drawing.Color.White;
            this.defaultpath.Location = new System.Drawing.Point(415, 174);
            this.defaultpath.Name = "defaultpath";
            this.defaultpath.Size = new System.Drawing.Size(63, 35);
            this.defaultpath.TabIndex = 31;
            this.defaultpath.UseVisualStyleBackColor = false;
            this.defaultpath.Click += new System.EventHandler(this.defaultpath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Wave Velocity";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(152, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 24);
            this.textBox4.TabIndex = 30;
            this.textBox4.Text = "2000";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(152, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(124, 24);
            this.textBox7.TabIndex = 26;
            this.textBox7.Text = "20";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(152, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 24);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "270000000";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(152, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 24);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "0.000000000115";
            // 
            // textBox8
            // 
            this.textBox8.AcceptsTab = true;
            this.textBox8.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(245, 89);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(124, 24);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "XXXXXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("GE Inspira Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(90, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tag Number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(942, 597);
            this.Name = "mainform";
            this.Text = "CUI Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Home_page.ResumeLayout(false);
            this.Configure.ResumeLayout(false);
            this.DAQ.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
        private System.Windows.Forms.TextBox txtBoxtxt;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
       // private System.Windows.Forms.Panel p1;
        private ZedGraph.ZedGraphControl graphTrendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbIsRawData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Home_page;
        private System.Windows.Forms.Panel Configure;
        private System.Windows.Forms.Panel DAQ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Button resetconf;
        private System.Windows.Forms.Button helpconf;
        private System.Windows.Forms.Button Homeconf;
        private System.Windows.Forms.Button saveconf;
        private System.Windows.Forms.Button loadconf;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button home_reset;
        private System.Windows.Forms.Button startDAQ;
        private System.Windows.Forms.Button configuration;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button defaultpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setdefpath_txt;
    }
}

