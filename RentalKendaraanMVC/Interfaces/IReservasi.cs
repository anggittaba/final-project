using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    interface IReservasi
    {
        List<Reservasi> GetAll();
        Reservasi GetById(int id);
        bool Insert(Reservasi reservasi);
        bool Update(int id, Reservasi reservasi);
        bool Delete(int id);
    }
}