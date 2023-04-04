using System.Collections.Generic;
using RentalKendaraanMVC.Models;

namespace RentalKendaraanMVC.Interfaces
{
    interface IPengembalian
    {
        List<Pengembalian> GetAll();
        Pengembalian GetById(int id);
        bool Insert(Pengembalian pengembalian);
        bool Update(int id, Pengembalian pengembalian);
        bool Delete(int id);
    }
}