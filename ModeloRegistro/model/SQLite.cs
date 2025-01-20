using System;
using System.Data.SQLite;

namespace ModeloRegistro.model
{
    public class SQLite
    {
        private SQLiteConnection connection;

        public SQLite(string uri_connection)
        {
            CreateConnection(uri_connection);
        }

        private void CreateConnection(string uri)
        {
            connection = new SQLiteConnection("Data Source = " + uri + "; Version = 3; New = True; Compress = True;");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
            }
        }

        public SQLiteConnection getConnection()
        {
            return connection;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
