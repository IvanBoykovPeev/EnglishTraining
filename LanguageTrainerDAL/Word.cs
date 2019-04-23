namespace LanguageTrainerDAL
{
    public class Word
    {
        private int id;
        private string englishWord;
        private string bulgarianWord;

        public Word()
        {
        }

        public Word(int id, string englishWord, string bulgarianWord)
        {
            Id = id;
            EnglishWord = englishWord;
            BulgarianWord = bulgarianWord;
        }

        public int Id { get => id; set => id = value; }
        public string EnglishWord { get => englishWord.ToString(); set => englishWord = value; }
        public string BulgarianWord { get => bulgarianWord; set => bulgarianWord = value; }
    }
}
