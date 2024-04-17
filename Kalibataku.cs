//5. Kalkulator Sederhana Kalibataku (Kali, Bagi, Tambah, Kurang)
using System;

class Kalibataku
{
    static void Main()
    {
        Console.WriteLine("Kalkulator Sederhana Kalibataku");
        Console.WriteLine("Pilih operasi:");
        Console.WriteLine("1. Kali");
        Console.WriteLine("2. Bagi");
        Console.WriteLine("3. Tambah");
        Console.WriteLine("4. Kurang");

        Console.Write("Masukkan pilihan (1/2/3/4): ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka pertama: ");
        double angka1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        double angka2 = Convert.ToDouble(Console.ReadLine());

        double hasil = 0;

        switch (pilihan)
        {
            case 1:
                hasil = angka1 * angka2;
                Console.WriteLine($"Hasil kali: {hasil}");
                break;
            case 2:
                if (angka2 != 0)
                {
                    hasil = angka1 / angka2;
                    Console.WriteLine($"Hasil bagi: {hasil}");
                }
                else
                {
                    Console.WriteLine("Tidak dapat melakukan pembagian dengan nol.");
                }
                break;
            case 3:
                hasil = angka1 + angka2;
                Console.WriteLine($"Hasil tambah: {hasil}");
                break;
            case 4:
                hasil = angka1 - angka2;
                Console.WriteLine($"Hasil kurang: {hasil}");
                break;
            default:
                Console.WriteLine("Pilihan tidak valid.");
                break;
        }
    }
}