// See https://aka.ms/new-console-template for more information
using System;

namespace CalculatorConsole
{
    static class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Kalkulator: 21.11.4374");
            Console.Write("Masukkan angka pertama: ");
            if (!float.TryParse(Console.ReadLine(), out var angka1))
            {
                Console.WriteLine("Inputan yang dimasukkan tidak valid. Silakan Ulangi");
                return;
            }
            Console.Write("Masukkan angka kedua: ");
            if (!float.TryParse(Console.ReadLine(), out var angka2))
            {
                Console.WriteLine("Inputan yang dimasukkan tidak valid. Silakan ulangi!");
                return;
            }
            Console.WriteLine();
            PrintLong("Pilih Operasi",
                      "1. Penambahan",
                      "2. Pengurangan",
                      "3. Perkalian",
                      "4. Pembagian");
            Console.Write("Pilihan: ");
            if (!int.TryParse(Console.ReadLine(), out var pilih) || pilih <= 0 || pilih > 4)
            {
                Console.WriteLine("Inputan yang dimasukkan tidak valid. Silakan ulangi!");
                return;
            }
            float hasil = pilih switch
            {
                1 => angka1 + angka2,
                2 => angka1 - angka2,
                3 => angka1 * angka2,
                4 => angka1 / angka2,
                _ => float.NaN //should not reach here
            };
            string operasi = pilih switch
            {
                1 => "Penambahan",
                2 => "Pengurangan",
                3 => "Perkalian",
                4 => "Pembagian",
                _ => string.Empty
            };
            Console.WriteLine($"Hasil {operasi} dari {angka1} dan {angka2} adalah {hasil}");

        }
        internal static void PrintLong(params string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }
    }
}