using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    class ReservasiView
    {
        public void TampilData(List<Reservasi> listReservasi)
        {
            Console.Clear();
            Console.WriteLine("Data Reservasi");
            Console.WriteLine("==============");
            foreach (Reservasi reservasi in listReservasi)
            {
                Console.WriteLine("ID Reservasi : {0}", reservasi.ID_Reservasi);
                Console.WriteLine("Nama Pelanggan : {0}", reservasi.Pelanggan.Nama_Pelanggan);
                Console.WriteLine("Jenis Kendaraan : {0}", reservasi.Kendaraan.Jenis_Kendaraan);
                Console.WriteLine("Tanggal Reservasi : {0}", reservasi.Tgl_Reservasi);
                Console.WriteLine();
            }
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadLine();
        }

        public Reservasi TambahData(List<Pelanggan> listPelanggan, List<Kendaraan> listKendaraan)
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Reservasi");
            Console.WriteLine("=====================");
            Reservasi reservasi = new Reservasi();
            Console.Write("Pilih Pelanggan : ");
            int indexPelanggan = 1;
            foreach (Pelanggan pelanggan in listPelanggan)
            {
                Console.WriteLine("{0}. {1}", indexPelanggan, pelanggan.Nama_Pelanggan);
                indexPelanggan++;
            }
            Console.Write("Nomor Pelanggan : ");
            int nomorPelanggan = int.Parse(Console.ReadLine());
            Pelanggan pelangganTerpilih = listPelanggan[nomorPelanggan - 1];
            reservasi.Pelanggan = pelangganTerpilih;
            Console.Write("Pilih Kendaraan : ");
            int indexKendaraan = 1;
            foreach (Kendaraan kendaraan in listKendaraan)
            {
                Console.WriteLine("{0}. {1}", indexKendaraan, kendaraan.Jenis_Kendaraan);
                indexKendaraan++;
            }
            Console.Write("Nomor Kendaraan : ");
            int nomorKendaraan = int.Parse(Console.ReadLine());
            Kendaraan kendaraanTerpilih = listKendaraan[nomorKendaraan - 1];
            reservasi.Kendaraan = kendaraanTerpilih;
            Console.Write("Tanggal Reservasi : ");
            reservasi.Tgl_Reservasi = DateTime.Parse(Console.ReadLine());
            return reservasi;
        }

        public int HapusData()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Reservasi");
            Console.WriteLine("====================");
            Console.Write("ID Reservasi yang dihapus : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public Reservasi UbahData(List<Pelanggan> listPelanggan, List<Kendaraan> listKendaraan)
        {
            Console.Clear();
            Console.WriteLine("Ubah Data Reservasi");
            Console.WriteLine("===================");
            Reservasi reservasi = new Reservasi();
            Console.Write("ID Reservasi yang diubah : ");
            reservasi.ID_Reservasi = int.Parse(Console.ReadLine());
            Console.Write("Pilih Pelanggan : ");
            int indexPelanggan = 1;
            foreach (Pelanggan pelanggan in listPelanggan)
            {
                Console.WriteLine("{0}. {1}", indexPelanggan, pelanggan.Nama_Pelanggan);
                indexPelanggan++;
            }
            Console.Write("Nomor Pelanggan : ");
            int nomorPelanggan = int.Parse(Console.ReadLine());
            Pelanggan pelangganTerpilih = listPelanggan[nomorPelanggan - 1];
            reservasi.Pelanggan = pelangganTerpilih;
            Console.Write("Pilih Kendaraan : ");
            int indexKendaraan = 1;
            foreach (Kendaraan kendaraan in listKendaraan)
            {
                Console.WriteLine("{0}. {1}", indexKendaraan, kendaraan.Jenis_Kendaraan);
                indexKendaraan++;
            }
            Console.Write("Nomor Kendaraan : ");
            int nomorKendaraan = int.Parse(Console.ReadLine());
            Kendaraan kendaraanTerpilih = listKendaraan[nomorKendaraan - 1];
            reservasi.Kendaraan = kendaraanTerpilih;
            Console.Write("Tanggal Reservasi : ");
            reservasi.Tgl_Reservasi = DateTime.Parse(Console.ReadLine());
            return reservasi;
        }
    }
}