using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class PengembalianController : IPengembalian
    {
        private Pengembalian pengembalianModel;
        private PengembalianView pengembalianView;

        public PengembalianController()
        {
            pengembalianModel = new Pengembalian();
            pengembalianView = new PengembalianView();
        }

        public void TampilData()
        {
            List<Pengembalian> listPengembalian = GetAll();
            pengembalianView.TampilData(listPengembalian);
        }

        public void TambahData()
        {
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
            Pengembalian pengembalian = new Pengembalian()
            {
                ID_Pengembalian = id,
                Tanggal_Pengembalian = tanggal,
                Kendaraan = kendaraan,
                Pelanggan = pelanggan
            };
            Insert(pengembalian);
        }

        

        public void HapusData()
        {
            pengembalianView.HapusData();
            int id = int.Parse(Console.ReadLine());
            Delete(id);
        }

        public List<Pengembalian> GetAll()
        {
            return pengembalianModel.GetAll();
        }

        public Pengembalian GetById(int id)
        {
            return pengembalianModel.GetById(id);
        }

        public void Insert(Pengembalian pengembalian)
        {
            pengembalianModel.TambahData(pengembalian);
        }

        public void Update(int id, Pengembalian pengembalian)
        {
            pengembalianModel.UbahData(pengembalian);
        }

        public void Delete(int id)
        {
            pengembalianModel.HapusData(id);
        }

        bool IPengembalian.Insert(Pengembalian pengembalian)
        {
            throw new NotImplementedException();
        }

        bool IPengembalian.Update(int id, Pengembalian pengembalian)
        {
            throw new NotImplementedException();
        }

        bool IPengembalian.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}