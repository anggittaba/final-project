using System.Data.SqlClient;

namespace RentalKendaraanMVC
{
    class DBConnection
    {
        private static SqlConnection conn;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection("Data Source=DESKTOP-T8JR52S;Database=db_RentalKendaraan;Integrated Security=True;Connect Timeout=30;");
            }

            return conn;
        }
    }
}