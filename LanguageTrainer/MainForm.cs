using LanguageTrainerDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class MainForm : Form
    {
        public Engine engine;
        public List<string> levels;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.engine = new Engine();
            this.levels = new List<string>();
            foreach (var item in engine.Levels)
            {
                this.levels.Add(item.LevelName);
            }
        }

        private void buttonWords_Click(object sender, EventArgs e)
        {
            
            comboBoxLevels.Items.AddRange(levels.ToArray());
        }

        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLevels.SelectedItem != null)
            {
                engine.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxLevels.SelectedItem.ToString());
            //engine.GetWordByLevel(comboBoxLevels.Selecte.ToString());
            //textBoxEnglishWord.Text = engine.Words[1].EnglishWord.ToString();
        }
    }
}
