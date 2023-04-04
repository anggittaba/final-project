using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    class KendaraanView
    {
        public void TampilData(List<Kendaraan> listKendaraan)
        {
            Console.Clear();
            Console.WriteLine("Data Kendaraan");
            Console.WriteLine("=============");
            foreach (Kendaraan kendaraan in listKendaraan)
            {
                Console.WriteLine("ID Kendaraan : {0}", kendaraan.ID_Kendaraan);
                Console.WriteLine("Jenis Kendaraan : {0}", kendaraan.Jenis_Kendaraan);
                Console.WriteLine("Merk Kendaraan : {0}", kendaraan.Merk_Kendaraan);
                Console.WriteLine("Tahun Produksi : {0}", kendaraan.Tahun_Produksi);
                Console.WriteLine();
            }
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadLine();
        }

        public Kendaraan TambahData()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Kendaraan");
            Console.WriteLine("=====================");
            Kendaraan kendaraan = new Kendaraan();
            Console.Write("Jenis Kendaraan : ");
            kendaraan.Jenis_Kendaraan = Console.ReadLine();
            Console.Write("Merk Kendaraan : ");
            kendaraan.Merk_Kendaraan = Console.ReadLine();
            Console.Write("Tahun Produksi : ");
            kendaraan.Tahun_Produksi = int.Parse(Console.ReadLine());
            return kendaraan;
        }

        public int HapusData()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Kendaraan");
            Console.WriteLine("====================");
            Console.Write("ID Kendaraan yang dihapus : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public Kendaraan UbahData()
        {
            Console.Clear();
            Console.WriteLine("Ubah Data Kendaraan");
            Console.WriteLine("===================");
            Kendaraan kendaraan = new Kendaraan();
            Console.Write("ID Kendaraan yang diubah : ");
            kendaraan.ID_Kendaraan = int.Parse(Console.ReadLine());
            Console.Write("Jenis Kendaraan : ");
            kendaraan.Jenis_Kendaraan = Console.ReadLine();
            Console.Write("Merk Kendaraan : ");
            kendaraan.Merk_Kendaraan = Console.ReadLine();
            Console.Write("Tahun Produksi : ");
            kendaraan.Tahun_Produksi = int.Parse(Console.ReadLine());
            return kendaraan;
        }
    }
}