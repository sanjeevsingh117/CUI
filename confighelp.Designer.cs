namespace CUI_Display
{
    partial class Confighelp
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
            confighelpobj = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confighelp));
            this.confhelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // confhelp
            // 
            this.confhelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confhelp.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confhelp.Location = new System.Drawing.Point(3, 12);
            this.confhelp.Name = "confhelp";
            this.confhelp.ReadOnly = true;
            this.confhelp.Size = new System.Drawing.Size(964, 516);
            this.confhelp.TabIndex = 0;
            this.confhelp.Text = resources.GetString("confhelp.Text");
            this.confhelp.TextChanged += new System.EventHandler(this.confhelp_TextChanged);
            // 
            // Confighelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 523);
            this.Controls.Add(this.confhelp);
            this.Name = "Confighelp";
            this.Text = "confighelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox confhelp;
    }
}