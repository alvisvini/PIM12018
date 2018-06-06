using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MiniPack
{
    public static class Banco
    {
        public static MySqlConnection connection =
            new MySqlConnection("server=127.0.0.1;uid=root;database=pim1;");

        public static bool Open()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
