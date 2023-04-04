using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class KendaraanController : IKendaraan
    {
        private Kendaraan kendaraanModel;
        private KendaraanView kendaraanView;

        public KendaraanController()
        {
            kendaraanModel = new Kendaraan();
            kendaraanView = new KendaraanView();
        }

        public void TampilData()
        {
            List<Kendaraan> listKendaraan = GetAll();
            kendaraanView.TampilData(listKendaraan);
        }

        public void TambahData()
        {
            kendaraanView.TambahData();
            string jenis = Console.ReadLine();
            string merk = Console.ReadLine();
            int tahun = int.Parse(Console.ReadLine());
            Kendaraan kendaraan = new Kendaraan()
            {
                Jenis_Kendaraan = jenis,
                Merk_Kendaraan = merk,
                Tahun_Produksi = tahun
            };
            Insert(kendaraan);
        }

        public void UbahData()
        {
            kendaraanView.UbahData();
            int id = int.Parse(Console.ReadLine());
            string jenis = Console.ReadLine();
            string merk = Console.ReadLine();
            int tahun = int.Parse(Console.ReadLine());
            Kendaraan kendaraan = new Kendaraan()
            {
                ID_Kendaraan = id,
                Jenis_Kendaraan = jenis,
                Merk_Kendaraan = merk,
                Tahun_Produksi = tahun
            };
            Update(id, kendaraan);
        }

        public void HapusData()
        {
            kendaraanView.HapusData();
            int id = int.Parse(Console.ReadLine());
            Delete(id);
        }

        public List<Kendaraan> GetAll()
        {
            return kendaraanModel.GetAll();
        }

        public Kendaraan GetById(int id)
        {
            return kendaraanModel.GetById(id);
        }

        public void Insert(Kendaraan kendaraan)
        {
            kendaraanModel.TambahData(kendaraan);
        }

        public void Update(int id, Kendaraan kendaraan)
        {
            kendaraanModel.UbahData(kendaraan);
        }

        public void Delete(int id)
        {
            kendaraanModel.HapusData(id);
        }

        bool IKendaraan.Insert(Kendaraan kendaraan)
        {
            throw new NotImplementedException();
        }

        bool IKendaraan.Update(int id, Kendaraan kendaraan)
        {
            throw new NotImplementedException();
        }

        bool IKendaraan.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}