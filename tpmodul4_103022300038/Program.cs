using System;
using System.Collections.Generic;

class Program
{
    // Table-Driven: Kode Pos
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

    // State-Based Construction: DoorMachine
    class DoorMachine
    {
        public enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }
    }

    static void Main()
    {
        // Table-Driven Example
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kode pos {kelurahan}: {KodePos.GetKodePos(kelurahan)}\n");

        // State-Based Construction Example
        DoorMachine pintu = new DoorMachine();
        Console.WriteLine("\nMasukkan perintah (BukaPintu/KunciPintu) atau ketik 'exit' untuk keluar:");

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine().ToLower();

            if (input == "exit")
                break;
            else if (input == "bukapintu")
                pintu.BukaPintu();
            else if (input == "kuncipintu")
                pintu.KunciPintu();
            else
                Console.WriteLine("Perintah tidak dikenal!");
        }
    }
}
