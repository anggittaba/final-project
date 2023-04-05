using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Controllers;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Views
{
    public class PelangganView
    {
        private PelangganController pelangganController;

        public PelangganView(PelangganController pelangganController)
        {
            this.pelangganController = pelangganController;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== MENU PELANGGAN =====");
            Console.WriteLine("1. Tambah Pelanggan");
            Console.WriteLine("2. Update Pelanggan");
            Console.WriteLine("3. Hapus Pelanggan");
            Console.WriteLine("4. Tampilkan Semua Pelanggan");
            Console.WriteLine("5. Cari Pelanggan");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("==========================");
        }

        public void TambahPelanggan()
        {
            Console.Clear();
            Console.WriteLine("===== TAMBAH PELANGGAN =====");
            pelangganController.CreatePelanggan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void UpdatePelanggan()
        {
            Console.Clear();
            Console.WriteLine("===== UPDATE PELANGGAN =====");
            pelangganController.UpdatePelanggan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void HapusPelanggan()
        {
            Console.Clear();
            Console.WriteLine("===== HAPUS PELANGGAN =====");
            pelangganController.DeletePelanggan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void TampilkanSemuaPelanggan()
        {
            Console.Clear();
            Console.WriteLine("===== DAFTAR PELANGGAN =====");
            pelangganController.GetAllPelanggan();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }

        public void CariPelanggan()
        {
            Console.Clear();
            Console.WriteLine("===== CARI PELANGGAN =====");
            pelangganController.GetPelangganById();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
            Console.ReadKey();
        }
    }
}

