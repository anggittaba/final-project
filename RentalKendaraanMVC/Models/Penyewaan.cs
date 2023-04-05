using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RentalKendaraanMVC.Interfaces;

namespace RentalKendaraanMVC.Models
{
    public class Penyewaan
    {
        public int ID_Penyewaan { get; set; }
        public int ID_Reservasi { get; set; }
        public int ID_Pelanggan { get; set; }
        public int ID_Kendaraan { get; set; }
        public DateTime Tanggal_Penyewaan { get; set; }
        public int Biaya_Penyewaan { get; set; }
        public int Total_Biaya { get; set; }
        public bool Status_Penyewaan { get; set; }
    }
}