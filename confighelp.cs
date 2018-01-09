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
    public partial class Confighelp : Form
    {
        public static Confighelp confighelpobj;

      private Confighelp()
        {
            InitializeComponent();
        }

        public static Confighelp getinstance()
        {
            if (confighelpobj == null)
            {
                confighelpobj = new Confighelp();
            }
            return confighelpobj;
        }
        private void confhelp_TextChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
