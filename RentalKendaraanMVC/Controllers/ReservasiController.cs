using System;
using System.Collections.Generic;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Models;
using RentalKendaraanMVC.Views;

namespace RentalKendaraanMVC.Controllers
{
    public class ReservasiController : IReservasi
    {
        private Reservasi reservasiModel;
        private ReservasiView reservasiView;

        public ReservasiController()
        {
            reservasiModel = new Reservasi();
            reservasiView = new ReservasiView();
        }

        public void TampilData()
        {
            List<Reservasi> listReservasi = GetAll();
            reservasiView.TampilData(listReservasi);
        }

        public void TambahData()
        {
            reservasiView.TambahData();
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
            Reservasi reservasi = new Reservasi()
            {
                ID_Reservasi = id,
                Tanggal_Pesan = tanggal,
                Kendaraan = kendaraan,
                Pelanggan = pelanggan
            };
            Insert(reservasi);
        }

        public void UbahData()
        {
            reservasiView.UbahData();
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
            Reservasi reservasi = new Reservasi()
            {
                ID_Reservasi = id,
                Tanggal_Pesan = tanggal,
                Kendaraan = kendaraan,
                Pelanggan = pelanggan
            };
            Update(id, reservasi);
        }

        public void HapusData()
        {
            reservasiView.HapusData();
            int id = int.Parse(Console.ReadLine());
            Delete(id);
        }

        public List<Reservasi> GetAll()
        {
            return reservasiModel.GetAll();
        }

        public Reservasi GetById(int id)
        {
            return reservasiModel.GetById(id);
        }

        public void Insert(Reservasi reservasi)
        {
            reservasiModel.TambahData(reservasi);
        }

        public void Update(int id, Reservasi reservasi)
        {
            reservasiModel.UbahData(reservasi);
        }

        public void Delete(int id)
        {
            reservasiModel.HapusData(id);
        }
    }
}