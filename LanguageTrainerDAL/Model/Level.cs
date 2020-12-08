using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainerDAL
{
    public class Level
    {
        private int levelId;
        private string levelName;

        public Level()
        {
        }

        public Level(int id, string level)
        {
            LevelId = id;
            LevelName = level;
        }

        public int LevelId { get => levelId; set => levelId = value; }
        public string LevelName { get => levelName; set => levelName = value; }
    }
}
