# Program CRUD MVC C#

Program ini merupakan contoh program CRUD (Create, Read, Update, Delete) MVC (Model-View-Controller) yang dibuat dengan menggunakan bahasa pemrograman C#.

## Struktur Folder dan File Program

Program ini menggunakan struktur folder dan file sebagai berikut:

```
- Models/
  - Kendaraan.cs
  - Pelanggan.cs
  - Reservasi.cs
  - Penyewaan.cs
  - Pengembalian.cs
- Interfaces/
  - IKendaraan.cs
  - IPelanggan.cs
  - IReservasi.cs
  - IPenyewaan.cs
  - IPengembalian.cs
- Views/
  - KendaraanView.cs
  - PelangganView.cs
  - ReservasiView.cs
  - PenyewaanView.cs
  - PengembalianView.cs
- Controllers/
  - KendaraanController.cs
  - PelangganController.cs
  - ReservasiController.cs
  - PenyewaanController.cs
  - PengembalianController.cs
- Program.cs

```

Folder Models berisi kelas-kelas yang merepresentasikan objek-objek pada program, seperti Kendaraan, Pelanggan, Reservasi, Penyewaan, dan Pengembalian.

Folder Interfaces berisi interface-interface yang digunakan untuk mengakses data pada program.

Folder Views berisi kelas-kelas yang digunakan untuk menampilkan data pada program.

Folder Controllers berisi kelas-kelas yang mengatur alur program dan menghubungkan antara Models, Views, dan Interfaces.

File Program.cs berisi method Main() yang digunakan untuk memanggil method Menu() dari masing-masing controller.
