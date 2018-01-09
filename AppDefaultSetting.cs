using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CUI_Display
{
    class AppDefaultSetting
    {
       //  public static string resourcepath = @"C:\Users\212612447\Documents\CUI\CUI_Display_updated1\CUI_Display_updated\CUI_Display\Properties\Resources.resx";
        public static string resourcepath = Directory.GetCurrentDirectory() + @"\Resources\CUIResource.resx";
        
        public AppDefaultSetting()
        {
            
        }
        public static string getDefaultPath()
        {      //Get existing resources
               // resourcepath = @"C:\Users\212612447\Documents\CUI\CUI_Display_updated1\CUI_Display_updated\CUI_Display\Properties\Resources.resx";
            String name = "DefaultPath";
            Hashtable resourceEntries = new Hashtable();
            ResXResourceReader reader = new ResXResourceReader(resourcepath);
            if (reader != null)
            {
                IDictionaryEnumerator id = reader.GetEnumerator();
                foreach (DictionaryEntry d in reader)
                {
                    if (d.Key.ToString().Equals(name))
                    {
                        if (d.Value == null)
                        {
                            reader.Close();
                            return "";
                        }
                        else
                        {
                            reader.Close();
                            return d.Value.ToString();
                        }

                    }
                    else
                        return "";
                }
                reader.Close();
                return "";
            }
            else
                return "";
        }
        public static void setDefaultPath(string newValue)
        {
            String name = "DefaultPath";
            Hashtable resourceEntries = new Hashtable();
            //Get existing resources
            ResXResourceReader reader = new ResXResourceReader(resourcepath);
            if (reader != null)
            {
                IDictionaryEnumerator id = reader.GetEnumerator();
                foreach (DictionaryEntry d in reader)
                {
                    if (d.Value == null)
                        resourceEntries.Add(d.Key.ToString(), "");
                    else
                        resourceEntries.Add(d.Key.ToString(), d.Value.ToString());
                }
                reader.Close();
            }
            //Modify resources here...
            foreach (DictionaryEntry d in resourceEntries)
            {
                if (d.Key.ToString().Equals(name))
                {
                    resourceEntries.Remove((object)name);
                    resourceEntries.Add(name, newValue);
                    break;
                }

            }
            //Write the combined resource file
            ResXResourceWriter resourceWriter = new ResXResourceWriter(resourcepath);

            foreach (String key in resourceEntries.Keys)
            {
                resourceWriter.AddResource(key, resourceEntries[key]);
            }
            resourceWriter.Generate();
            resourceWriter.Close();
        }


    }
}

