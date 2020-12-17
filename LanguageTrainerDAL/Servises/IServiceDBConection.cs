using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainerDAL
{
    interface IServiceDBConection
    {
        List<Level> GetLevels();
        List<Theme> GetThemes();
    }
}
