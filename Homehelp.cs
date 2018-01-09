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
    public partial class Homehelp : Form
    {
        public static Homehelp homehelpobj;

       private Homehelp()
        {
            InitializeComponent();
        }

        public static Homehelp getinstance()
        {
            if (homehelpobj == null)
            {
                homehelpobj = new Homehelp();
            }
            return homehelpobj;
        }
        private void helphome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
