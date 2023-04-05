using RentalKendaraanMVC.Controllers;
using RentalKendaraanMVC.Interfaces;
using RentalKendaraanMVC.Views;
using RentalKendaraanMVC.Repositories;
using RentalKendaraanMVC.Models;
using System;
using System.Data.SqlClient;

namespace RentalKendaraanMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-T8JR52S;Database=db_RentalKendaraan;Integrated Security=True;Connect Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);

            IPelangganRepository pelangganRepository = new PelangganRepository(connection);
            IKendaraanRepository kendaraanRepository = new KendaraanRepository(connection);
            IReservasiRepository reservasiRepository = new ReservasiRepository(connection);
            IPenyewaanRepository penyewaanRepository = new PenyewaanRepository(connection);
            IPengembalianRepository pengembalianRepository = new PengembalianRepository(connection);

            PelangganController pelangganController = new PelangganController(pelangganRepository);
            KendaraanController kendaraanController = new KendaraanController(kendaraanRepository);
            ReservasiController reservasiController = new ReservasiController(reservasiRepository);
            PenyewaanController penyewaanController = new PenyewaanController(penyewaanRepository);
            PengembalianController pengembalianController = new PengembalianController(pengembalianRepository);

            PelangganView pelangganView = new PelangganView(pelangganController);
            KendaraanView kendaraanView = new KendaraanView(kendaraanController);
            ReservasiView reservasiView = new ReservasiView(reservasiController);
            PenyewaanView penyewaanView = new PenyewaanView(penyewaanController);
            PengembalianView pengembalianView = new PengembalianView(pengembalianController);

            MainMenuView mainMenuView = new MainMenuView(pelangganView, kendaraanView, reservasiView, penyewaanView, pengembalianView);
            mainMenuView.ShowMenu();
        }
    }
}