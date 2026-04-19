using System;

class Program
{
    static void Main(string[] args)
    {
        string kodeBarang;
        int jumlah;
        int harga = 0;
        string namaBarang = "";
        int total = 0;
        int bayar, kembalian;

        Console.WriteLine("=== APLIKASI KASIR SEDERHANA ===");
        Console.WriteLine("Daftar Barang:");
        Console.WriteLine("001 - Beras (Rp 12.000)");
        Console.WriteLine("002 - Gula (Rp 14.000)");
        Console.WriteLine("003 - Telur (Rp 20.000)");
        Console.WriteLine("201 - Snack (Rp 5.000)");
        Console.WriteLine("202 - Es Krim (Rp 8.000)");
        Console.WriteLine("203 - Pulpen (Rp 3.000)");
        Console.WriteLine("204 - Pensil (Rp 2.000)");

        Console.Write("\nMasukkan Kode Barang: ");
        kodeBarang = Console.ReadLine();

        // Percabangan SWITCH
        switch (kodeBarang)
        {
            case "001":
                namaBarang = "Beras";
                harga = 12000;
                break;
            case "002":
                namaBarang = "Gula";
                harga = 14000;
                break;
            case "003":
                namaBarang = "Telur";
                harga = 20000;
                break;
            case "201":
                namaBarang = "Snack";
                harga = 5000;
                break;
            case "202":
                namaBarang = "Es Krim";
                harga = 8000;
                break;
            case "203":
                namaBarang = "Pulpen";
                harga = 3000;
                break;
            case "204":
                namaBarang = "Pensil";
                harga = 2000;
                break;
            default:
                Console.WriteLine("Kode tidak ditemukan!");
                return;
        }

        Console.Write("Masukkan Jumlah Beli: ");
        jumlah = int.Parse(Console.ReadLine());

        total = harga * jumlah;

        Console.WriteLine("\n=== STRUK PEMBELIAN ===");
        Console.WriteLine("Nama Barang  : " + namaBarang);
        Console.WriteLine("Harga Satuan : Rp " + harga);
        Console.WriteLine("Jumlah       : " + jumlah);
        Console.WriteLine("Total        : Rp " + total);

        Console.Write("\nMasukkan Uang Bayar: Rp ");
        bayar = int.Parse(Console.ReadLine());

        // Percabangan IF
        if (bayar < total)
        {
            Console.WriteLine("Uang tidak cukup!");
        }
        else
        {
            kembalian = bayar - total;
            Console.WriteLine("Kembalian    : Rp " + kembalian);
        }

        Console.WriteLine("\nTerima Kasih!");
    }
}
