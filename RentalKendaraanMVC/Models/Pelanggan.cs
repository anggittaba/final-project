using System.Data.SqlClient;

namespace RentalKendaraanMVC.Models
{
    public class Pelanggan
    {
        public int ID_Pelanggan { get; set; }
        public string Nama_Pelanggan { get; set; }
        public string Alamat { get; set; }
        public string No_Telp { get; set; }

        public List<Pelanggan> GetAll()
        {
            List<Pelanggan> listPelanggan = new List<Pelanggan>();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Pelanggan", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pelanggan pelanggan = new Pelanggan()
                    {
                        ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                        Nama_Pelanggan = reader["Nama_Pelanggan"].ToString(),
                        Alamat = reader["Alamat"].ToString(),
                        No_Telp = reader["No_Telp"].ToString()
                    };
                    listPelanggan.Add(pelanggan);
                }
            }

            return listPelanggan;
        }

        public Pelanggan GetById(int id)
        {
            Pelanggan pelanggan = new Pelanggan();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Pelanggan WHERE ID_Pelanggan = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pelanggan.ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]);
                    pelanggan.Nama_Pelanggan = reader["Nama_Pelanggan"].ToString();
                    pelanggan.Alamat = reader["Alamat"].ToString();
                    pelanggan.No_Telp = reader["No_Telp"].ToString();
                }
            }

            return pelanggan;
        }

        public void TambahData(Pelanggan pelanggan)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Pelanggan (Nama_Pelanggan, Alamat, No_Telp) VALUES (@nama, @alamat, @no_telp)", connection);
                command.Parameters.AddWithValue("@nama", pelanggan.Nama_Pelanggan);
                command.Parameters.AddWithValue("@alamat", pelanggan.Alamat);
                command.Parameters.AddWithValue("@no_telp", pelanggan.No_Telp);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UbahData(Pelanggan pelanggan)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE Pelanggan SET Nama_Pelanggan = @nama, Alamat = @alamat, No_Telp = @no_telp WHERE ID_Pelanggan = @id", connection);
                command.Parameters.AddWithValue("@id", pelanggan.ID_Pelanggan);
                command.Parameters.AddWithValue("@nama", pelanggan.Nama_Pelanggan);
                command.Parameters.AddWithValue("@alamat", pelanggan.Alamat);
                command.Parameters.AddWithValue("@no_telp", pelanggan.No_Telp);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void HapusData(int id)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM Pelanggan WHERE ID_Pelanggan = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
 