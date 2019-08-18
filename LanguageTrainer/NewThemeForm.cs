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
    public partial class NewThemeForm : Form
    {
        public Engine engine;
        public NewThemeForm()
        {
            InitializeComponent();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            engine.InsertNewTheme(textBoxTheme.Text);
            this.Close();
        }

        private void NewThemeForm_Load(object sender, EventArgs e)
        {
            engine = new Engine();
        }
    }
}
