using RentalKendaraanMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RentalKendaraanMVC.Repositories
{
    public class ReservasiRepository : IReservasiRepository
    {
        private SqlConnection conn = DBConnection.GetConnection();

        public IEnumerable<Reservasi> GetAll()
        {
            List<Reservasi> reservasis = new List<Reservasi>();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Reservasi " +
                               "JOIN Pelanggan ON Reservasi.ID_Pelanggan = Pelanggan.ID_Pelanggan " +
                               "JOIN Kendaraan ON Reservasi.ID_Kendaraan = Kendaraan.ID_Kendaraan";

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reservasi reservasi = new Reservasi
                    {
                        ID_Reservasi = Convert.ToInt32(reader["ID_Reservasi"]),
                        Tanggal_Reservasi = Convert.ToDateTime(reader["Tanggal_Reservasi"]),
                        Tanggal_Pengembalian = Convert.ToDateTime(reader["Tanggal_Pengembalian"]),
                        Biaya_Reservasi = Convert.ToInt32(reader["Biaya_Reservasi"]),
                        ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                        Pelanggan = new Pelanggan
                        {
                            ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                            Nama_Pelanggan = reader["Nama_Pelanggan"].ToString(),
                            Jenis_Kelamin = reader["Jenis_Kelamin"].ToString(),
                            Alamat_Pelanggan= reader["Alamat"].ToString(),
                            No_Telp_Pelanggan = reader["No_Telp"].ToString(),
                            Email = reader["Email"].ToString()
                        },
                        ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                        Kendaraan = new Kendaraan
                        {
                            ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                            Nama_Kendaraan = reader["Nama_Kendaraan"].ToString(),
                            No_Polisi = reader["No_Polisi"].ToString(),
                            Tipe_Kendaraan = reader["Tipe_Kendaraan"].ToString(),
                            Harga_Sewa_Per_Hari = Convert.ToInt32(reader["Harga_Sewa_Per_Hari"])
                        }
                    };

                    reservasis.Add(reservasi);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return reservasis;
        }

        public Reservasi GetById(int id)
        {
            Reservasi reservasi = null;

            try
            {
                conn.Open();

                string query = "SELECT * FROM Reservasi " +
                               "JOIN Pelanggan ON Reservasi.ID_Pelanggan = Pelanggan.ID_Pelanggan " +
                               "JOIN Kendaraan ON Reservasi.ID_Kendaraan = Kendaraan.ID_Kendaraan " +
                               "WHERE ID_Reservasi = @id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    reservasi = new Reservasi
                    {
                        ID_Reservasi = Convert.ToInt32(reader["ID_Reservasi"]),
                        Tanggal_Reservasi = Convert.ToDateTime(reader["Tanggal_Reservasi"]),
                        Tanggal_Pengembalian = Convert.ToDateTime(reader["Tanggal_Pengembalian"]),
                        Biaya_Reservasi = Convert.ToInt32(reader["Biaya_Reservasi"]),
                        ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                        Pelanggan = new Pelanggan
                        {
                            ID_Pelanggan = Convert.ToInt32(reader["ID_Pelanggan"]),
                            Nama_Pelanggan = reader["Nama_Pelanggan"].ToString(),
                            Jenis_Kelamin = reader["Jenis_Kelamin"].ToString(),
                            Alamat_Pelanggan = reader["Alamat"].ToString(),
                            No_Telp = reader["No_Telp"].ToString(),
                            Email = reader["Email"].ToString()
                        },
                        ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                        Kendaraan = new Kendaraan
                        {
                            ID_Kendaraan = Convert.ToInt32(reader["ID_Kendaraan"]),
                            Nama_Kendaraan = reader["Nama_Kendaraan"].ToString(), 
                            No_Polisi = reader["No_Polisi"].ToString(), 
                            Tipe_Kendaraan = reader["Tipe_Kendaraan"].ToString(), 
                            Harga_Sewa_Per_Hari = Convert.ToInt32(reader["Harga_Sewa_Per_Hari"]) } }; }

            reader.Close();
                }
        catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return reservasi;
        }

        public void Insert(Reservasi reservasi)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO Reservasi (Tanggal_Reservasi, Tanggal_Pengembalian, Biaya_Reservasi, ID_Pelanggan, ID_Kendaraan) " +
                               "VALUES (@tanggalReservasi, @tanggalPengembalian, @biayaReservasi, @idPelanggan, @idKendaraan)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@tanggalReservasi", reservasi.Tanggal_Reservasi);
                command.Parameters.AddWithValue("@tanggalPengembalian", reservasi.Tanggal_Pengembalian);
                command.Parameters.AddWithValue("@biayaReservasi", reservasi.Biaya_Reservasi);
                command.Parameters.AddWithValue("@idPelanggan", reservasi.ID_Pelanggan);
                command.Parameters.AddWithValue("@idKendaraan", reservasi.ID_Kendaraan);
                command.ExecuteNonQuery();

                Console.WriteLine("Data reservasi berhasil ditambahkan");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(int id, Reservasi reservasi)
        {
            try
            {
                conn.Open();

                string query = "UPDATE Reservasi " +
                               "SET Tanggal_Reservasi = @tanggalReservasi, Tanggal_Pengembalian = @tanggalPengembalian, " +
                               "Biaya_Reservasi = @biayaReservasi, ID_Pelanggan = @idPelanggan, ID_Kendaraan = @idKendaraan " +
                               "WHERE ID_Reservasi = @id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@tanggalReservasi", reservasi.Tanggal_Reservasi);
                command.Parameters.AddWithValue("@tanggalPengembalian", reservasi.Tanggal_Pengembalian);
                command.Parameters.AddWithValue("@biayaReservasi", reservasi.Biaya_Reservasi);
                command.Parameters.AddWithValue("@idPelanggan", reservasi.ID_Pelanggan);
                command.Parameters.AddWithValue("@idKendaraan", reservasi.ID_Kendaraan);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                Console.WriteLine("Data reservasi berhasil diupdate");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                conn.Open();

                string query = "DELETE FROM Reservasi WHERE ID_Reservasi = @id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                Console.WriteLine("Data reservasi berhasil dihapus");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

