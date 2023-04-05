using RentalKendaraanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalKendaraanMVC.Repositories
{
    public interface IReservasiRepository
    {
        IEnumerable<Reservasi> GetAll();
        Reservasi GetById(int id);
        void Insert(Reservasi reservasi);
        void Update(int id, Reservasi reservasi);
        void Delete(int id);
    }
}