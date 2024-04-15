using System.Data.SQLite;

namespace VesselsApp
{
    public class Repository
    {
        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection connection;
            connection = new SQLiteConnection("Data Source=C:\\Users\\maria.genua\\Dev\\Test\\Database\\msc.db");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
               
            }
            return connection;
        }

        
    }
}
