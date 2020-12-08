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
    public partial class SearchForm : Form
    {
        public List<Word> searchWord;
        public Repository searchEngine;
        private int searchIndex = 0;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.searchEngine = new Repository();
        }

        private void ButtonSearchWord_Click(object sender, EventArgs e)
        {
            if (searchWord == null)
            {
                searchWord = searchEngine.SearchWord(textBoxEnglishWordSearch.Text.ToString());
            }
            else
            {
                searchWord.Clear();
                searchWord = searchEngine.SearchWord(textBoxEnglishWordSearch.Text.ToString());
            }

            if (searchWord.Count >= 1)
            {
                textBoxEnglishWordSearch.Text = searchWord[searchIndex].EnglishWord;
                textBoxBulgarianWordSearch.Text = searchWord[searchIndex].BulgarianWord;
                labelResultNumber.Text += "Find " + searchWord.Count.ToString() + " words";
            }
            else
            {
                string message = "No word: " + textBoxEnglishWordSearch.Text;
                labelResultNumber.Text = message;
            }
        }

        private void buttonSearchNext_Click(object sender, EventArgs e)
        {
            if (searchIndex < searchWord.Count - 1)
            {
                searchIndex++;
                textBoxEnglishWordSearch.Text = searchWord[searchIndex].EnglishWord;
                textBoxBulgarianWordSearch.Text = searchWord[searchIndex].BulgarianWord;
            }
            else
            {
                searchIndex = 0;
                textBoxEnglishWordSearch.Text = searchWord[searchIndex].EnglishWord;
                textBoxBulgarianWordSearch.Text = searchWord[searchIndex].BulgarianWord;
            }
        }

        private void TextBoxSearchWord_Click(object sender, EventArgs e)
        {
            textBoxEnglishWordSearch.Text = "";
            textBoxBulgarianWordSearch.Text = "";
            labelResultNumber.Text = "";
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxEnglishWordSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }
    }
}
