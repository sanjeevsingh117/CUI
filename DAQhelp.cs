using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUI_Display
{
    public partial class helpDAQ : Form
    {
        private static helpDAQ helpobject;

        private helpDAQ()
        {
            InitializeComponent();

        }

        public static helpDAQ getInstance()
        {
                if (helpobject == null)
                {
                    Console.WriteLine("helpobject is null");
                    helpobject = new helpDAQ();
                }
                return helpobject;
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
     private void helpconnect_Load(object sender, EventArgs e)
        {

        }
    }
}
