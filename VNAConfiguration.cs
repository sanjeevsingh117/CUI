using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI_Display
{
    public class VNAConfiguration
    {
        public String tagname;
        public double wavevelocity;
        public double deltat;
        public double window;
        public double readytime;
        public string default_path;
        public string configfilename;
        public String timestamp;

        public VNAConfiguration() { }
        public void setconfig(string tagname, double deltat, double window, double readytime, double wavevelocity, string configfilename,string default_path)
        {
            this.tagname = tagname;
            this.deltat = deltat;
            this.window = window;
            this.readytime = readytime;
            this.wavevelocity = wavevelocity;
            this.configfilename = configfilename;
            this.default_path = default_path;
        }

        public void getconfig()
        {
            Console.WriteLine("VNAConfiguration is set" 
                                +tagname + " " 
                                + wavevelocity + " " 
                                + deltat + " " 
                                + window + " " 
                                + readytime + " " 
                                + configfilename);
        }
        public void resetconfig()
        //resets the values of conf . parameteres to their defaults.
        {
            tagname = "";
            wavevelocity = 0;
            deltat = 0;
            window = 0;
            readytime = 0;
            this.configfilename = null;
            this.default_path = null;


        }
        public bool isConfigured()
        //checks if all parameteres are configured properly or not.
        {
            if (
                   configfilename == string.Empty
                || wavevelocity.ToString() == string.Empty  
                || readytime.ToString() == string.Empty
                || window.ToString() == string.Empty
                || deltat.ToString() == string.Empty
                || tagname == string.Empty
                || default_path ==String.Empty
                || default_path == null
                )
            {
                return false;
            }
            else
                return true;
        }
    }
}
