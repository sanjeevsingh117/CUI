namespace CUI_Display
{
    partial class cui_data_inject
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
            cui_data_inject_obj = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uaa_uri_lbl = new System.Windows.Forms.Label();
            this.uaa_uri_txt = new System.Windows.Forms.TextBox();
            this.injection_uri_lbl = new System.Windows.Forms.Label();
            this.query_uri_lbl = new System.Windows.Forms.Label();
            this.zone_header_name_lbl = new System.Windows.Forms.Label();
            this.zone_header_value_lbl = new System.Windows.Forms.Label();
            this.injection_uri_txt = new System.Windows.Forms.TextBox();
            this.query_uri_txt = new System.Windows.Forms.TextBox();
            this.zone_header_name_txt = new System.Windows.Forms.TextBox();
            this.zone_header_val_txt = new System.Windows.Forms.TextBox();
            this.proxy_lbl = new System.Windows.Forms.Label();
            this.proxy_uri_txt = new System.Windows.Forms.TextBox();
            this.cui_data_inject_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.new_user_radio = new System.Windows.Forms.RadioButton();
            this.existing_user_radio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grant_pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.password_radio = new System.Windows.Forms.RadioButton();
            this.client_cred_radio = new System.Windows.Forms.RadioButton();
            this.pwd_pnl = new System.Windows.Forms.Panel();
            this.client_pnl = new System.Windows.Forms.Panel();
            this.client_Secret_txt = new System.Windows.Forms.TextBox();
            this.client_id_txt = new System.Windows.Forms.TextBox();
            this.client_secret_lbl = new System.Windows.Forms.Label();
            this.client_id_lbl = new System.Windows.Forms.Label();
            this.pwd_client_lbl = new System.Windows.Forms.Label();
            this.pwd_client_txt = new System.Windows.Forms.TextBox();
            this.pwd_pwd_txt = new System.Windows.Forms.TextBox();
            this.pwd_client_secret_lbl = new System.Windows.Forms.Label();
            this.pwd_pwd_lbl = new System.Windows.Forms.Label();
            this.pwd_client_secret_txt = new System.Windows.Forms.TextBox();
            this.cui_data_inject_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grant_pnl.SuspendLayout();
            this.pwd_pnl.SuspendLayout();
            this.client_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // uaa_uri_lbl
            // 
            this.uaa_uri_lbl.AutoSize = true;
            this.uaa_uri_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaa_uri_lbl.ForeColor = System.Drawing.Color.White;
            this.uaa_uri_lbl.Location = new System.Drawing.Point(26, 25);
            this.uaa_uri_lbl.Name = "uaa_uri_lbl";
            this.uaa_uri_lbl.Size = new System.Drawing.Size(67, 19);
            this.uaa_uri_lbl.TabIndex = 0;
            this.uaa_uri_lbl.Text = "UAA URI";
            this.uaa_uri_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // uaa_uri_txt
            // 
            this.uaa_uri_txt.Location = new System.Drawing.Point(190, 24);
            this.uaa_uri_txt.Name = "uaa_uri_txt";
            this.uaa_uri_txt.Size = new System.Drawing.Size(148, 20);
            this.uaa_uri_txt.TabIndex = 1;
            // 
            // injection_uri_lbl
            // 
            this.injection_uri_lbl.AutoSize = true;
            this.injection_uri_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injection_uri_lbl.ForeColor = System.Drawing.Color.White;
            this.injection_uri_lbl.Location = new System.Drawing.Point(21, 82);
            this.injection_uri_lbl.Name = "injection_uri_lbl";
            this.injection_uri_lbl.Size = new System.Drawing.Size(103, 19);
            this.injection_uri_lbl.TabIndex = 2;
            this.injection_uri_lbl.Text = "Ingestion URI";
            // 
            // query_uri_lbl
            // 
            this.query_uri_lbl.AutoSize = true;
            this.query_uri_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query_uri_lbl.ForeColor = System.Drawing.Color.White;
            this.query_uri_lbl.Location = new System.Drawing.Point(26, 134);
            this.query_uri_lbl.Name = "query_uri_lbl";
            this.query_uri_lbl.Size = new System.Drawing.Size(80, 19);
            this.query_uri_lbl.TabIndex = 3;
            this.query_uri_lbl.Text = "Query URI";
            // 
            // zone_header_name_lbl
            // 
            this.zone_header_name_lbl.AutoSize = true;
            this.zone_header_name_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone_header_name_lbl.ForeColor = System.Drawing.Color.White;
            this.zone_header_name_lbl.Location = new System.Drawing.Point(20, 188);
            this.zone_header_name_lbl.Name = "zone_header_name_lbl";
            this.zone_header_name_lbl.Size = new System.Drawing.Size(139, 19);
            this.zone_header_name_lbl.TabIndex = 4;
            this.zone_header_name_lbl.Text = "Zone header name";
            // 
            // zone_header_value_lbl
            // 
            this.zone_header_value_lbl.AutoSize = true;
            this.zone_header_value_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone_header_value_lbl.ForeColor = System.Drawing.Color.White;
            this.zone_header_value_lbl.Location = new System.Drawing.Point(21, 241);
            this.zone_header_value_lbl.Name = "zone_header_value_lbl";
            this.zone_header_value_lbl.Size = new System.Drawing.Size(138, 19);
            this.zone_header_value_lbl.TabIndex = 5;
            this.zone_header_value_lbl.Text = "Zone header value";
            // 
            // injection_uri_txt
            // 
            this.injection_uri_txt.Location = new System.Drawing.Point(190, 81);
            this.injection_uri_txt.Name = "injection_uri_txt";
            this.injection_uri_txt.Size = new System.Drawing.Size(148, 20);
            this.injection_uri_txt.TabIndex = 6;
            // 
            // query_uri_txt
            // 
            this.query_uri_txt.Location = new System.Drawing.Point(190, 135);
            this.query_uri_txt.Name = "query_uri_txt";
            this.query_uri_txt.Size = new System.Drawing.Size(148, 20);
            this.query_uri_txt.TabIndex = 7;
            // 
            // zone_header_name_txt
            // 
            this.zone_header_name_txt.Location = new System.Drawing.Point(190, 188);
            this.zone_header_name_txt.Name = "zone_header_name_txt";
            this.zone_header_name_txt.Size = new System.Drawing.Size(148, 20);
            this.zone_header_name_txt.TabIndex = 8;
            // 
            // zone_header_val_txt
            // 
            this.zone_header_val_txt.Location = new System.Drawing.Point(190, 241);
            this.zone_header_val_txt.Name = "zone_header_val_txt";
            this.zone_header_val_txt.Size = new System.Drawing.Size(148, 20);
            this.zone_header_val_txt.TabIndex = 9;
            // 
            // proxy_lbl
            // 
            this.proxy_lbl.AutoSize = true;
            this.proxy_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxy_lbl.ForeColor = System.Drawing.Color.White;
            this.proxy_lbl.Location = new System.Drawing.Point(37, 301);
            this.proxy_lbl.Name = "proxy_lbl";
            this.proxy_lbl.Size = new System.Drawing.Size(78, 19);
            this.proxy_lbl.TabIndex = 10;
            this.proxy_lbl.Text = "Proxy URI";
            // 
            // proxy_uri_txt
            // 
            this.proxy_uri_txt.Location = new System.Drawing.Point(190, 300);
            this.proxy_uri_txt.Name = "proxy_uri_txt";
            this.proxy_uri_txt.Size = new System.Drawing.Size(148, 20);
            this.proxy_uri_txt.TabIndex = 11;
            // 
            // cui_data_inject_pnl
            // 
            this.cui_data_inject_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cui_data_inject_pnl.AutoSize = true;
            this.cui_data_inject_pnl.BackColor = System.Drawing.Color.Gray;
            this.cui_data_inject_pnl.Controls.Add(this.proxy_uri_txt);
            this.cui_data_inject_pnl.Controls.Add(this.proxy_lbl);
            this.cui_data_inject_pnl.Controls.Add(this.zone_header_val_txt);
            this.cui_data_inject_pnl.Controls.Add(this.zone_header_name_txt);
            this.cui_data_inject_pnl.Controls.Add(this.query_uri_txt);
            this.cui_data_inject_pnl.Controls.Add(this.injection_uri_txt);
            this.cui_data_inject_pnl.Controls.Add(this.zone_header_value_lbl);
            this.cui_data_inject_pnl.Controls.Add(this.zone_header_name_lbl);
            this.cui_data_inject_pnl.Controls.Add(this.query_uri_lbl);
            this.cui_data_inject_pnl.Controls.Add(this.injection_uri_lbl);
            this.cui_data_inject_pnl.Controls.Add(this.uaa_uri_txt);
            this.cui_data_inject_pnl.Controls.Add(this.uaa_uri_lbl);
            this.cui_data_inject_pnl.Location = new System.Drawing.Point(583, 3);
            this.cui_data_inject_pnl.Name = "cui_data_inject_pnl";
            this.cui_data_inject_pnl.Size = new System.Drawing.Size(416, 425);
            this.cui_data_inject_pnl.TabIndex = 0;
            this.cui_data_inject_pnl.Visible = false;
            this.cui_data_inject_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.new_user_radio);
            this.panel1.Controls.Add(this.existing_user_radio);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 425);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.DimGray;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(0, 208);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(211, 32);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // new_user_radio
            // 
            this.new_user_radio.AutoSize = true;
            this.new_user_radio.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_user_radio.ForeColor = System.Drawing.Color.White;
            this.new_user_radio.Location = new System.Drawing.Point(63, 130);
            this.new_user_radio.Name = "new_user_radio";
            this.new_user_radio.Size = new System.Drawing.Size(80, 23);
            this.new_user_radio.TabIndex = 1;
            this.new_user_radio.Text = "Sign Up";
            this.new_user_radio.UseVisualStyleBackColor = true;
            this.new_user_radio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // existing_user_radio
            // 
            this.existing_user_radio.AutoSize = true;
            this.existing_user_radio.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existing_user_radio.ForeColor = System.Drawing.Color.White;
            this.existing_user_radio.Location = new System.Drawing.Point(63, 57);
            this.existing_user_radio.Name = "existing_user_radio";
            this.existing_user_radio.Size = new System.Drawing.Size(65, 23);
            this.existing_user_radio.TabIndex = 0;
            this.existing_user_radio.Text = "Login";
            this.existing_user_radio.UseVisualStyleBackColor = true;
            this.existing_user_radio.CheckedChanged += new System.EventHandler(this.existing_user_radio_CheckedChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.75649F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.01597F));
            this.tableLayoutPanel1.Controls.Add(this.grant_pnl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cui_data_inject_pnl, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 431);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grant_pnl
            // 
            this.grant_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grant_pnl.BackColor = System.Drawing.Color.Gray;
            this.grant_pnl.Controls.Add(this.label2);
            this.grant_pnl.Controls.Add(this.password_radio);
            this.grant_pnl.Controls.Add(this.client_cred_radio);
            this.grant_pnl.Controls.Add(this.pwd_pnl);
            this.grant_pnl.Location = new System.Drawing.Point(220, 3);
            this.grant_pnl.Name = "grant_pnl";
            this.grant_pnl.Size = new System.Drawing.Size(357, 425);
            this.grant_pnl.TabIndex = 2;
            this.grant_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.grant_pnl_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Select Grant type ";
            // 
            // password_radio
            // 
            this.password_radio.AutoSize = true;
            this.password_radio.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_radio.ForeColor = System.Drawing.Color.White;
            this.password_radio.Location = new System.Drawing.Point(18, 135);
            this.password_radio.Name = "password_radio";
            this.password_radio.Size = new System.Drawing.Size(95, 23);
            this.password_radio.TabIndex = 31;
            this.password_radio.TabStop = true;
            this.password_radio.Text = "Password";
            this.password_radio.UseVisualStyleBackColor = true;
            this.password_radio.CheckedChanged += new System.EventHandler(this.password_radio_CheckedChanged);
            // 
            // client_cred_radio
            // 
            this.client_cred_radio.AutoSize = true;
            this.client_cred_radio.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_cred_radio.ForeColor = System.Drawing.Color.White;
            this.client_cred_radio.Location = new System.Drawing.Point(18, 80);
            this.client_cred_radio.Name = "client_cred_radio";
            this.client_cred_radio.Size = new System.Drawing.Size(147, 23);
            this.client_cred_radio.TabIndex = 30;
            this.client_cred_radio.TabStop = true;
            this.client_cred_radio.Text = "Client Credential";
            this.client_cred_radio.UseVisualStyleBackColor = true;
            this.client_cred_radio.CheckedChanged += new System.EventHandler(this.client_cred_radio_CheckedChanged);
            // 
            // pwd_pnl
            // 
            this.pwd_pnl.Controls.Add(this.client_pnl);
            this.pwd_pnl.Controls.Add(this.pwd_client_lbl);
            this.pwd_pnl.Controls.Add(this.pwd_client_txt);
            this.pwd_pnl.Controls.Add(this.pwd_pwd_txt);
            this.pwd_pnl.Controls.Add(this.pwd_client_secret_lbl);
            this.pwd_pnl.Controls.Add(this.pwd_pwd_lbl);
            this.pwd_pnl.Controls.Add(this.pwd_client_secret_txt);
            this.pwd_pnl.Location = new System.Drawing.Point(3, 205);
            this.pwd_pnl.Name = "pwd_pnl";
            this.pwd_pnl.Size = new System.Drawing.Size(258, 153);
            this.pwd_pnl.TabIndex = 33;
            this.pwd_pnl.Visible = false;
            // 
            // client_pnl
            // 
            this.client_pnl.Controls.Add(this.client_Secret_txt);
            this.client_pnl.Controls.Add(this.client_id_txt);
            this.client_pnl.Controls.Add(this.client_secret_lbl);
            this.client_pnl.Controls.Add(this.client_id_lbl);
            this.client_pnl.Location = new System.Drawing.Point(12, 12);
            this.client_pnl.Name = "client_pnl";
            this.client_pnl.Size = new System.Drawing.Size(243, 121);
            this.client_pnl.TabIndex = 28;
            this.client_pnl.Visible = false;
            // 
            // client_Secret_txt
            // 
            this.client_Secret_txt.Location = new System.Drawing.Point(139, 64);
            this.client_Secret_txt.Name = "client_Secret_txt";
            this.client_Secret_txt.PasswordChar = '*';
            this.client_Secret_txt.Size = new System.Drawing.Size(100, 20);
            this.client_Secret_txt.TabIndex = 25;
            // 
            // client_id_txt
            // 
            this.client_id_txt.Location = new System.Drawing.Point(139, 17);
            this.client_id_txt.Name = "client_id_txt";
            this.client_id_txt.PasswordChar = '*';
            this.client_id_txt.Size = new System.Drawing.Size(100, 20);
            this.client_id_txt.TabIndex = 24;
            // 
            // client_secret_lbl
            // 
            this.client_secret_lbl.AutoSize = true;
            this.client_secret_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_secret_lbl.ForeColor = System.Drawing.Color.White;
            this.client_secret_lbl.Location = new System.Drawing.Point(3, 65);
            this.client_secret_lbl.Name = "client_secret_lbl";
            this.client_secret_lbl.Size = new System.Drawing.Size(99, 19);
            this.client_secret_lbl.TabIndex = 23;
            this.client_secret_lbl.Text = "Client Secret";
            // 
            // client_id_lbl
            // 
            this.client_id_lbl.AutoSize = true;
            this.client_id_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_id_lbl.ForeColor = System.Drawing.Color.White;
            this.client_id_lbl.Location = new System.Drawing.Point(3, 17);
            this.client_id_lbl.Name = "client_id_lbl";
            this.client_id_lbl.Size = new System.Drawing.Size(69, 19);
            this.client_id_lbl.TabIndex = 22;
            this.client_id_lbl.Text = "Client Id";
            // 
            // pwd_client_lbl
            // 
            this.pwd_client_lbl.AutoSize = true;
            this.pwd_client_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_client_lbl.ForeColor = System.Drawing.Color.White;
            this.pwd_client_lbl.Location = new System.Drawing.Point(28, 12);
            this.pwd_client_lbl.Name = "pwd_client_lbl";
            this.pwd_client_lbl.Size = new System.Drawing.Size(69, 19);
            this.pwd_client_lbl.TabIndex = 22;
            this.pwd_client_lbl.Text = "Client Id";
            // 
            // pwd_client_txt
            // 
            this.pwd_client_txt.Location = new System.Drawing.Point(121, 11);
            this.pwd_client_txt.Name = "pwd_client_txt";
            this.pwd_client_txt.PasswordChar = '*';
            this.pwd_client_txt.Size = new System.Drawing.Size(100, 20);
            this.pwd_client_txt.TabIndex = 24;
            // 
            // pwd_pwd_txt
            // 
            this.pwd_pwd_txt.Location = new System.Drawing.Point(121, 97);
            this.pwd_pwd_txt.Name = "pwd_pwd_txt";
            this.pwd_pwd_txt.PasswordChar = '*';
            this.pwd_pwd_txt.Size = new System.Drawing.Size(100, 20);
            this.pwd_pwd_txt.TabIndex = 27;
            // 
            // pwd_client_secret_lbl
            // 
            this.pwd_client_secret_lbl.AutoSize = true;
            this.pwd_client_secret_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_client_secret_lbl.ForeColor = System.Drawing.Color.White;
            this.pwd_client_secret_lbl.Location = new System.Drawing.Point(8, 55);
            this.pwd_client_secret_lbl.Name = "pwd_client_secret_lbl";
            this.pwd_client_secret_lbl.Size = new System.Drawing.Size(99, 19);
            this.pwd_client_secret_lbl.TabIndex = 23;
            this.pwd_client_secret_lbl.Text = "Client Secret";
            // 
            // pwd_pwd_lbl
            // 
            this.pwd_pwd_lbl.AutoSize = true;
            this.pwd_pwd_lbl.Font = new System.Drawing.Font("GE Inspira Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_pwd_lbl.ForeColor = System.Drawing.Color.White;
            this.pwd_pwd_lbl.Location = new System.Drawing.Point(20, 96);
            this.pwd_pwd_lbl.Name = "pwd_pwd_lbl";
            this.pwd_pwd_lbl.Size = new System.Drawing.Size(77, 19);
            this.pwd_pwd_lbl.TabIndex = 26;
            this.pwd_pwd_lbl.Text = "Password";
            // 
            // pwd_client_secret_txt
            // 
            this.pwd_client_secret_txt.Location = new System.Drawing.Point(121, 56);
            this.pwd_client_secret_txt.Name = "pwd_client_secret_txt";
            this.pwd_client_secret_txt.PasswordChar = '*';
            this.pwd_client_secret_txt.Size = new System.Drawing.Size(100, 20);
            this.pwd_client_secret_txt.TabIndex = 25;
            // 
            // cui_data_inject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "cui_data_inject";
            this.Text = "cui_data_inject";
            this.cui_data_inject_pnl.ResumeLayout(false);
            this.cui_data_inject_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grant_pnl.ResumeLayout(false);
            this.grant_pnl.PerformLayout();
            this.pwd_pnl.ResumeLayout(false);
            this.pwd_pnl.PerformLayout();
            this.client_pnl.ResumeLayout(false);
            this.client_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uaa_uri_lbl;
        private System.Windows.Forms.TextBox uaa_uri_txt;
        private System.Windows.Forms.Label injection_uri_lbl;
        private System.Windows.Forms.Label query_uri_lbl;
        private System.Windows.Forms.Label zone_header_name_lbl;
        private System.Windows.Forms.Label zone_header_value_lbl;
        private System.Windows.Forms.TextBox injection_uri_txt;
        private System.Windows.Forms.TextBox query_uri_txt;
        private System.Windows.Forms.TextBox zone_header_name_txt;
        private System.Windows.Forms.TextBox zone_header_val_txt;
        private System.Windows.Forms.Label proxy_lbl;
        private System.Windows.Forms.TextBox proxy_uri_txt;
        private System.Windows.Forms.Panel cui_data_inject_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton new_user_radio;
        private System.Windows.Forms.RadioButton existing_user_radio;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel grant_pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton password_radio;
        private System.Windows.Forms.RadioButton client_cred_radio;
        private System.Windows.Forms.Panel pwd_pnl;
        private System.Windows.Forms.Panel client_pnl;
        private System.Windows.Forms.TextBox client_Secret_txt;
        private System.Windows.Forms.TextBox client_id_txt;
        private System.Windows.Forms.Label client_secret_lbl;
        private System.Windows.Forms.Label client_id_lbl;
        private System.Windows.Forms.Label pwd_client_lbl;
        private System.Windows.Forms.TextBox pwd_client_txt;
        private System.Windows.Forms.TextBox pwd_pwd_txt;
        private System.Windows.Forms.Label pwd_client_secret_lbl;
        private System.Windows.Forms.Label pwd_pwd_lbl;
        private System.Windows.Forms.TextBox pwd_client_secret_txt;
    }
}