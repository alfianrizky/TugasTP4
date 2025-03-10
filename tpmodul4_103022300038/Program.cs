using System;
using System.Collections.Generic;

class KodePos
{
    private static Dictionary<string, string> daftarKodePos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static string GetKodePos(string kelurahan)
    {
        return daftarKodePos.ContainsKey(kelurahan) ? daftarKodePos[kelurahan] : "Kode Pos tidak ditemukan";
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kode pos {kelurahan}: {KodePos.GetKodePos(kelurahan)}");
    }
}

