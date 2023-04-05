using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RentalKendaraanMVC.Interfaces;

namespace RentalKendaraanMVC.Models
{
    public class Pengembalian
    {
        public int ID_Pengembalian { get; set; }
        public int ID_Penyewaan { get; set; }
        public DateTime Tanggal_Pengembalian { get; set; }
        public int Biaya_Denda { get; set; }
        public string Kondisi_Kendaraan { get; set; }
    }
}