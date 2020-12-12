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
        public Service repository;
        public List<string> levels;
        public List<string> subLevels;
        public List<string> themes;
        public List<string> types;
        public Random rd = new Random();
        public int currentRandom;
        bool IsWord = false;
        bool IsPhrase = false;
        bool IsIrregularVerb = false;
        bool IsPluralNoon = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.repository = new Service();
            this.levels = new List<string>();
            this.subLevels = new List<string>();
            panelMain.Hide();
            listBoxThemes.Visible = false;
            labelThemes.Visible = false;
            buttonByThemes.Visible = false;
            foreach (var item in repository.Levels)
            {
                this.levels.Add(item.LevelName);
            }
            comboBoxLevels.Items.AddRange(levels.ToArray());
            if (comboBoxLevels.Items.Count > 0)
            {
                comboBoxLevels.SelectedIndex = 0;
            }
            repository.GetSubLevels(comboBoxLevels.SelectedItem.ToString());
        }

        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubLevels.Items.Clear();
            if (comboBoxLevels.SelectedItem != null)
            {
            repository.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
            currentRandom = rd.Next(repository.Words.Count());
            }

            repository.GetSubLevels(comboBoxLevels.SelectedItem.ToString());
            subLevels.Clear();
            foreach (var item in repository.SubLevels)
            {
                this.subLevels.Add(item.SubLevelInt.ToString());
            }
            if (subLevels != null)
            {
            comboBoxSubLevels.Items.AddRange(subLevels.ToArray());
            comboBoxSubLevels.SelectedIndex = 0;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            if (IsWord)
            {
                repository.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Words.Count());
                textBoxEnglish.Text = repository.Words[currentRandom].EnglishWord.ToString();
            }
            if (IsPhrase)
            {
                repository.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Phrases.Count());
                textBoxEnglish.Text = repository.Phrases[currentRandom].EnglishPhrase.ToString();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            textBoxGuessPastParticiple.Clear();
            textBoxGuessVerb.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            pictureBox1.Image = null;
            
            if (IsWord)
            {
                currentRandom = rd.Next(repository.Words.Count());
                if (repository.Words.Count > 0)
                {
                textBoxEnglish.Text = repository.Words[currentRandom].EnglishWord.ToString();
                labelWordType.Text = repository.Words[currentRandom].WordType.ToString();
                textBoxGuessWord.Focus();
                }
            }
            if (IsPhrase)
            {
                currentRandom = rd.Next(repository.Phrases.Count());
                textBoxEnglish.Text = repository.Phrases[currentRandom].EnglishPhrase.ToString();
                textBoxGuessWord.Focus();
            }
            if (IsIrregularVerb)
            {
                currentRandom = rd.Next(repository.IrregularVerbs.Count());
                textBoxEnglish.Text = repository.IrregularVerbs[currentRandom].VerbBaseForm.ToString();
                textBoxGuessWord.Focus();
            }
            if (IsPluralNoon)
            {
                currentRandom = rd.Next(repository.Noun.Count());
                if (repository.Noun[currentRandom].Plural != null)
                {
                textBoxEnglish.Text = repository.Noun[currentRandom].EnglishWord.ToString();
                textBoxGuessWord.Focus();
                }
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (IsWord)
            {
                if (repository.Words[currentRandom].BulgarianWord.ToString().Contains(textBoxGuessWord.Text) &&
                    textBoxGuessWord.Text != "")
                {
                    labelResult.Text = "TRUE";
                    labelResult.BackColor = Color.LightGreen;
                }
                else
                {
                    labelResult.Text = "FALSE";
                    labelResult.BackColor = Color.OrangeRed;
                    textBoxGuessWord.Focus();
                }
            }
            if (IsIrregularVerb && textBoxEnglish.Text != "")
            {
                if (repository.IrregularVerbs[currentRandom].VerbPastSimple.ToString().Contains(textBoxGuessWord.Text) && 
                    textBoxGuessWord.Text != "")
                {
                    labelResult.Text = "TRUE";
                    labelResult.BackColor = Color.LightGreen;
                }
                else
                {
                    labelResult.Text = "FALSE";
                    labelResult.BackColor = Color.OrangeRed;
                    textBoxGuessWord.Focus();
                }
            }
            if (IsPluralNoon)
            {
                if (repository.Noun[currentRandom].Plural.ToString().Contains(textBoxGuessWord.Text) &&
                    textBoxGuessWord.Text != "")
                {
                    labelResult.Text = "TRUE";
                    labelResult.BackColor = Color.LightGreen;
                }
                else
                {
                    labelResult.Text = "FALSE";
                    labelResult.BackColor = Color.OrangeRed;
                    textBoxGuessWord.Focus();
                }
            }
        }

        private void buttonAnser_Click(object sender, EventArgs e)
        {
            textBoxGuessWord.Clear();
            if (IsWord)
            {
                textBoxGuessWord.Text = repository.Words[currentRandom].BulgarianWord.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            if (IsPhrase)
            {
                textBoxGuessWord.Text = repository.Phrases[currentRandom].BulgarianPhrase.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            if (IsIrregularVerb)
            {
                textBoxGuessWord.Text = repository.IrregularVerbs[currentRandom].VerbPastSimple.ToString();
                textBoxGuessPastParticiple.Text = repository.IrregularVerbs[currentRandom].VerbPastParticiple.ToString();
                textBoxGuessVerb.Text = repository.IrregularVerbs[currentRandom].BulgarianVerb.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            if (IsPluralNoon)
            {
                if (repository.Noun[currentRandom].Plural != null)
                {
                    textBoxGuessWord.Text = repository.Noun[currentRandom].Plural.ToString();
                    labelResult.Text = "TRUE";
                    labelResult.BackColor = Color.LightGreen;
                    textBoxGuessPastParticiple.Text = repository.Noun[currentRandom].BulgarianWord.ToString();
                }
            }
        }

        private void toolStripButtonWords_Click(object sender, EventArgs e)
        {
            IsWord = true;
            IsPhrase = false;
            IsIrregularVerb = false;
            IsPluralNoon = false;
            panelMain.Show();
            buttonByLevel.Text = "WORDS by Level";
            buttonByThemes.Text = "WORDS by Themes";
            labelEnglish.Text = "English Word";
            labelGuess.Text = "Guess Word";
            labelGuessVerb.Hide();
            buttonByTypes.Show();
            comboBoxTypes.Show();
            buttonByThemes.Show();
            labelThemes.Visible = true;
            labelTypes.Show();
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            textBoxGuessVerb.Hide();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            labelGuessPastParticiple.Hide();
            textBoxGuessPastParticiple.Hide();
            buttonBySubLevel.Show();
            labelSubLevel.Show();
            comboBoxSubLevels.Show();
            labelWordType.Show();

            this.themes = new List<string>();
            foreach (var item in repository.Themes)
            {
                this.themes.Add(item.ThemeName);
            }
            this.types = new List<string>();
            foreach (var item in repository.Types)
            {
                this.types.Add(item.TypeName);
            }
            comboBoxTypes.Items.AddRange(types.ToArray());
            comboBoxTypes.SelectedIndex = 0;
            listBoxThemes.Items.AddRange(themes.ToArray());
            listBoxThemes.SelectedIndex = 0;
            listBoxThemes.Visible = true;
        }

        private void toolStripButtonPhrases_Click(object sender, EventArgs e)
        {
            IsPhrase = true;
            IsWord = false;
            IsIrregularVerb = false;
            listBoxThemes.Visible = false;
            panelMain.Show();
            buttonByLevel.Text = "PHRASES by Level";
            buttonByThemes.Hide();
            labelThemes.Hide();
            labelEnglish.Text = "English Phrase";
            labelGuess.Text = "Guess Prase";
            labelWordType.Hide();
            labelTypes.Hide();
            buttonByTypes.Hide();
            comboBoxTypes.Hide();
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
        }

        private void buttonByLevel_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            pictureBox1.Image = null;
            if (IsWord)
            {                
                repository.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Words.Count());
                if (repository.Words.Count > 0)
                {
                    textBoxEnglish.Text = repository.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = repository.Words[currentRandom].WordType.ToString();
                                       
                    textBoxGuessWord.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't words in this level!");
                }
                
                
            }
            if (IsPhrase)
            {
                textBoxEnglish.Clear();
                textBoxGuessWord.Clear();
                textBoxGuessWord.Focus();
                repository.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Phrases.Count());
                textBoxEnglish.Text = repository.Phrases[currentRandom].EnglishPhrase.ToString();
            }
            if (IsIrregularVerb)
            {
                repository.GetIrregularVerbs(comboBoxLevels.SelectedItem.ToString());

                currentRandom = rd.Next(repository.IrregularVerbs.Count());
                if (repository.IrregularVerbs.Count > 0)
                {
                    textBoxEnglish.Text = repository.IrregularVerbs[currentRandom].VerbBaseForm.ToString();

                    textBoxGuessWord.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't verbs in this level!");
                }
            }
            if (IsPluralNoon)
            {
                repository.GetNounByLevel(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Noun.Count());
                if (repository.Noun.Count > 0)
                {
                    if (repository.Noun[currentRandom].Plural != null)
                    {
                        textBoxEnglish.Text = repository.Noun[currentRandom].EnglishWord.ToString();
                        textBoxGuessWord.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("There isn't nouns in this level!");
                }
            }
        }

        private static Image GetImages(byte[] wordPic)
        {
            using (MemoryStream ms = new MemoryStream(wordPic))
            {
                return (Image.FromStream(ms));
            }
        }

        private void buttonByThemes_Click(object sender, EventArgs e)
        {
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {
                repository.GetWordByTheme(listBoxThemes.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Words.Count());
                if (repository.Words.Count > 0)
                {
                    textBoxEnglish.Text = repository.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = repository.Words[currentRandom].WordType.ToString();
                    textBoxGuessWord.Focus();
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
            textBoxGuessWord.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {
                repository.GetWordByType(comboBoxTypes.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Words.Count());
                if (repository.Words.Count > 0)
                {
                    textBoxEnglish.Text = repository.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = repository.Words[currentRandom].WordType.ToString();
                    textBoxGuessWord.Focus();
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
            SubLevel subLevel = repository.SubLevels.Find(x => x.SubLevelInt.ToString() == comboBoxSubLevels.SelectedItem.ToString());
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            if (IsWord)
            {

                repository.GetWordsBySubLevels(comboBoxLevels.SelectedItem.ToString(), subLevel.SubLevelId);
                currentRandom = rd.Next(repository.Words.Count());
                if (repository.Words.Count > 0)
                {
                    textBoxEnglish.Text = repository.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = repository.Words[currentRandom].WordType.ToString();
                    textBoxGuessWord.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't words in this sub level!");
                }


            }
            if (IsPhrase)
            {
                textBoxEnglish.Clear();
                textBoxGuessWord.Clear();
                textBoxGuessWord.Focus();
                repository.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(repository.Phrases.Count());
                textBoxEnglish.Text = repository.Phrases[currentRandom].EnglishPhrase.ToString();
            }
        }

        private void toolStripButtonIregularVerbs_Click(object sender, EventArgs e)
        {
            IsIrregularVerb = true;
            IsWord = false;
            IsPhrase = false;
            IsPluralNoon = false;
            listBoxThemes.Visible = false;
            panelMain.Show();
            buttonByLevel.Text = "VERBS by Level";
            buttonBySubLevel.Hide();
            labelSubLevel.Hide();
            comboBoxSubLevels.Hide();
            buttonByThemes.Hide();
            labelThemes.Hide();
            labelEnglish.Text = "English Base Form";
            labelGuess.Text = "Guess Past Simple";
            labelTypes.Hide();
            labelWordType.Hide();
            labelGuessVerb.Show();
            labelGuessPastParticiple.Show();
            buttonByTypes.Hide();
            comboBoxTypes.Hide();
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            textBoxGuessVerb.Show();
            textBoxGuessPastParticiple.Show();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;

            
        }

        private void NewIrregularVerbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewIrregularVerbForm newIrregularForm = new NewIrregularVerbForm();
            newIrregularForm.Show();
        }

        private void ButtonShowPicture_Click(object sender, EventArgs e)
        {
            if(IsWord)
            {
                if (repository.Words[currentRandom].WordPic != null)
                {
                    pictureBox1.Image = GetImages(repository.Words[currentRandom].WordPic);
                }
            }
        }        

        private void ToolStripSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void EditWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }

        private void DeleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void toolStripButtonPluralNouns_Click(object sender, EventArgs e)
        {
            IsIrregularVerb = false;
            IsWord = false;
            IsPhrase = false;
            IsPluralNoon = true;
            listBoxThemes.Visible = false;
            panelMain.Show();
            buttonByLevel.Text = "NOUNS by Level";
            buttonBySubLevel.Hide();
            labelSubLevel.Hide();
            comboBoxSubLevels.Hide();
            buttonByThemes.Hide();
            labelThemes.Hide();
            labelEnglish.Text = "English noun";
            labelGuess.Text = "Guess plural";
            labelTypes.Hide();
            labelWordType.Hide();
            labelGuessVerb.Hide();
            labelGuessPastParticiple.Text = "Bulgarian noun";
            labelGuessPastParticiple.Show();
            buttonByTypes.Hide();
            comboBoxTypes.Hide();
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
            textBoxGuessVerb.Hide();
            textBoxGuessPastParticiple.Show();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
        }

    }
}
