using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public static class Common
    {
        public static string SettingFilePath { get; set; }
        static Common()
        {
            SettingFilePath = Application.StartupPath + @"\" + Common.settingFileName;
        }
        public const string settingSection = "section";
        public const string settingFramework = "framework";
        public const string settingDirectory = "directory";
        public const string defaultFramework = @"C:\cocos2d-x";
        public const string defaultDirectory = @"C:\cocos2d-x\project";
        public const string settingFileName = "BuildCocos2DXTemplate.ini";
    }
}
