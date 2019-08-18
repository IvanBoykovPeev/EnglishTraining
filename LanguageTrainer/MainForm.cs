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
        public Engine engine;
        public List<string> levels;
        public List<string> subLevels;
        public List<string> themes;
        public List<string> types;
        public Random rd = new Random();
        public int currentRandom;
        bool IsWord = false;
        bool IsPhrase = false;
        bool IsIrregularVerb = false;
        public List<Word> searchWords;
        private int searchIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.engine = new Engine();
            this.levels = new List<string>();
            this.subLevels = new List<string>();
            panelGetBy.Visible = false;
            panelTheme.Visible = false;
            panelSearch.Visible = false;
            panelMain.Hide();
            listBoxThemes.Visible = false;
            labelThemes.Visible = false;
            buttonByThemes.Visible = false;
            foreach (var item in engine.Levels)
            {
                this.levels.Add(item.LevelName);
            }
            comboBoxLevels.Items.AddRange(levels.ToArray());
            if (comboBoxLevels.Items.Count > 0)
            {
            comboBoxLevels.SelectedIndex = 0;
            }
            engine.GetSubLevels(comboBoxLevels.SelectedItem.ToString());
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
            textBoxGuessWord.Clear();
            textBoxGuessPastParticiple.Clear();
            textBoxGuessVerb.Clear();
            labelResult.Text = "";
            labelResult.BackColor = SystemColors.Control;
            pictureBox1.Image = null;
            
            if (IsWord)
            {
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                textBoxGuessWord.Focus();
                }
            }
            if (IsPhrase)
            {
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
                textBoxGuessWord.Focus();
            }
            if (IsIrregularVerb)
            {
                currentRandom = rd.Next(engine.IrregularVerbs.Count());
                textBoxEnglish.Text = engine.IrregularVerbs[currentRandom].VerbBaseForm.ToString();
                textBoxGuessWord.Focus();
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (IsWord)
            {
                if (engine.Words[currentRandom].BulgarianWord.ToString().Contains(textBoxGuessWord.Text) &&
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
                if (engine.IrregularVerbs[currentRandom].VerbPastSimple.ToString().Contains(textBoxGuessWord.Text) && 
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
                textBoxGuessWord.Text = engine.Words[currentRandom].BulgarianWord.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            if (IsPhrase)
            {
                textBoxGuessWord.Text = engine.Phrases[currentRandom].BulgarianPhrase.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
            if (IsIrregularVerb)
            {
                textBoxGuessWord.Text = engine.IrregularVerbs[currentRandom].VerbPastSimple.ToString();
                textBoxGuessPastParticiple.Text = engine.IrregularVerbs[currentRandom].VerbPastParticiple.ToString();
                textBoxGuessVerb.Text = engine.IrregularVerbs[currentRandom].BulgarianVerb.ToString();
                labelResult.Text = "TRUE";
                labelResult.BackColor = Color.LightGreen;
            }
        }

        private void toolStripButtonWords_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.panelSearch);
            IsWord = true;
            IsPhrase = false;
            IsIrregularVerb = false;
            panelGetBy.Visible = true;
            panelTheme.Visible = true;
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
            textBoxSearchWord.Text = "Seatch word";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            IsPhrase = true;
            IsWord = false;
            IsIrregularVerb = false;
            panelGetBy.Visible = true;
            panelTheme.Visible = false;
            panelSearch.Visible = false;
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
                engine.GetWordByLevel(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
                                       
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
                engine.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
            }
            if (IsIrregularVerb)
            {
                engine.GetIrregularVerbs(comboBoxLevels.SelectedItem.ToString());

                currentRandom = rd.Next(engine.IrregularVerbs.Count());
                if (engine.IrregularVerbs.Count > 0)
                {
                    textBoxEnglish.Text = engine.IrregularVerbs[currentRandom].VerbBaseForm.ToString();

                    textBoxGuessWord.Focus();
                }
                else
                {
                    MessageBox.Show("There isn't verbs in this level!");
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
                engine.GetWordByTheme(listBoxThemes.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
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
                engine.GetWordByType(comboBoxTypes.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Words.Count());
                if (engine.Words.Count > 0)
                {
                    textBoxEnglish.Text = engine.Words[currentRandom].EnglishWord.ToString();
                    labelWordType.Text = engine.Words[currentRandom].WordType.ToString();
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
            SubLevel subLevel = engine.SubLevels.Find(x => x.SubLevelInt.ToString() == comboBoxSubLevels.SelectedItem.ToString());
            textBoxEnglish.Clear();
            textBoxGuessWord.Clear();
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
                engine.GetPhrases(comboBoxLevels.SelectedItem.ToString());
                currentRandom = rd.Next(engine.Phrases.Count());
                textBoxEnglish.Text = engine.Phrases[currentRandom].EnglishPhrase.ToString();
            }
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            IsIrregularVerb = true;
            IsWord = false;
            IsPhrase = false;
            panelGetBy.Visible = true;
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
                if (engine.Words[currentRandom].WordPic != null)
                {
                    pictureBox1.Image = GetImages(engine.Words[currentRandom].WordPic);
                }
            }
        }

        private void ButtonSearchWord_Click(object sender, EventArgs e)
        {
            labelResultNumber.Text = "Find: ";
            if (searchWords == null)
            {
                searchWords = engine.SearchWord(textBoxSearchWord.Text.ToString());
            }
            else
            {
                searchWords.Clear();
                searchWords = engine.SearchWord(textBoxSearchWord.Text.ToString());
            }
            
            if (searchWords.Count >= 1)
            {                
                textBoxEnglishWordSearch.Text = searchWords[searchIndex].EnglishWord;
                textBoxBulgarianWordSearch.Text = searchWords[searchIndex].BulgarianWord;
                labelResultNumber.Text += searchWords.Count.ToString() + " words";
            }
            else
            {
                string message = "No word: " + textBoxSearchWord.Text;
                labelResultNumber.Text = message;
            }
            textBoxSearchWord.Text = "Seartch word";
        }

        private void buttonSearchNext_Click(object sender, EventArgs e)
        {
            if (searchIndex < searchWords.Count - 1)
            {
                searchIndex++;
                textBoxEnglishWordSearch.Text = searchWords[searchIndex].EnglishWord;
                textBoxBulgarianWordSearch.Text = searchWords[searchIndex].BulgarianWord;
            }
            else
            {
                searchIndex = 0;
                textBoxEnglishWordSearch.Text = searchWords[searchIndex].EnglishWord;
                textBoxBulgarianWordSearch.Text = searchWords[searchIndex].BulgarianWord;
            }
        }

        private void TextBoxSearchWord_Click(object sender, EventArgs e)
        {
            textBoxSearchWord.Text = "";
        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            panelGetBy.Hide();
            panelTheme.Hide();
            panelMain.Hide();
            
            panelSearch.Visible = true;
            //searchPanel.Show();
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
    }
}
