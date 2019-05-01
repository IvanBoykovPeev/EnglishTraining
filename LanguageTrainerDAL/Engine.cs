using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace LanguageTrainerDAL
{
    public class engine
    {
        private static string directory = Path.GetDirectoryName(Application.ExecutablePath) + "\\DatabaseWordBank.mdf";
        private static string currentDirectory = @"D:\EnglishTraining.git\trunk\LanguageTrainer\DatabaseWordBank.mdf";
        private string connectionString = @"server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + currentDirectory + ";Integrated Security = True";       

        //@"server=.;" +
        //"integrated security=true;database=WordBank";
        private SqlConnection connection;
        private List<Level> levels = new List<Level>();
        private List<SubLevel> subLevels = new List<SubLevel>();
        private List<Theme> themes = new List<Theme>();
        private List<Type> types = new List<Type>();
        private List<Word> words = new List<Word>();
        private List<Phrase> phrases = new List<Phrase>();

        public engine()
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

        public void GetSubLevels(string level)
        {
            SubLevels.Clear();
            try
            {
                string sqlCommand = "SELECT s.SubLevelID, s.SubLevel " +
                                    "FROM LevelSubLevel as ls " +
                                    "JOIN Levels as l " +
                                    "ON ls.LevelID = l.LevelID " +
                                    "JOIN SubLevels as s " +
                                    "ON s.SubLevelID = ls.SubLevelID " +
                                    "WHERE l.LevelName = @LevelName";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlSubLevelParameter = new SqlParameter("@LevelName", SqlDbType.NVarChar);
                sqlSubLevelParameter.Value = level;
                command.Parameters.Add(sqlSubLevelParameter);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        SubLevel subLevel = new SubLevel();
                        subLevel.SubLevelId = reader.GetInt32(0);
                        subLevel.SubLevelInt = reader.GetInt32(1);
                        SubLevels.Add(subLevel);
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
                string sqlCommand = "" +
                    "SELECT w.WordID, w.EnglishWord, w.BulgarianWord, t.TypeName " +
                    "FROM Words AS w " +
                    "JOIN Levels AS l " +
                    "ON l.LevelID = w.LevelID " +
                    "JOIN Types AS t " +
                    "ON t.TypeID = w.TypeID " +
                    "WHERE l.LevelName = @Level";
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
                        word.WordType = reader.GetString(3);
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

        public void GetWordByTheme(string theme)
        {
            Words.Clear();
            try
            {
                string sqlCommand = "SELECT w.WordID, w.EnglishWord, w.BulgarianWord, ty.TypeName " +
                    "FROM Words AS w " +
                    "JOIN Themes AS t " +
                    "ON t.ThemeID = w.ThemeID " +
                    "JOIN Types AS ty " +
                    "ON ty.TypeID = w.TypeID " +
                    "WHERE t.ThemeName = @Theme ";
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
                        word.WordType = reader.GetString(3);
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

        public void InsertNewWord(string currentEnglishWord, string currentBulgarianWord, int currentLevel, int currentTheme, int currentType, int currentSubLevel)
        {
            try
            {
                string sqlCommand = "INSERT INTO Words(EnglishWord, BulgarianWord, LevelID, ThemeID, TypeID, SubLevelID) VALUES (@EnglishWord, @BulgarianWord, @LevelID, @ThemeID, @TypeID, @SubLevelID)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlEnglishWordParameter = new SqlParameter("@EnglishWord", SqlDbType.NVarChar);
                SqlParameter sqlBulgarianWordParameter = new SqlParameter("@BulgarianWord", SqlDbType.NVarChar);
                SqlParameter sqlParameterLevel = new SqlParameter("@LevelID", SqlDbType.Int);
                SqlParameter sqlParameterSubLevel = new SqlParameter("@SubLevelID", SqlDbType.Int);
                SqlParameter sqlParameterTheme = new SqlParameter("@ThemeID", SqlDbType.Int);
                SqlParameter sqlParameterType = new SqlParameter("@TypeID", SqlDbType.Int);

                sqlEnglishWordParameter.Value = currentEnglishWord;
                sqlBulgarianWordParameter.Value = currentBulgarianWord;
                sqlParameterLevel.Value = currentLevel;
                sqlParameterTheme.Value = currentTheme;
                sqlParameterType.Value = currentType;
                sqlParameterSubLevel.Value = currentSubLevel;

                command.Parameters.Add(sqlEnglishWordParameter);
                command.Parameters.Add(sqlBulgarianWordParameter);
                command.Parameters.Add(sqlParameterLevel);
                command.Parameters.Add(sqlParameterTheme);
                command.Parameters.Add(sqlParameterType);
                command.Parameters.Add(sqlParameterSubLevel);
                connection.Open();
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Word inserted!");
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

        public void GetWordsBySubLevels(string selectedItemLevel, int selectedItemSubLevel)
        {
            int tempSubLevel = selectedItemSubLevel;
            Words.Clear();
            try
            {
                string sqlCommand = "" +
                    "SELECT w.WordID, w.EnglishWord, w.BulgarianWord, t.TypeName " +
                    "FROM Words AS w " +
                    "JOIN Levels AS l " +
                    "ON l.LevelID = w.LevelID " +
                    "JOIN Types AS t " +
                    "ON t.TypeID = w.TypeID " +
                    "WHERE l.LevelName = @Level AND SubLevelID = @SubLevel";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlThemeParameter = new SqlParameter("@Level", SqlDbType.NVarChar);
                sqlThemeParameter.Value = selectedItemLevel;
                command.Parameters.Add(sqlThemeParameter);
                SqlParameter sqlSubLevelParameter = new SqlParameter("@SubLevel", SqlDbType.Int);
                sqlSubLevelParameter.Value = tempSubLevel;
                command.Parameters.Add(sqlSubLevelParameter);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Word word = new Word();
                        word.Id = reader.GetInt32(0);
                        word.EnglishWord = reader.GetString(1);
                        word.BulgarianWord = reader.GetString(2);
                        word.WordType = reader.GetString(3);
                        Words.Add(word);
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
                if (command.ExecuteNonQuery() >= 1)
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

        public void InsertNewTheme(string currentEnglishTheme)
        {
            try
            {
                string sqlCommand = "INSERT INTO Themes(ThemeName) VALUES (@ThemeName)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlParameter sqlThemeParameter = new SqlParameter("@ThemeName", SqlDbType.NVarChar);
                sqlThemeParameter.Value = currentEnglishTheme;
                command.Parameters.Add(sqlThemeParameter);
                connection.Open();
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Theme inserted!");
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
                string sqlCommand = "SELECT WordID, EnglishWord, BulgarianWord, t.TypeName " +
                    "FROM Words AS w " +
                    "JOIN Types AS t " + 
                    "ON t.TypeID = w.TypeID " + 
                    "WHERE t.TypeName = @Type";
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
                        word.WordType = reader.GetString(3);
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
        public string CurrentDirectory { get => currentDirectory; set => currentDirectory = value; }
        public List<SubLevel> SubLevels { get => subLevels; set => subLevels = value; }
    }
}