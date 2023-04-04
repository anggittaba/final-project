using System;

namespace RentalKendaraanMVC.Models
{
    public class Reservasi
    {
        public int ID_Reservasi { get; set; }
        public DateTime Tgl_Reservasi { get; set; }
        public Pelanggan Pelanggan { get; set; }
        public Kendaraan Kendaraan { get; set; }
    }
}