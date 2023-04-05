using System.Data.SqlClient;

namespace RentalKendaraanMVC.Models
{
    public class Pelanggan
    {
        public int ID_Pelanggan { get; set; }
        public string Nama_Pelanggan { get; set; }
        public string Alamat_Pelanggan { get; set; }
        public string No_Telp_Pelanggan { get; set; }
        public string Jenis_Kelamin { get; set; }
        public string Email { get; set; }
    }
}
 