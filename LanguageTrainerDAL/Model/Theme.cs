using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainerDAL
{
    public class Theme
    {
        private int themeId;
        private string themeName;

        public Theme()
        {
        }

        public Theme(int id, string level)
        {
            themeId = id;
            themeName = level;
        }

        public int ThemeId { get => themeId; set => themeId = value; }
        public string ThemeName { get => themeName; set => themeName = value; }
    }
}
