using System.Collections.Generic;
using System.Data.SqlClient;
using RentalKendaraanMVC.Interfaces;

namespace RentalKendaraanMVC.Models
{
    public class Kendaraan 
    {
        public int ID_Kendaraan { get; set; }
        public string Jenis_Kendaraan { get; set; }
        public string Merk_Kendaraan { get; set; }
        public int Tahun_Produksi { get; set; }

        private string connectionString = "Data Source=DESKTOP-T8JR52S;Database=db_RentalKendaraan;Integrated Security=True;Connect Timeout=30;";

        public List<Kendaraan> GetAll()
        {
            List<Kendaraan> listKendaraan = new List<Kendaraan>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Kendaraan", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Kendaraan kendaraan = new Kendaraan()
                    {
                        ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                        Jenis_Kendaraan = reader["Jenis_Kendaraan"].ToString(),
                        Merk_Kendaraan = reader["Merk_Kendaraan"].ToString(),
                        Tahun_Produksi = Convert.ToInt32(reader["Tahun_Produksi"])
                    };
                    listKendaraan.Add(kendaraan);
                }
            }

            return listKendaraan;
        }

        public Kendaraan GetById(int id)
        {
            Kendaraan kendaraan = new Kendaraan();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Kendaraan WHERE ID_Kendaraan = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kendaraan.ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]);
                    kendaraan.Jenis_Kendaraan = reader["Jenis_Kendaraan"].ToString();
                    kendaraan.Merk_Kendaraan = reader["Merk_Kendaraan"].ToString();
                    kendaraan.Tahun_Produksi = Convert.ToInt32(reader["Tahun_Produksi"]);
                }
            }

            return kendaraan;
        }

        public void TambahData(Kendaraan kendaraan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Kendaraan (Jenis_Kendaraan, Merk_Kendaraan, Tahun_Produksi) VALUES (@jenis, @merk, @tahun)", connection);
                command.Parameters.AddWithValue("@jenis", kendaraan.Jenis_Kendaraan);
                command.Parameters.AddWithValue("@merk", kendaraan.Merk_Kendaraan);
                command.Parameters.AddWithValue("@tahun", kendaraan.Tahun_Produksi);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UbahData(Kendaraan kendaraan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE Kendaraan SET Jenis_Kendaraan = @jenis, Merk_Kendaraan = @merk, Tahun_Produksi = @tahun WHERE ID_Kendaraan = @id", connection);
                command.Parameters.AddWithValue("@id", kendaraan.ID_Kendaraan);
                command.Parameters.AddWithValue("@jenis", kendaraan.Jenis_Kendaraan);
                command.Parameters.AddWithValue("@merk", kendaraan.Merk_Kendaraan);
                command.Parameters.AddWithValue("@tahun", kendaraan.Tahun_Produksi);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void HapusData(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Kendaraan WHERE ID_Kendaraan = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}