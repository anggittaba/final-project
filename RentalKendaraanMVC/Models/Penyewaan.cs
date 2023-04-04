using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RentalKendaraanMVC.Interfaces;

namespace RentalKendaraanMVC.Models
{
    public class Penyewaan : IPenyewaan
    {
        private string connectionString = "Data Source=.;Initial Catalog=rentalkendaraan;Integrated Security=True";

        public List<Penyewaan> GetAll()
        {
            List<Penyewaan> listPenyewaan = new List<Penyewaan>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM penyewaan";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Penyewaan penyewaan = new Penyewaan()
                    {
                        ID_Penyewaan = Convert.ToInt32(reader["id_penyewaan"]),
                        Tanggal_Peminjaman = Convert.ToDateTime(reader["tanggal_peminjaman"]),
                        Kendaraan = new Kendaraan()
                        {
                            ID_Kendaraan = Convert.ToInt32(reader["id_kendaraan"])
                        },
                        Pelanggan = new Pelanggan()
                        {
                            ID_Pelanggan = Convert.ToInt32(reader["id_pelanggan"])
                        },
                        
                    };
                    listPenyewaan.Add(penyewaan);
                }

                connection.Close();
            }

            return listPenyewaan;
        }

        public Penyewaan GetById(int id)
        {
            Penyewaan penyewaan = new Penyewaan();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM penyewaan WHERE id_penyewaan=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    penyewaan.ID_Penyewaan = Convert.ToInt32(reader["id_penyewaan"]);
                    penyewaan.Tanggal_Peminjaman = Convert.ToDateTime(reader["tanggal_peminjaman"]);
                    penyewaan.Kendaraan = new Kendaraan()
                    {
                        ID_Kendaraan = Convert.ToInt32(reader["id_kendaraan"])
                    };
                    penyewaan.Pelanggan = new Pelanggan()
                    {
                        ID_Pelanggan = Convert.ToInt32(reader["id_pelanggan"])
                    };
                    
                }

                connection.Close();
            }

            return penyewaan;
        }

        public bool Insert(Penyewaan penyewaan)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO penyewaan (id_penyewaan, tanggal_peminjaman, id_kendaraan, id_pelanggan, id_karyawan) " +
                    "VALUES (@id, @tanggal, @id_kendaraan, @id_pelanggan, @id_karyawan)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", penyewaan.ID_Penyewaan);
                command.Parameters.AddWithValue("@tanggal", penyewaan.Tanggal_Peminjaman);
                command.Parameters.AddWithValue("@id_kendaraan", penyewaan.Kendaraan.ID_Kendaraan);
                command.Parameters.AddWithValue("@id_pelanggan", penyewaan.Pelanggan.ID_Pelanggan);


                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }

                connection.Close();
            }

            return result;
        }

        public bool Update(int id, Penyewaan penyewaan)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE penyewaan SET tanggal_peminjaman=@tanggal, id_kendaraan=@id_kendaraan, id_pelanggan=@id_pelanggan, id_karyawan=@id_karyawan " +
                    "WHERE id_penyewaan=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@tanggal", penyewaan.Tanggal_Peminjaman);
                command.Parameters.AddWithValue ("@id_kendaraan", penyewaan.Kendaraan.ID_Kendaraan); 
                command.Parameters.AddWithValue("@id_pelanggan", penyewaan.Pelanggan.ID_Pelanggan);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }

                connection.Close();
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM penyewaan WHERE id_penyewaan=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }

                connection.Close();
            }

            return result;
        }

        public int ID_Penyewaan { get; set; }
        public DateTime Tanggal_Peminjaman { get; set; }
        public Kendaraan Kendaraan { get; set; }
        public Pelanggan Pelanggan { get; set; }

    }
}