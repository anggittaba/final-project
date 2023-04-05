using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalKendaraanMVC.Models
{
    public class Reservasi
    {
        public int ID_Reservasi { get; set; }
        public DateTime Tanggal_Reservasi { get; set; }
        public DateTime Tanggal_Pengembalian { get; set; }
        public int Biaya_Reservasi { get; set; }
        public Pelanggan Pelanggan { get; set; } // properti Pelanggan
        public int ID_Kendaraan { get; set; }
        public Kendaraan Kendaraan { get; set; }
    }

}