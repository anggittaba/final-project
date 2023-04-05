using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class PelangganController
    {
        private IPelangganRepository pelangganRepository;

        public PelangganController(IPelangganRepository pelangganRepository)
        {
            this.pelangganRepository = pelangganRepository;
        }

        public void CreatePelanggan()
        {
            Console.WriteLine("Masukkan ID Pelanggan:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Nama Pelanggan:");
            string nama = Console.ReadLine();
            Console.WriteLine("Masukkan Alamat Pelanggan:");
            string alamat = Console.ReadLine();
            Console.WriteLine("Masukkan No. Telp Pelanggan:");
            string noTelp = Console.ReadLine();

            Pelanggan pelanggan = new Pelanggan
            {
                ID_Pelanggan = id,
                Nama_Pelanggan = nama,
                Alamat_Pelanggan = alamat,
                No_Telp_Pelanggan = noTelp
            };

            pelangganRepository.Create(pelanggan);
            Console.WriteLine ("Pelanggan berhasil ditambahkan!");

        }
        public void UpdatePelanggan()
        {
            Console.WriteLine("Masukkan ID Pelanggan yang ingin diupdate:");
            int id = int.Parse(Console.ReadLine());

            Pelanggan pelanggan = pelangganRepository.GetById(id);

            if (pelanggan == null)
            {
                Console.WriteLine("Pelanggan dengan ID tersebut tidak ditemukan!");
                return;
            }

            Console.WriteLine("Masukkan Nama Pelanggan:");
            string nama = Console.ReadLine();
            Console.WriteLine("Masukkan Alamat Pelanggan:");
            string alamat = Console.ReadLine();
            Console.WriteLine("Masukkan No. Telp Pelanggan:");
            string noTelp = Console.ReadLine();

            pelanggan.Nama_Pelanggan = nama;
            pelanggan.Alamat_Pelanggan = alamat;
            pelanggan.No_Telp_Pelanggan = noTelp;

            pelangganRepository.Update(pelanggan);
            Console.WriteLine("Pelanggan berhasil diupdate!");
        }

        public void DeletePelanggan()
        {
            Console.WriteLine("Masukkan ID Pelanggan yang ingin dihapus:");
            int id = int.Parse(Console.ReadLine());

            Pelanggan pelanggan = pelangganRepository.GetById(id);

            if (pelanggan == null)
            {
                Console.WriteLine("Pelanggan dengan ID tersebut tidak ditemukan!");
                return;
            }

            pelangganRepository.Delete(id);
            Console.WriteLine("Pelanggan berhasil dihapus!");
        }

        public void GetAllPelanggan()
        {
            List<Pelanggan> pelangganList = pelangganRepository.GetAll();

            if (pelangganList.Count == 0)
            {
                Console.WriteLine("Tidak ada data pelanggan!");
                return;
            }

            Console.WriteLine("Daftar Pelanggan:");
            foreach (Pelanggan pelanggan in pelangganList)
            {
                Console.WriteLine($"ID Pelanggan: {pelanggan.ID_Pelanggan}, Nama Pelanggan: {pelanggan.Nama_Pelanggan}, Alamat Pelanggan: {pelanggan.Alamat_Pelanggan}, No. Telp Pelanggan: {pelanggan.No_Telp_Pelanggan}");
            }
        }

        public void GetPelangganById()
        {
            Console.WriteLine("Masukkan ID Pelanggan yang ingin ditampilkan:");
            int id = int.Parse(Console.ReadLine());

            Pelanggan pelanggan = pelangganRepository.GetById(id);

            if (pelanggan == null)
            {
                Console.WriteLine("Pelanggan dengan ID tersebut tidak ditemukan!");
                return;
            }

            Console.WriteLine($"ID Pelanggan: {pelanggan.ID_Pelanggan}, Nama Pelanggan: {pelanggan.Nama_Pelanggan}, Alamat Pelanggan: {pelanggan.Alamat_Pelanggan}, No. Telp Pelanggan: {pelanggan.No_Telp_Pelanggan}");
        }
    }
}