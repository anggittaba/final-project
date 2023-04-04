using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RentalKendaraanMVC.Interfaces;

namespace RentalKendaraanMVC.Models
{
    public class Pengembalian
    {
        public int ID_Pengembalian { get; set; }
        public DateTime Tanggal_Pengembalian { get; set; }
        public Kendaraan Kendaraan { get; set; }
        public Pelanggan Pelanggan { get; set; }
        public object Penyewaan { get; internal set; }

        public List<Pengembalian> GetAll()
        {
            List<Pengembalian> listPengembalian = new List<Pengembalian>();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Pengembalian", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pengembalian pengembalian = new Pengembalian()
                    {
                        ID_Pengembalian = Convert.ToInt32(reader["ID_Pengembalian"]),
                        Tanggal_Pengembalian = Convert.ToDateTime(reader["Tanggal_Pengembalian"]),
                        Kendaraan = new Kendaraan()
                        {
                            ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"])
                        },
                        Pelanggan = new Pelanggan()
                        {
                            ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"])
                        }
                    };
                    listPengembalian.Add(pengembalian);
                }
            }

            return listPengembalian;
        }

        public Pengembalian GetById(int id)
        {
            Pengembalian pengembalian = new Pengembalian();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Pengembalian WHERE ID_Pengembalian = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pengembalian.ID_Pengembalian = Convert.ToInt32(reader["ID_Pengembalian"]);
                    pengembalian.Tanggal_Pengembalian = Convert.ToDateTime(reader["Tanggal_Pengembalian"]);
                    pengembalian.Kendaraan = new Kendaraan()
                    {
                        ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"])
                    };
                    pengembalian.Pelanggan = new Pelanggan()
                    {
                        ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"])
                    };
                }
            }

            return pengembalian;
        }

        public void TambahData(Pengembalian pengembalian)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Pengembalian (Tanggal_Pengembalian, ID_Kendaraan, ID_Pelanggan) VALUES (@tanggal, @kendaraan, @pelanggan)", connection);
                command.Parameters.AddWithValue("@tanggal", pengembalian.Tanggal_Pengembalian);
                command.Parameters.AddWithValue("@kendaraan", pengembalian.Kendaraan.ID_Kendaraan);
                command.Parameters.AddWithValue("@pelanggan", pengembalian.Pelanggan.ID_Pelanggan);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UbahData(Pengembalian pengembalian)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE Pengembalian SET Tanggal_Pengembalian = @tanggal, ID_Kendaraan = @kendaraan, ID_Pelanggan = @pelanggan WHERE ID_Pengembalian = @id", connection);
                command.Parameters.AddWithValue("@id", pengembalian.ID_Pengembalian);
                command.Parameters.AddWithValue("@tanggal", pengembalian.Tanggal_Pengembalian);
                command.Parameters.AddWithValue("@kendaraan", pengembalian.Kendaraan.ID_Kendaraan);
                command.Parameters.AddWithValue("@pelanggan", pengembalian.Pelanggan.ID_Pelanggan);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void HapusData(int id)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM Pengembalian WHERE ID_Pengembalian = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}