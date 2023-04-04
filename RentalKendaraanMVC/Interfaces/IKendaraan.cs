using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    public interface IKendaraan
    {
        List<Kendaraan> GetAll();
        Kendaraan GetById(int id);
        bool Insert(Kendaraan kendaraan);
        bool Update(int id, Kendaraan kendaraan);
        bool Delete(int id);
    }
}