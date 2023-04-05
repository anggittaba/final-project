using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalKendaraanMVC.Controllers
{
    public class ReservasiController
    {
        private ReservasiRepository reservasiRepository = new ReservasiRepository(DBConnection.GetConnection());

        private PelangganRepository pelangganRepository = new PelangganRepository(DBConnection.GetConnection());

        private KendaraanRepository kendaraanRepository = new KendaraanRepository(DBConnection.GetConnection());

        public void Index()
        {
            List<Reservasi> reservasiList = reservasiRepository.GetAll();

            foreach (Reservasi reservasi in reservasiList)
            {
                reservasi.Pelanggan = pelangganRepository.GetById(reservasi.ID_Pelanggan);
                reservasi.Kendaraan = kendaraanRepository.GetById(reservasi.);

                Console.WriteLine("ID Reservasi: {0}", reservasi.ID_Reservasi);
                Console.WriteLine("Nama Pelanggan: {0}", reservasi.Pelanggan.Nama_Pelanggan);
                Console.WriteLine("Jenis Kendaraan: {0}", reservasi.Kendaraan.Jenis_Kendaraan);
                Console.WriteLine("Tanggal Reservasi: {0}", reservasi.Tgl_Reservasi);
                Console.WriteLine("Tanggal Pengembalian: {0}", reservasi.Tgl_Pengembalian);
                Console.WriteLine("Biaya: {0}", reservasi.Biaya);
                Console.WriteLine();
            }
        }

        public void Details(int id)
        {
            Reservasi reservasi = reservasiRepository.GetById(id);

            if (reservasi == null)
            {
                Console.WriteLine("Reservasi dengan ID {0} tidak ditemukan", id);
            }
            else
            {
                reservasi.Pelanggan = pelangganRepository.GetById(reservasi.ID_Pelanggan);
                reservasi.Kendaraan = kendaraanRepository.GetById(reservasi.ID_Kendaraan);

                Console.WriteLine("ID Reservasi: {0}", reservasi.ID_Reservasi);
                Console.WriteLine("Nama Pelanggan: {0}", reservasi.Pelanggan.Nama_Pelanggan);
                Console.WriteLine("Jenis Kendaraan: {0}", reservasi.Kendaraan.Jenis_Kendaraan);
                Console.WriteLine("Tanggal Reservasi: {0}", reservasi.Tgl_Reservasi);
                Console.WriteLine("Tanggal Pengembalian: {0}", reservasi.Tgl_Pengembalian);
                Console.WriteLine("Biaya: {0}", reservasi.Biaya);
            }
        }

        public void Create(Reservasi reservasi)
        {
            try
            {
                reservasiRepository.Create(reservasi);

                Console.WriteLine("Reservasi berhasil ditambahkan");
            }
            catch
            {
                Console.WriteLine("Reservasi gagal ditambahkan");
            }
        }

        public void Edit(int id, Reservasi reservasi)
        {
            try
            {
                reservasi.ID_Reservasi = id;
                reservasiRepository.Update(reservasi);

                Console.WriteLine("Reservasi berhasil diupdate");
            }
            catch
            {
                Console.WriteLine("Reservasi gagal diupdate");
            }
        }

        public void Delete(int id)
        {
            Reservasi reservasi = reservasiRepository.GetById(id);

            if (reservasi == null)
            {
                Console.WriteLine("Reservasi dengan ID {0} tidak ditemukan", id);
            }
            else
            {
                try
                {
                    reservasiRepository.Delete(id);

                    Console.WriteLine("Reservasi berhasil dihapus");
                }
                catch
                {
                    Console.WriteLine("Reservasi gagal dihapus");
                }
            }
        }
    }
}