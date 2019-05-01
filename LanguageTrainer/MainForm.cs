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
    public partial class MainForm : Form
    {
        public engine engine;
        public List<string> levels;
        public List<string> subLevels;
        public List<string> themes;
        public List<string> types;
        public Random rd = new Random();
        public int currentRandom;
        bool IsWord = false;
        bool IsPhrase = false;
        private static string directory = Path.GetDirectoryName(Application.ExecutablePath);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.engine = new engine();
            this.levels = new List<string>();
            this.subLevels = new List<string>();
            panelGetBy.Visible = false;
            panelMain.Hide();
            listBoxThemes.Visible = false;
            labelThemes.Visible = false;
            buttonByThemes.Visible = false;
            foreach (var item in engine.Levels)
            {
                this.levels.Add(item.LevelName);
            }
            comboBoxLevels.Items.AddRange(levels.ToArray());
            comboBoxLevels.SelectedIndex = 0;
            engine.GetSubLevels(comboBoxLevels.SelectedItem.ToString());
            //comboBoxSubLevels.DataSource = subLevels;
        }

        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubLevels.Items.Clear();
            if (comboBoxLevels.SelectedItem != null)
            {
            engine.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
            currentRandom = rd.Next(engine.Words.Count());
            }

            engine.GetSubLevels(comboBoxLevels.SelectedItem.ToString());
            subLevels.Clear();
            foreach (var item in engine.SubLevels)
            {
                this.subLevels.Add(item.SubLevelInt.ToString());
            }
            comboBoxSubLevels.Items.AddRange(subLevels.ToArray());
            comboBoxSubLevels.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            if (IsWord)
            {
                engine.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
            }
            if (IsPhrase)
            {
                engine.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            
            
            if (IsWord)
            {
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                    textBoxGuess.Focus();
                }
            }
            if (IsPhrase)
            {
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
                textBoxGuess.Focus();
            }
            
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (engine.Words[currentRandom].BulgarianWord.ToString() == textBoxGuess.Text)
            {
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            else
            {
                labelResult.Text = "FALSE";
                labelResult.BackColor = Color.OrangeRed;
                textBoxGuess.Focus();
            }
        }

        private void buttonAnser_Click(object sender, EventArgs e)
        {
            textBoxGuess.Clear();
            if (IsWord)
            {
                textBoxGuess.Text = engine.Words[currentRandom].BulgarianWord.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            if (IsPhrase)
            {
                textBoxGuess.Text = engine.Phrases[currentRandom].BulgarianPhrase.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
        }

        private void toolStripButtonWords_Click(object sender, EventArgs e)
        {
            IsWord = true;
            IsPhrase = false;
            panelGetBy.Visible = true;
            panelMain.Show();
            buttonByLevel.Text = "WORDS by Level";
            buttonByThemes.Text = "WORDS by Themes";
            labelEnglish.Text = "English Word";
            labelGuess.Text = "Guess Word";
            buttonByTypes.Show();
            comboBoxTypes.Show();
            buttonByThemes.Show();
            labelThemes.Visible = true;
            labelTypes.Show();
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            
            

            this.themes = new List<string>();
            foreach (var item in engine.Themes)
            {
                this.themes.Add(item.ThemeName);
            }
            this.types = new List<string>();
            foreach (var item in engine.Types)
            {
                this.types.Add(item.TypeName);
            }
            comboBoxTypes.Items.AddRange(types.ToArray());
            comboBoxTypes.SelectedIndex = 0;
            listBoxThemes.Items.AddRange(themes.ToArray());
            listBoxThemes.SelectedIndex = 0;
            listBoxThemes.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            IsWord = false;
            IsPhrase = true;
            panelGetBy.Visible = true;
            listBoxThemes.Visible = false;
            panelMain.Show();
            buttonByLevel.Text = "PHRASES by Level";
            buttonByThemes.Hide();
            labelThemes.Hide();
            labelEnglish.Text = "English Phrase";
            labelGuess.Text = "Guess Prase";
            labelTypes.Hide();
            buttonByTypes.Hide();
            comboBoxTypes.Hide();
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
        }

        private void buttonByLevel_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {                
                engine.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                    textBoxGuess.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't words in this level!");
                }
                
                
            }
            if (IsPhrase)
            {
                textBoxEnglish.Clear();
                textBoxGuess.Clear();
                textBoxGuess.Focus();
                engine.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
            }
        }

        private void buttonByThemes_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {
                engine.GetWordByTheme(listBoxThemes.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                    textBoxGuess.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't words in this themes!");
                }
            }
        }

        private void buttonByTypes_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {
                engine.GetWordByType(comboBoxTypes.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                    textBoxGuess.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't words in this types!");
                }
            }
        }

        private void NewWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWordForm newWordForm = new NewWordForm();
            newWordForm.Show();
            newWordForm.ComboBoxThemes.Visible = true;
            newWordForm.ComboBoxTypes.Visible = true;
            newWordForm.LabelTheme.Visible = true;
            newWordForm.ComboBoxTypes.Visible = true;
        }

        private void newPhraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPhraseForm newPhraseForm = new NewPhraseForm();
            newPhraseForm.Show();            
        }

        private void newThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewThemeForm newThemeForm = new NewThemeForm();
            newThemeForm.Show();
        }

        private void buttonBySubLevel_Click(object sender, EventArgs e)
        {
            SubLevel subLevel = engine.SubLevels.Find(x => x.SubLevelInt.ToString() == comboBoxSubLevels.SelectedItem.ToString());
            textBoxEnglish.Clear();
            textBoxGuess.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {

                engine.GetWordsBySubLevels(comboBoxLevels.SelectedItem.ToString(), subLevel.SubLevelId);
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                    textBoxGuess.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't words in this sub level!");
                }


            }
            if (IsPhrase)
            {
                textBoxEnglish.Clear();
                textBoxGuess.Clear();
                textBoxGuess.Focus();
                engine.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
            }
        }

        private void comboBoxSubLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
