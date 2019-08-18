using LanguageTrainerDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class NewWordForm : Form
    {
        public List<string> levels;
        public List<string> subLevels;
        public List<string> themes;
        public List<string> types;
        public Engine engine;
        string fileName;
        byte[] bytes;
        string contentType;
        public NewWordForm()
        {
            InitializeComponent();
        }

        private void FormInsertNew_Load(object sender, EventArgs e)
        {
            this.levels = new List<string>();            
            this.themes = new List<string>();
            this.types = new List<string>();
            this.subLevels = new List<string>();
            this.engine = new Engine();
            foreach (var item in engine.Levels)
            {
                this.levels.Add(item.LevelName);
            }
            comboBoxLevels.Items.AddRange(levels.ToArray());
            comboBoxLevels.SelectedIndex = 0;
            this.themes = new List<string>();
            foreach (var item in engine.Themes)
            {
                this.themes.Add(item.ThemeName);
            }
            comboBoxThemes.Items.AddRange(themes.ToArray());
            comboBoxThemes.SelectedIndex = 0;
            foreach (var item in engine.Types)
            {
                this.types.Add(item.TypeName);
            }
            comboBoxTypes.Items.AddRange(types.ToArray());
            comboBoxTypes.SelectedIndex = 0;
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Level level = engine.Levels.Find(x => x.LevelName == comboBoxLevels.SelectedItem.ToString());
            SubLevel subLevel = engine.SubLevels.Find(x => x.SubLevelInt.ToString() == comboBoxSubLevels.SelectedItem.ToString());
            Theme theme = engine.Themes.Find(x => x.ThemeName == comboBoxThemes.SelectedItem.ToString());
            LanguageTrainerDAL.Type type = engine.Types.Find(x => x.TypeName == comboBoxTypes.SelectedItem.ToString());
            if (bytes == null)
            {
                engine.InsertNewWord(textBoxEnglish.Text, textBoxBulgarian.Text, level.LevelId, theme.ThemeId, type.TypeId, subLevel.SubLevelId);

            }
            else
            {
                engine.InsertNewWordWithImage(textBoxEnglish.Text, textBoxBulgarian.Text, level.LevelId, theme.ThemeId, type.TypeId, subLevel.SubLevelId, bytes, contentType);
            }
            this.Close();
        }

        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubLevels.Items.Clear();
            engine.GetSubLevels(comboBoxLevels.SelectedItem.ToString());
            subLevels.Clear();
            foreach (var item in engine.SubLevels)
            {
                this.subLevels.Add(item.SubLevelInt.ToString());
            }
            comboBoxSubLevels.Items.AddRange(subLevels.ToArray());
            comboBoxSubLevels.SelectedIndex = 0;
        }

        private void ButtonAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    bytes = File.ReadAllBytes(fileName);
                    contentType = "";

                    switch (Path.GetExtension(fileName))
                    {
                        case ".jpg":
                            contentType = "image/jpeg";
                            break;
                        case ".png":
                            contentType = "image/png";
                            break;
                    }

                }
            }
        }
    }
}
