using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    interface IPelanggan
    {
        List<Pelanggan> GetAll();
        Pelanggan GetById(int id);
        bool Insert(Pelanggan pelanggan);
        bool Update(int id, Pelanggan pelanggan);
        bool Delete(int id);
    }
}