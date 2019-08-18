namespace LanguageTrainerDAL
{
    public class Word
    {
        private int id;
        private string englishWord;
        private string bulgarianWord;
        private string wordType;
        private byte[] wordPic;
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

        public Word(int id, string englishWord, string bulgarianWord, string wordType, byte[] wordPic)
        {
            Id = id;
            EnglishWord = englishWord;
            BulgarianWord = bulgarianWord;
            WordType = wordType;
            WordPic = wordPic;
        }

        public int Id { get => id; set => id = value; }
        public string EnglishWord { get => englishWord.ToString(); set => englishWord = value; }
        public string BulgarianWord { get => bulgarianWord; set => bulgarianWord = value; }
        public string WordType { get => wordType; set => wordType = value; }
        public byte[] WordPic { get => wordPic; set => wordPic = value; }
    }
}
