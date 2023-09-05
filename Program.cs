using System.Xml.Linq;

namespace Die_Dokumentablage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Die Dokumentenablage einer Behörde muss neu geregelt werden. Hierzu
            // soll eine neue Anwendung geschrieben werden, welche die Möglichkeit
            // besitzt alle wichtigen Informationen des Dokuments anzuzeigen und
            // den Ablageort anzugeben.

            // 1) Entwickeln Sie eine Klasse für den Ablageort mit folgenden
            // Informationen:
            // Stockwerk, Raumnummer, Regalnummer, Fach

            // 2) Entwickeln Sie eine Klasse für den Verantwortlichen mit
            // folgenden Informationen:
            // Name, Büronummer, Abteilung

            // 3) Entwickeln Sie eine Klasse für Dokumente mit folgenden
            // Informationen:
            // DokumentenNr, Datum der Erstellung, Ablageort,
            // Verantwortlicher, Kurzbeschreibung des Inhalts

            // 4) Erstellen Sie 5 Dokumente mit allen Feldern

            // 5) Erstellen Sie ein Menü, mit dem der Anwender das Dokument
            // anhand seiner Nummer wählen kann und dann alle relevanten
            // Informationen angezeigt bekommt.



            // Method starting the program, located in Menue.cs
            Menue.Start();
        }
    }
}