using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LanguageTrainerDAL
{
    public class Engine
    {
        private string connectionString = @"server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\blade\Source\Repos\LanguageTrainer\LanguageTrainer\DatabaseWordBank.mdf;Integrated Security = True";
            //@"server=.;" +
            //"integrated security=true;database=WordBank";
        private SqlConnection connection;
        private List<Level> levels = new List<Level>();
        private List<Theme> themes = new List<Theme>();
        private List<Type> types = new List<Type>();
        private List<Word> words = new List<Word>();
        private List<Phrase> phrases = new List<Phrase>();

        public Engine()
        {
            connection = new SqlConnection(connectionString);
            GetLevels();
            GetThemes();
            GetTypes();
        }

        public void GetThemes()
        {
            try
            {
                string sql = "SELECT ThemeID, ThemeName FROM Themes";
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Theme theme = new Theme();
                        theme.ThemeId = reader.GetInt32(0);
                        theme.ThemeName = reader.GetString(1);
                        Themes.Add(theme);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetLevels()
        {
            try
            {
                string sql = "SELECT LevelID, LevelName FROM Levels";
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Level templevel = new Level();
                        templevel.LevelId = reader.GetInt32(0);
                        templevel.LevelName = reader.GetString(1);
                        Levels.Add(templevel);
                    }
                }                
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetTypes()
        {
            try
            {
                string sql = "SELECT TypeID, TypeName FROM Types";
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Type type = new Type();
                        type.TypeId = reader.GetInt32(0);
                        type.TypeName = reader.GetString(1);
                        Types.Add(type);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetPhrases(string level)
        {
            try
            {
                string sqlCommand = "SELECT PhraseID, EnglishPhrase, BulgarianPhrases FROM Phrases " +
                    "WHERE LevelID = (SELECT LevelID FROM Levels WHERE LevelName = @levelID)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlThemeParameter = new SqlParameter("@levelID", SqlDbType.NVarChar);
                sqlThemeParameter.Value = level;
                command.Parameters.Add(sqlThemeParameter);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Phrase phrase = new Phrase();
                        phrase.Id = reader.GetInt32(0);
                        phrase.EnglishPhrase = reader.GetString(1);
                        phrase.BulgarianPhrase = reader.GetString(2);
                        phrases.Add(phrase);
                    }
                }

            }
            catch (SqlException ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetWordByLevel(string currentlevel)
        {
            Words.Clear();
            try
            {
                string sqlCommand = "SELECT WordID, EnglishWord, BulgarianWord FROM Words WHERE LevelID = (SELECT LevelID FROM Levels WHERE LevelName = @Level)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlThemeParameter = new SqlParameter("@Level", SqlDbType.NVarChar);
                sqlThemeParameter.Value = currentlevel;
                command.Parameters.Add(sqlThemeParameter);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Word word = new Word();
                        word.Id = reader.GetInt32(0);
                        word.EnglishWord = reader.GetString(1);
                        word.BulgarianWord = reader.GetString(2);
                        
                        Words.Add(word);
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetWordByTheme(string theme)
        {
            Words.Clear();
            try
            {
                string sqlCommand = "SELECT WordID, EnglishWord, BulgarianWord FROM Words WHERE ThemeID = (SELECT ThemeID FROM Themes WHERE ThemeName = @Theme)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlThemeParameter = new SqlParameter("@Theme", SqlDbType.NVarChar);
                sqlThemeParameter.Value = theme;
                command.Parameters.Add(sqlThemeParameter);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Word word = new Word();
                        word.Id = reader.GetInt32(0);
                        word.EnglishWord = reader.GetString(1);
                        word.BulgarianWord = reader.GetString(2);                        
                        Words.Add(word);
                    }
                }

            }
            catch (SqlException ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertNewWord(string currentEnglishWord, string currentBulgarianWord, int currentLevel, int currentTheme, int currentType)
        {
            try
            {
                string sqlCommand = "INSERT INTO Words(EnglishWord, BulgarianWord, LevelID, ThemeID, TypeID) VALUES (@EnglishWord, @BulgarianWord, @LevelID, @ThemeID, @TypeID)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlEnglishWordParameter = new SqlParameter("@EnglishWord", SqlDbType.NVarChar);
                SqlParameter sqlBulgarianWordParameter = new SqlParameter("@BulgarianWord", SqlDbType.NVarChar);
                SqlParameter sqlParameterLevel = new SqlParameter("@LevelID", SqlDbType.Int);
                SqlParameter sqlParameterTheme = new SqlParameter("@ThemeID", SqlDbType.Int);
                SqlParameter sqlParameterType = new SqlParameter("@TypeID", SqlDbType.Int);

                sqlEnglishWordParameter.Value = currentEnglishWord;
                sqlBulgarianWordParameter.Value = currentBulgarianWord;
                sqlParameterLevel.Value = currentLevel;
                sqlParameterTheme.Value = currentTheme;
                sqlParameterType.Value = currentType;

                command.Parameters.Add(sqlEnglishWordParameter);
                command.Parameters.Add(sqlBulgarianWordParameter);
                command.Parameters.Add(sqlParameterLevel);
                command.Parameters.Add(sqlParameterTheme);
                command.Parameters.Add(sqlParameterType);
                connection.Open();
                MessageBox.Show(command.ExecuteNonQuery().ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertNewPhrase(string currentEnglishPhrase, string currentBulgarianPhrase, int currentLevelId)
        {
            try
            {
                string sqlCommand = "INSERT INTO Phrases(EnglishPhrase, BulgarianPhrases, LevelID) VALUES (@EnglishPhrase, @BulgarianPhrase, @LevelID)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlEnglishPhraseParameter = new SqlParameter("@EnglishPhrase", SqlDbType.NVarChar);
                SqlParameter sqlBulgarianPhraseParameter = new SqlParameter("@BulgarianPhrase", SqlDbType.NVarChar);
                SqlParameter sqlParameterLevel = new SqlParameter("@LevelID", SqlDbType.Int);

                sqlEnglishPhraseParameter.Value = currentEnglishPhrase;
                sqlBulgarianPhraseParameter.Value = currentBulgarianPhrase;
                sqlParameterLevel.Value = currentLevelId;

                command.Parameters.Add(sqlEnglishPhraseParameter);
                command.Parameters.Add(sqlBulgarianPhraseParameter);
                command.Parameters.Add(sqlParameterLevel);
                connection.Open();
                if (command.ExecuteNonQuery() > 1)
                {
                    MessageBox.Show("Phrase inserted!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetWordByType(string level)
        {
            Words.Clear();
            try
            {
                string sqlCommand = "SELECT WordID, EnglishWord, BulgarianWord FROM Words WHERE TypeID = (SELECT TypeID FROM Types WHERE TypeName = @Type)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlThemeParameter = new SqlParameter("@Type", SqlDbType.NVarChar);
                sqlThemeParameter.Value = level;
                command.Parameters.Add(sqlThemeParameter);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Word word = new Word();
                        word.Id = reader.GetInt32(0);
                        word.EnglishWord = reader.GetString(1);
                        word.BulgarianWord = reader.GetString(2);
                        
                        Words.Add(word);
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public SqlConnection Connection { get => connection; set => connection = value; }
        public List<Theme> Themes { get => themes; set => themes = value; }
        public List<Word> Words { get => words; set => words = value; }
        public List<Phrase> Phrases { get => phrases; set => phrases = value; }
        public List<Type> Types { get => types; set => types = value; }
        public List<Level> Levels { get => levels; set => levels = value; }
    }
}