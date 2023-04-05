using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalKendaraanMVC.Repositories
{
    public class PelangganRepository : IPelangganRepository
    {
        private SqlConnection connection;

        public PelangganRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Create(Pelanggan pelanggan)
        {
            string query = "INSERT INTO Pelanggan (Nama_Pelanggan, Alamat_Pelanggan, No_Telp_Pelanggan) VALUES (@Nama_Pelanggan, @Alamat_Pelanggan, @No_Telp_Pelanggan)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nama_Pelanggan", pelanggan.Nama_Pelanggan);
            command.Parameters.AddWithValue("@Alamat_Pelanggan", pelanggan.Alamat_Pelanggan);
            command.Parameters.AddWithValue("@No_Telp_Pelanggan", pelanggan.No_Telp_Pelanggan);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Pelanggan pelanggan)
        {
            string query = "UPDATE Pelanggan SET Nama_Pelanggan = @Nama_Pelanggan, Alamat_Pelanggan = @Alamat_Pelanggan, No_Telp_Pelanggan = @No_Telp_Pelanggan WHERE ID_Pelanggan = @ID_Pelanggan";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Pelanggan", pelanggan.ID_Pelanggan);
            command.Parameters.AddWithValue("@Nama_Pelanggan", pelanggan.Nama_Pelanggan);
            command.Parameters.AddWithValue("@Alamat_Pelanggan", pelanggan.Alamat_Pelanggan);
            command.Parameters.AddWithValue("@No_Telp_Pelanggan", pelanggan.No_Telp_Pelanggan);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Pelanggan WHERE ID_Pelanggan = @ID_Pelanggan";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Pelanggan", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Pelanggan> GetAll()
        {
            List<Pelanggan> pelangganList = new List<Pelanggan>();

            string query = "SELECT * FROM Pelanggan";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Pelanggan pelanggan = new Pelanggan
                {
                    ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                    Nama_Pelanggan = reader["Nama_Pelanggan"].ToString(),
                    Alamat_Pelanggan = reader["Alamat_Pelanggan"].ToString(),
                    No_Telp_Pelanggan = reader["No_Telp_Pelanggan"].ToString()
                };

                pelangganList.Add(pelanggan);
            }

            reader.Close();
            connection.Close();

            return pelangganList;
        }

        public Pelanggan GetById(int id)
        {
            Pelanggan pelanggan = null;

            string query = "SELECT * FROM Pelanggan WHERE ID_Pelanggan = @ID_Pelanggan";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Pelanggan", id);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                pelanggan = new Pelanggan
                {
                    ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                    Nama_Pelanggan = reader["Nama_Pelanggan"].ToString(),
                    Alamat_Pelanggan = reader["Alamat_Pelanggan"].ToString(),
                    No_Telp_Pelanggan = reader["No_Telp_Pelanggan"].ToString()
                };
            }

            reader.Close();
            connection.Close();

            return pelanggan;
        }
    }
}