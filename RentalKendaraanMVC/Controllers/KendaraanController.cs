using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class KendaraanController
    {
        private IKendaraanRepository kendaraanRepository;

        public KendaraanController(IKendaraanRepository kendaraanRepository)
        {
            this.kendaraanRepository = kendaraanRepository;
        }

        public void CreateKendaraan()
        {
            Console.WriteLine("Masukkan ID Kendaraan:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Jenis Kendaraan:");
            string jenis = Console.ReadLine();
            Console.WriteLine("Masukkan Merk Kendaraan:");
            string merk = Console.ReadLine();
            Console.WriteLine("Masukkan Tahun Produksi Kendaraan:");
            int tahun = int.Parse(Console.ReadLine());

            Kendaraan kendaraan = new Kendaraan
            {
                ID_Kendaraan = id,
                Jenis_Kendaraan = jenis,
                Merk_Kendaraan = merk,
                Tahun_Produksi = tahun
            };

            kendaraanRepository.Create(kendaraan);
            Console.WriteLine("Kendaraan berhasil ditambahkan!");
        }

        public void UpdateKendaraan()
        {
            Console.WriteLine("Masukkan ID Kendaraan yang ingin diupdate:");
            int id = int.Parse(Console.ReadLine());

            Kendaraan kendaraan = kendaraanRepository.GetById(id);

            if (kendaraan == null)
            {
                Console.WriteLine("Kendaraan dengan ID tersebut tidak ditemukan!");
                return;
            }

            Console.WriteLine("Masukkan Jenis Kendaraan:");
            string jenis = Console.ReadLine();
            Console.WriteLine("Masukkan Merk Kendaraan:");
            string merk = Console.ReadLine();
            Console.WriteLine("Masukkan Tahun Produksi Kendaraan:");
            int tahun = int.Parse(Console.ReadLine());

            kendaraan.Jenis_Kendaraan = jenis;
            kendaraan.Merk_Kendaraan = merk;
            kendaraan.Tahun_Produksi = tahun;

            kendaraanRepository.Update(kendaraan);
            Console.WriteLine("Kendaraan berhasil diupdate!");
        }

        public void DeleteKendaraan()
        {
            Console.WriteLine("Masukkan ID Kendaraan yang ingin dihapus:");
            int id = int.Parse(Console.ReadLine());

            Kendaraan kendaraan = kendaraanRepository.GetById(id);

            if (kendaraan == null)
            {
                Console.WriteLine("Kendaraan dengan ID tersebut tidak ditemukan!");
                return;
            }

            kendaraanRepository.Delete(id);
            Console.WriteLine("Kendaraan berhasil dihapus!");
        }

        public void GetAllKendaraan()
        {
            List<Kendaraan> kendaraanList = kendaraanRepository.GetAll();

            if (kendaraanList.Count == 0)
            {
                Console.WriteLine("Tidak ada data kendaraan!");
                return;
            }

            Console.WriteLine("Daftar Kendaraan:");
            foreach (Kendaraan kendaraan in kendaraanList)
            {
                Console.WriteLine($"ID Kendaraan: {kendaraan.ID_Kendaraan}, Jenis Kendaraan: {kendaraan.Jenis_Kendaraan}, Merk Kendaraan: {kendaraan.Merk_Kendaraan}, Tahun Produksi: {kendaraan.Tahun_Produksi}");
            }
        }

        public void GetKendaraanById()
        {
            Console.WriteLine("Masukkan ID Kendaraan yang ingin ditampilkan:");
            int id = int.Parse(Console.ReadLine());

            Kendaraan kendaraan = kendaraanRepository.GetById(id);

            if (kendaraan == null)
            {
                Console.WriteLine("Kendaraan dengan ID tersebut tidak ditemukan!");
                return;
            }

            Console.WriteLine($"ID Kendaraan: {kendaraan.ID_Kendaraan}, Jenis Kendaraan: {kendaraan.Jenis_Kendaraan}, Merk Kendaraan: {kendaraan.Merk_Kendaraan}, Tahun Produksi: {kendaraan.Tahun_Produksi}");
        }
    }
}