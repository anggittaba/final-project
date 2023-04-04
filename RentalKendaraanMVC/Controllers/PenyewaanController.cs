using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class PenyewaanController : IPenyewaan
    {
        private Penyewaan penyewaanModel;
        private PenyewaanView penyewaanView;

        public PenyewaanController()
        {
            penyewaanModel = new Penyewaan();
            penyewaanView = new PenyewaanView();
        }

        public void TampilData()
        {
            List<Penyewaan> listPenyewaan = GetAll();
            penyewaanView.TampilData(listPenyewaan);
        }

        public void TambahData()
        {
            penyewaanView.TambahData();
            int id = int.Parse(Console.ReadLine());
            DateTime tanggal = DateTime.Parse(Console.ReadLine());
            Kendaraan kendaraan = new Kendaraan()
            {
                ID_Kendaraan = int.Parse(Console.ReadLine())
            };
            Pelanggan pelanggan = new Pelanggan()
            {
                ID_Pelanggan = int.Parse(Console.ReadLine())
            };
            Karyawan karyawan = new Karyawan()
            {
                ID_Karyawan = int.Parse(Console.ReadLine())
            };
            Penyewaan penyewaan = new Penyewaan()
            {
                ID_Penyewaan = id,
                Tanggal_Peminjaman = tanggal,
                Kendaraan = kendaraan,
                Pelanggan = pelanggan,
                Karyawan = karyawan
            };
            Insert(penyewaan);
        }

        public void UbahData()
        {
            penyewaanView.UbahData();
            int id = int.Parse(Console.ReadLine());
            DateTime tanggal = DateTime.Parse(Console.ReadLine());
            Kendaraan kendaraan = new Kendaraan()
            {
                ID_Kendaraan = int.Parse(Console.ReadLine())
            };
            Pelanggan pelanggan = new Pelanggan()
            {
                ID_Pelanggan = int.Parse(Console.ReadLine())
            };
            Karyawan karyawan = new Karyawan()
            {
                ID_Karyawan = int.Parse(Console.ReadLine())
            };
            Penyewaan penyewaan = new Penyewaan()
            {
                ID_Penyewaan = id,
                Tanggal_Peminjaman = tanggal,
                Kendaraan = kendaraan,
                Pelanggan = pelanggan,
                Karyawan = karyawan
            };
            Update(id, penyewaan);
        }

        public void HapusData()
        {
            penyewaanView.HapusData();
            int id = int.Parse(Console.ReadLine());
            Delete(id);
        }

        public List<Penyewaan> GetAll()
        {
            return penyewaanModel.GetAll();
        }

        public Penyewaan GetById(int id)
        {
            return penyewaanModel.GetById(id);
        }

        public void Insert(Penyewaan penyewaan)
        {
            penyewaanModel.TambahData(penyewaan);
        }

        public void Update(int id, Penyewaan penyewaan)
        {
            penyewaanModel.UbahData(penyewaan);
        }

        public void Delete(int id)
        {
            penyewaanModel.HapusData(id);
        }
    }
}