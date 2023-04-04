using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    class PengembalianView
    {
        public void TampilData(List<Pengembalian> listPengembalian)
        {
            Console.Clear();
            Console.WriteLine("Data Pengembalian");
            Console.WriteLine("=================");
            foreach (Pengembalian pengembalian in listPengembalian)
            {
                Console.WriteLine("ID Pengembalian : {0}", pengembalian.ID_Pengembalian);
                Console.WriteLine("Nama Pelanggan : {0}", pengembalian.Penyewaan.Pelanggan.Nama_Pelanggan);
                Console.WriteLine("Jenis Kendaraan : {0}", pengembalian.Penyewaan.Kendaraan.Jenis_Kendaraan);
                Console.WriteLine("Tanggal Kembali : {0}", pengembalian.Tgl_Kembali);
                Console.WriteLine("Total Biaya : {0}", pengembalian.Total_Biaya);
                Console.WriteLine();
            }
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadLine();
        }

        public Pengembalian TambahData(List<Penyewaan> listPenyewaan)
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Pengembalian");
            Console.WriteLine("========================");
            Pengembalian pengembalian = new Pengembalian();
            Console.Write("Pilih Penyewaan : ");
            int indexPenyewaan = 1;
            foreach (Penyewaan penyewaan in listPenyewaan)
            {
                Console.WriteLine("{0}. {1}", indexPenyewaan, penyewaan.Pelanggan.Nama_Pelanggan);
                indexPenyewaan++;
            }
            Console.Write("Nomor Penyewaan : ");
            int nomorPenyewaan = int.Parse(Console.ReadLine());
            Penyewaan penyewaanTerpilih = listPenyewaan[nomorPenyewaan - 1];
            pengembalian.Penyewaan = penyewaanTerpilih;
            Console.Write("Tanggal Kembali : ");
            pengembalian.Tgl_Kembali = DateTime.Parse(Console.ReadLine());
            Console.Write("Total Biaya : ");
            pengembalian.Total_Biaya = int.Parse(Console.ReadLine());
            return pengembalian;
        }

        public int HapusData()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Pengembalian");
            Console.WriteLine("=======================");
            Console.Write("ID Pengembalian yang dihapus : ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public Pengembalian UbahData(List<Penyewaan> listPenyewaan)
        {
            Console.Clear();
            Console.WriteLine("Ubah Data Pengembalian");
            Console.WriteLine("======================");
            Pengembalian pengembalian = new Pengembalian();
            Console.Write("ID Pengembalian yang diubah : ");
            pengembalian.ID_Pengembalian = int.Parse(Console.ReadLine());
            Console.Write("Pilih Penyewaan : ");
            int indexPenyewaan = 1;
            foreach (Penyewaan penyewaan in listPenyewaan)
            {
                Console.WriteLine("{0}. {1}", indexPenyewaan, penyewaan.Pelanggan.Nama_Pelanggan);
                indexPenyewaan++;
            }
            Console.Write("Nomor Penyewaan : ");
            int nomorPenyewaan = int.Parse(Console.ReadLine());
            Penyewaan penyewaanTerpilih = listPenyewaan[nomorPenyewaan - 1];
            pengembalian.Penyewaan = penyewaanTerpilih;
            Console.Write("Tanggal Kembali : ");
            pengembalian.Tgl_Kembali = DateTime.Parse(Console.ReadLine());
            Console.Write("Total Biaya : ");
            pengembalian.Total_Biaya = int.Parse(Console.ReadLine());
            return pengembalian;
        }
    }
}