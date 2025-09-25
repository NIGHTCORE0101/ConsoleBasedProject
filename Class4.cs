using System;

namespace DaftarSiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DAFTAR NAMA SISWA ===\n");
            // Membuat array nama siswa
            string[] siswa = { "Asep", "Budi", "Citra", "Dedi", "Eka" };

            // Menggunakan foreach untuk menampilkan semua nama
            foreach (string nama in siswa)
            {
                Console.WriteLine($"- {nama}");
            }

            Console.WriteLine("\\nProgram selesai. Tekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}