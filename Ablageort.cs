using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Dokumentablage
{
    internal class Ablageort
    {
        string stockwerk;
        string raumnummer;
        string regalnummer;
        string fach;

        public Ablageort(string stockwerk, string raumnummer, string regalnummer, string fach)
        {
            this.stockwerk = stockwerk;
            this.raumnummer = raumnummer;
            this.regalnummer = regalnummer;
            this.fach = fach;
        }
        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nHere's a little bit about the storage location:\n");
            Console.WriteLine($"Floor:\t\t{stockwerk}");
            Console.WriteLine($"Room number:\t{raumnummer}");
            Console.WriteLine($"Shelf number:\t{regalnummer}");
            Console.WriteLine($"Subject:\t{fach}");
        }
    }
}
