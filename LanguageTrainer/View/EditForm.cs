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
    public partial class EditForm : Form
    {
        public List<Word> searchWords;
        private int searchIndex = 0;
        private ServiceMSLockalDb engine;


        public EditForm()
        {
            InitializeComponent();
        }

        private void ButtonSearchWord_Click(object sender, EventArgs e)
        {
            textBoxFindedWord.Text = "Find: ";
            if (searchWords == null)
            {
                searchWords = engine.SearchWord(textBoxSearch.Text.ToString());
            }
            else
            {
                searchWords.Clear();
                searchWords = engine.SearchWord(textBoxSearch.Text.ToString());
            }
            if (searchWords.Count >= 1)
            {
                textBoxEnglish.Text = searchWords[searchIndex].EnglishWord;
                textBoxBulgarian.Text = searchWords[searchIndex].BulgarianWord;
                textBoxFindedWord.Text += searchWords.Count.ToString() + " words";
            }
            else
            {
                string message = "No word: " + textBoxSearch.Text;
                textBoxFindedWord.Text = message;
            }
            textBoxSearch.Text = "Search word";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            engine = new ServiceMSLockalDb();
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (searchIndex < searchWords.Count - 1)
            {
                searchIndex++;
                textBoxEnglish.Text = searchWords[searchIndex].EnglishWord;
                textBoxBulgarian.Text = searchWords[searchIndex].BulgarianWord;
            }
            else
            {
                searchIndex = 0;
                textBoxEnglish.Text = searchWords[searchIndex].EnglishWord;
                textBoxBulgarian.Text = searchWords[searchIndex].BulgarianWord;
            }
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (searchWords != null)
            {
            engine.EditWord(searchWords[searchIndex].Id, textBoxEnglish.Text, textBoxBulgarian.Text);
            }
            this.Close();
        }
    }
}
