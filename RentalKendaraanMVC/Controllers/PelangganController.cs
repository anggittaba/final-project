using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class PelangganController : IPelanggan
    {
        private Pelanggan pelangganModel;
        private PelangganView pelangganView;

        public PelangganController()
        {
            pelangganModel = new Pelanggan();
            pelangganView = new PelangganView();
        }

        public void TampilData()
        {
            List<Pelanggan> listPelanggan = GetAll();
            pelangganView.TampilData(listPelanggan);
        }

        public void TambahData()
        {
            pelangganView.TambahData();
            string nama = Console.ReadLine();
            string jenis_kelamin = Console.ReadLine();
            string alamat = Console.ReadLine();
            string no_hp = Console.ReadLine();
            Pelanggan pelanggan = new Pelanggan()
            {
                Nama_Pelanggan = nama,
                Alamat = alamat,
                No_Telp = no_hp
            };
            Insert(pelanggan);
        }

        public void UbahData()
        {
            pelangganView.UbahData();
            int id = int.Parse(Console.ReadLine());
            string nama = Console.ReadLine();

            string alamat = Console.ReadLine();
            string no_hp = Console.ReadLine();
            Pelanggan pelanggan = new Pelanggan()
            {
                ID_Pelanggan = id,
                Nama_Pelanggan = nama,
                Alamat = alamat,
                No_Telp = no_hp
            };
            Update(id, pelanggan);
        }

        public void HapusData()
        {
            pelangganView.HapusData();
            int id = int.Parse(Console.ReadLine());
            Delete(id);
        }

        public List<Pelanggan> GetAll()
        {
            return pelangganModel.GetAll();
        }

        public Pelanggan GetById(int id)
        {
            return pelangganModel.GetById(id);
        }

        public void Insert(Pelanggan pelanggan)
        {
            pelangganModel.TambahData(pelanggan);
        }

        public void Update(int id, Pelanggan pelanggan)
        {
            pelangganModel.UbahData(pelanggan);
        }

        public void Delete(int id)
        {
            pelangganModel.HapusData(id);
        }

        bool IPelanggan.Insert(Pelanggan pelanggan)
        {
            throw new NotImplementedException();
        }

        bool IPelanggan.Update(int id, Pelanggan pelanggan)
        {
            throw new NotImplementedException();
        }

        bool IPelanggan.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}