namespace LanguageTrainerDAL
{
    public class Phrase
    {
        private int id;
        private string englishPhrase;
        private string bulgarianPhrase;

        public Phrase()
        {
        }

        public Phrase(int id, string englishPhrase, string bulgarianPhrase)
        {
            Id = id;
            EnglishPhrase = englishPhrase;
            BulgarianPhrase = bulgarianPhrase;
        }

        public int Id { get => id; set => id = value; }
        public string EnglishPhrase { get => englishPhrase; set => englishPhrase = value; }
        public string BulgarianPhrase { get => bulgarianPhrase; set => bulgarianPhrase = value; }
    }
}
