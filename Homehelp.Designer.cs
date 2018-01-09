namespace CUI_Display
{
    partial class Homehelp
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
            homehelpobj = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homehelp));
            this.helphome = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helphome
            // 
            this.helphome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helphome.Font = new System.Drawing.Font("GE Inspira Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helphome.Location = new System.Drawing.Point(2, 2);
            this.helphome.Name = "helphome";
            this.helphome.ReadOnly = true;
            this.helphome.Size = new System.Drawing.Size(951, 532);
            this.helphome.TabIndex = 0;
            this.helphome.Text = resources.GetString("helphome.Text");
            this.helphome.TextChanged += new System.EventHandler(this.helphome_TextChanged);
            // 
            // Homehelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 536);
            this.Controls.Add(this.helphome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homehelp";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helphome;
    }
}