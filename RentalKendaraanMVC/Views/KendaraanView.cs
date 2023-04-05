using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Controllers;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    public class KendaraanView
    {
        private KendaraanController kendaraanController;

        public KendaraanView(KendaraanController kendaraanController)
        {
            this.kendaraanController = kendaraanController;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== MENU KENDARAAN =====");
            Console.WriteLine("1. Tambah Kendaraan");
            Console.WriteLine("2. Update Kendaraan");
            Console.WriteLine("3. Hapus Kendaraan");
            Console.WriteLine("4. Tampilkan Semua Kendaraan");
            Console.WriteLine("5. Cari Kendaraan");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("==========================");
        }

        public void TambahKendaraan()
        {
            Console.Clear();
            Console.WriteLine("===== TAMBAH KENDARAAN =====");
            kendaraanController.CreateKendaraan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void UpdateKendaraan()
        {
            Console.Clear();
            Console.WriteLine("===== UPDATE KENDARAAN =====");
            kendaraanController.UpdateKendaraan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void HapusKendaraan()
        {
            Console.Clear();
            Console.WriteLine("===== HAPUS KENDARAAN =====");
            kendaraanController.DeleteKendaraan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void TampilkanSemuaKendaraan()
        {
            Console.Clear();
            Console.WriteLine("===== DAFTAR KENDARAAN =====");
            kendaraanController.GetAllKendaraan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void CariKendaraan()
        {
            Console.Clear();
            Console.WriteLine("===== CARI KENDARAAN =====");
            kendaraanController.GetKendaraanById();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }
    }
}