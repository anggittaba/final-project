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
    public class KendaraanRepository : IKendaraanRepository
    {
        private SqlConnection connection;

        public KendaraanRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Create(Kendaraan kendaraan)
        {
            string query = "INSERT INTO Kendaraan (Jenis_Kendaraan, Merk_Kendaraan, Tahun_Produksi) VALUES (@Jenis_Kendaraan, @Merk_Kendaraan, @Tahun_Produksi)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Jenis_Kendaraan", kendaraan.Jenis_Kendaraan);
            command.Parameters.AddWithValue("@Merk_Kendaraan", kendaraan.Merk_Kendaraan);
            command.Parameters.AddWithValue("@Tahun_Produksi", kendaraan.Tahun_Produksi);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Kendaraan kendaraan)
        {
            string query = "UPDATE Kendaraan SET Jenis_Kendaraan = @Jenis_Kendaraan, Merk_Kendaraan = @Merk_Kendaraan, Tahun_Produksi = @Tahun_Produksi WHERE ID_Kendaraan = @ID_Kendaraan";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Kendaraan", kendaraan.ID_Kendaraan);
            command.Parameters.AddWithValue("@Jenis_Kendaraan", kendaraan.Jenis_Kendaraan);
            command.Parameters.AddWithValue("@Merk_Kendaraan", kendaraan.Merk_Kendaraan);
            command.Parameters.AddWithValue("@Tahun_Produksi", kendaraan.Tahun_Produksi);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Kendaraan WHERE ID_Kendaraan = @ID_Kendaraan";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Kendaraan", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Kendaraan> GetAll()
        {
            List<Kendaraan> kendaraanList = new List<Kendaraan>();

            string query = "SELECT * FROM Kendaraan";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kendaraan kendaraan = new Kendaraan
                {
                    ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                    Jenis_Kendaraan = reader["Jenis_Kendaraan"].ToString(),
                    Merk_Kendaraan = reader["Merk_Kendaraan"].ToString(),
                    Tahun_Produksi = Convert.ToInt32(reader["Tahun_Produksi"])
                };

                kendaraanList.Add(kendaraan);
            }

            reader.Close();
            connection.Close();

            return kendaraanList;
        }

        public Kendaraan GetById(int id)
        {
            Kendaraan kendaraan = null;

            string query = "SELECT * FROM Kendaraan WHERE ID_Kendaraan = @ID_Kendaraan";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Kendaraan", id);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                kendaraan = new Kendaraan
                {
                    ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                    Jenis_Kendaraan = reader["Jenis_Kendaraan"].ToString(),
                    Merk_Kendaraan = reader["Merk_Kendaraan"].ToString(),
                    Tahun_Produksi = Convert.ToInt32(reader["Tahun_Produksi"])
                };
            }

            reader.Close();
            connection.Close();

            return kendaraan;
        }
    }
}
