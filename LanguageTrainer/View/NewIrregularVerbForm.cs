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
    public partial class NewIrregularVerbForm : Form
    {
        public List<string> levels;
        public Service engine;
        public NewIrregularVerbForm()
        {
            InitializeComponent();
        }

        private void NewIrregularVerb_Load(object sender, EventArgs e)
        {
            this.levels = new List<string>();
            this.engine = new Service();
            foreach (var item in engine.Levels)
            {
                this.levels.Add(item.LevelName);
            }
            comboBoxLevels.Items.AddRange(levels.ToArray());
            comboBoxLevels.SelectedIndex = 0;
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Level level = engine.Levels.Find(x => x.LevelName == comboBoxLevels.SelectedItem.ToString());
            
            engine.InsertNewIrregularVerb(textBoxBaseForm.Text, textBoxPastSimple.Text, textBoxPastParticiple.Text, 
                textBoxBulgarianVerb.Text, level.LevelId);
            this.Close();
        }
    }
}
