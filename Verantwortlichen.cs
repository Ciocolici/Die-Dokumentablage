using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Dokumentablage
{
    internal class Verantwortlichen
    {
        string name;
        string bueronummer;
        string abteilung;

        public Verantwortlichen(string name, string bueronummer, string abteilung)
        {
            this.name = name;
            this.bueronummer = bueronummer;
            this.abteilung = abteilung;
        }
        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nAnd here's a little bit about the responsible:\n");
            Console.WriteLine($"Name:\t\t{name}");
            Console.WriteLine($"Office number:\t{bueronummer}");
            Console.WriteLine($"Department:\t{abteilung}");

        }
    }
}
