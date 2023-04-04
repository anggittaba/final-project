using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    interface IPenyewaan
    {
        List<Penyewaan> GetAll();
        Penyewaan GetById(int id);
        bool Insert(Penyewaan penyewaan);
        bool Update(int id, Penyewaan penyewaan);
        bool Delete(int id);
    }
}