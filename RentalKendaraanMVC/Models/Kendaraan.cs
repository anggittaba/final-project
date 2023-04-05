using System.Collections.Generic;
using System.Data.SqlClient;
using RentalKendaraanMVC.Interfaces;

namespace RentalKendaraanMVC.Models
{
    public class Kendaraan
    {
        public int ID_Kendaraan { get; set; }
        public string Jenis_Kendaraan { get; set; }
        public string Merk_Kendaraan { get; set; }
        public int Tahun_Produksi { get; set; }
        public int Harga_Sewa_Per_Hari { get; set; }
    }

}