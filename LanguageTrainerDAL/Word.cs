namespace LanguageTrainerDAL
{
    public class Word
    {
        private int id;
        private string englishWord;
        private string bulgarianWord;
        private string wordType;
        public Word()
        {
        }

        public Word(int id, string englishWord, string bulgarianWord, string wordType)
        {
            Id = id;
            EnglishWord = englishWord;
            BulgarianWord = bulgarianWord;
            WordType = wordType;
        }

        public int Id { get => id; set => id = value; }
        public string EnglishWord { get => englishWord.ToString(); set => englishWord = value; }
        public string BulgarianWord { get => bulgarianWord; set => bulgarianWord = value; }
        public string WordType { get => wordType; set => wordType = value; }
    }
}
