using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    public interface IKendaraanRepository
    {
        void Create(Kendaraan kendaraan);
        void Update(Kendaraan kendaraan);
        void Delete(int id);
        List<Kendaraan> GetAll();
        Kendaraan GetById(int id);
    }
}