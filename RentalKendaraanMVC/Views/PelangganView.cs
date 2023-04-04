using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    class PelangganView
    {
        public void TampilData(List<Pelanggan> listPelanggan)
        {
            Console.Clear();
            Console.WriteLine("Data Pelanggan");
            Console.WriteLine("==============");
            foreach (Pelanggan pelanggan in listPelanggan)
            {
                Console.WriteLine("ID Pelanggan : {0}", pelanggan.ID_Pelanggan);
                Console.WriteLine("Nama Pelanggan : {0}", pelanggan.Nama_Pelanggan);
                Console.WriteLine("Alamat Pelanggan : {0}", pelanggan.Alamat);
                Console.WriteLine("No. Telp : {0}", pelanggan.No_Telp);
                Console.WriteLine();
            }
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadLine();
        }

        public Pelanggan TambahData()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Pelanggan");
            Console.WriteLine("=====================");
            Pelanggan pelanggan = new Pelanggan();
            Console.Write("Nama Pelanggan : ");
            pelanggan.Nama_Pelanggan = Console.ReadLine();
            Console.Write("Alamat Pelanggan : ");
            pelanggan.Alamat = Console.ReadLine();
            Console.Write("No. Telp : ");
            pelanggan.No_Telp = Console.ReadLine();
            return pelanggan;
        }

        public int HapusData()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Pelanggan");
            Console.WriteLine("====================");
            Console.Write("ID Pelanggan yang dihapus : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public Pelanggan UbahData()
        {
            Console.Clear();
            Console.WriteLine("Ubah Data Pelanggan");
            Console.WriteLine("===================");
            Pelanggan pelanggan = new Pelanggan();
            Console.Write("ID Pelanggan yang diubah : ");
            pelanggan.ID_Pelanggan = int.Parse(Console.ReadLine());
            Console.Write("Nama Pelanggan : ");
            pelanggan.Nama_Pelanggan = Console.ReadLine();
            Console.Write("Alamat Pelanggan : ");
            pelanggan.Alamat = Console.ReadLine();
            Console.Write("No. Telp : ");
            pelanggan.No_Telp = Console.ReadLine();
            return pelanggan;
        }
    }
}