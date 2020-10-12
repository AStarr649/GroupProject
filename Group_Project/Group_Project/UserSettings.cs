using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    public class UserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        //[DefaultSettingValue("Default")]

        public Color BackgroundColor
        {
            get
            {
                return ((Color)this["BackgroundColor"]);
            }
            set
            {
                this["BackgroundColor"] = (Color)value;
            }
        }
    }
}
