using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Die_Dokumentablage
{
    internal class Dokumente
    {
        string dokumentennr;
        DateTime erstellungDatum;
        string ablagerort;
        string verantwortlicher;
        string kurzbeschreibungInhalt;

        public Dokumente(string dokumentennr, DateTime erstellungDatum, string ablagerort, string verantwortlicher, string kurzbeschreibungInhalt)
        {
            this.dokumentennr = dokumentennr;
            this.erstellungDatum = erstellungDatum;
            this.ablagerort = ablagerort;
            this.verantwortlicher = verantwortlicher;
            this.kurzbeschreibungInhalt = kurzbeschreibungInhalt;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nHere's a little bit about the document:\n");
            Console.WriteLine($"Document number:\t\t{dokumentennr}");
            Console.WriteLine($"Date of creation:\t\t{erstellungDatum}");
            Console.WriteLine($"Storage location:\t\t{ablagerort}");
            Console.WriteLine($"Responsible:\t\t\t{verantwortlicher}");
            Console.WriteLine($"Short content description:\t{kurzbeschreibungInhalt}");
        }
    }
}
