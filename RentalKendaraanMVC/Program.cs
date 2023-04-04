using RentalKendaraanMVC.Controllers;
using RentalKendaraanMVC.Views;
using System;

namespace RentalKendaraanMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            KendaraanController kendaraanController = new KendaraanController(new KendaraanView());
            PelangganController pelangganController = new PelangganController(new PelangganView());
            ReservasiController reservasiController = new ReservasiController(new ReservasiView());
            PenyewaanController penyewaanController = new PenyewaanController(new PenyewaanView());
            PengembalianController pengembalianController = new PengembalianController(new PengembalianView());

            bool ulang = true;
            while (ulang)
            {
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Kendaraan");
                Console.WriteLine("2. Pelanggan");
                Console.WriteLine("3. Reservasi");
                Console.WriteLine("4. Penyewaan");
                Console.WriteLine("5. Pengembalian");
                Console.WriteLine();
                Console.WriteLine("Nomor Menu [1-5]: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        kendaraanController.Menu();
                        break;
                    case "2":
                        pelangganController.Menu();
                        break;
                    case "3":
                        reservasiController.Menu();
                        break;
                    case "4":
                        penyewaanController.Menu();
                        break;
                    case "5":
                        pengembalianController.Menu();
                        break;
                    default:
                        ulang = false;
                        break;
                }
            }
        }
    }
}