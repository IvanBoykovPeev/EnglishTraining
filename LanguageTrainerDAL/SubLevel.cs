using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainerDAL
{

    public class SubLevel
    {
        private int subLevelId;
        private int subLevelInt;

        public SubLevel()
        {

        }

        public SubLevel(int id, int subLevel)
        {
            this.SubLevelId = id;
        }

        public int SubLevelId { get => subLevelId; set => subLevelId = value; }
        public int SubLevelInt { get => subLevelInt; set => subLevelInt = value; }
    }
}
