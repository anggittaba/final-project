using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    class PenyewaanView
    {
        public void TampilData(List<Penyewaan> listPenyewaan)
        {
            Console.Clear();
            Console.WriteLine("Data Penyewaan");
            Console.WriteLine("==============");
            foreach (Penyewaan penyewaan in listPenyewaan)
            {
                Console.WriteLine("ID Penyewaan : {0}", penyewaan.ID_Penyewaan);
                Console.WriteLine("Nama Pelanggan : {0}", penyewaan.Pelanggan.Nama_Pelanggan);
                Console.WriteLine("Jenis Kendaraan : {0}", penyewaan.Kendaraan.Jenis_Kendaraan);
                Console.WriteLine("Tanggal Sewa : {0}", penyewaan.Tanggal_Peminjaman);
                Console.WriteLine();
            }
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadLine();
        }

        public Penyewaan TambahData(List<Pelanggan> listPelanggan, List<Kendaraan> listKendaraan)
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penyewaan");
            Console.WriteLine("=====================");
            Penyewaan penyewaan = new Penyewaan();
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
            penyewaan.Pelanggan = pelangganTerpilih;
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
            penyewaan.Kendaraan = kendaraanTerpilih;
            Console.Write("Tanggal Sewa : ");
            penyewaan.Tanggal_Peminjaman = DateTime.Parse(Console.ReadLine());
            Console.Write("Tanggal Kembali : ");
            return penyewaan;
        }

        public int HapusData()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Penyewaan");
            Console.WriteLine("====================");
            Console.Write("ID Penyewaan yang dihapus : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

    }
}