using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI_Display
{

    class Messages
    {
        public static string TEST_MESSAGES = "TESTING MESSAGE";
        public static string CONF_FIELDS_EMPTY_ERR = "Please fill all the fields";
        public static string CONF_READYTIME_NEGVAL_ERR = "Invalid Input for Readytime. Please input positive numeric number";
        public static string CONF_DELTAT_NEGVAL_ERR = "Invalid Input for delta T. Please input positive number";
        public static string CONF_WAVE_NEGVAL_ERR = "Invalid Input for Wave Velocity. Please input positive number";
        public static string CONF_WINDOW_NEGVAL_ERR = "Invalid Input for Window. Please input positive number";
        public static string CONF_COMPLETION_WARN = "Please complete configuration";
        public static string CONF_SAVE_CONFIRM = "Do you want to save configuration?";
        public static string CONF_SAVE_SUCC = "Configuration has been saved successfully.";
        public static string FILE_READ_ERR = "Error: Could not read file from disk. Original error: ";
        public static string CONF_LOAD_ERR_RECONNECT = "Could not Load. Please reconnect!";
        public static string FILE_SAVED_SUCC = "File has been saved at: ";
        public static string SAVEON_DEF_PATH_CONFIRM = "Do you want to save data on default path?";
        public static string SELECT_FOLDER_WARN = "Please Select folder!";
        public static string FILE_WRITE_ACCESS_ERR = "Current logged in user does not have write access to ";
        public static string DEF_SELECTED_MESSAGE = "Default path selected is ";
        public static string DEFAULT_PATH_MISSING_ERR = "Default path is not set. Please set default path for data files";
        public static string RESET_CONFIRM = "Do you want reset application?";
        public static string CONF_RESET_SUCC = "Application has been reseted";
        


    }
}
