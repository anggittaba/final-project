using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    public interface IPelangganRepository
    {
        void Create(Pelanggan pelanggan);
        void Update(Pelanggan pelanggan);
        void Delete(int id);
        List<Pelanggan> GetAll();
        Pelanggan GetById(int id);
    }
}