using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Dokumentablage
{
    internal class Menue
    {
        // Lists with the variables/fields located in the three classes
        public static List<Dokumente> documentList = new List<Dokumente>();
        public static List<Ablageort> ablageortList = new List<Ablageort>();
        public static List<Verantwortlichen> verantwortlichenList = new List<Verantwortlichen>();
        
        public static void Start()
        {
            // The Method that declares the fields/variables inside the lists
            MakeTheLists();
            // The method used to welcome the user
            Hello();

            // Loop for the program
            bool repeat;

            do
            {
                int choiceDocument;
                repeat = false;

                // The variable "choiceDocument" becomes the value given by the method "DocumentChoice()",
                // which is a method used to ask the user to choose a document number 
                // (-1, to be used as Index, because Indexes start at 0)
                choiceDocument = DocumentChoice();
                // Then the method "Ausgabe" is used with the value given by "choiceDocument" as its index
                // The method will start another 3 methods, which display the fields representing the index given by choiceDocument
                Ausgabe(choiceDocument);
                // The method "Repeat()" asks the user if he wants to restart the program, resulting in a bool true/false, which will then be the value of variable "repeat" 
                // as bool True/False to check if the program should restart or not
                repeat = Repeat();
            } while (repeat == true);

        }

        public static void MakeTheLists()
        {
            documentList.Add(new Dokumente("666", new DateTime(2012, 12, 12), "Hell", "Lucifer", "information about people eaten by dinosaurs"));
            documentList.Add(new Dokumente("12311", new DateTime(2021, 10, 3), "Heaven", "Satana", "information about people eaten by skeletons"));
            documentList.Add(new Dokumente("9452", new DateTime(2002, 5, 22), "Outworld", "Beelzebub", "information about people eaten by your mother"));
            documentList.Add(new Dokumente("5437", new DateTime(1995, 2, 15), "Underworld", "Skaraoski", "information about people eaten by insects"));
            documentList.Add(new Dokumente("44235", new DateTime(2015, 7, 19), "Another Dimension", "Draku", "information about people eaten by themselves"));

            ablageortList.Add(new Ablageort("-2", "666", "20", "Unicorn Studies"));
            ablageortList.Add(new Ablageort("-10", "66", "12", "Cookie Philosophy"));
            ablageortList.Add(new Ablageort("-22", "23", "44", "Advanced Cloud Shape Recognition"));
            ablageortList.Add(new Ablageort("-5", "-666", "101", "Alien Language Decoding"));
            ablageortList.Add(new Ablageort("-66", "999", "666", "World Air Guitar Championship"));

            verantwortlichenList.Add(new Verantwortlichen("Lucifer", "66", "Department of Silly Walks"));
            verantwortlichenList.Add(new Verantwortlichen("Satana", "666", "Bureau of Misplaced Socks"));
            verantwortlichenList.Add(new Verantwortlichen("Beelzebub", "-666", "Division of Punny Jokes"));
            verantwortlichenList.Add(new Verantwortlichen("Skaraoski", "23", "Office of Imaginary Creature Care"));
            verantwortlichenList.Add(new Verantwortlichen("Draku", "403", "Institute of Napping Studies"));
        }

        public static void Hello()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r\n ######  ### #######    ######  ####### #    # #     # #     # ####### #     # #######    #    ######  #          #     #####  ####### \r\n #     #  #  #          #     # #     # #   #  #     # ##   ## #       ##    #    #      # #   #     # #         # #   #     # #       \r\n #     #  #  #          #     # #     # #  #   #     # # # # # #       # #   #    #     #   #  #     # #        #   #  #       #       \r\n #     #  #  #####      #     # #     # ###    #     # #  #  # #####   #  #  #    #    #     # ######  #       #     # #  #### #####   \r\n #     #  #  #          #     # #     # #  #   #     # #     # #       #   # #    #    ####### #     # #       ####### #     # #       \r\n #     #  #  #          #     # #     # #   #  #     # #     # #       #    ##    #    #     # #     # #       #     # #     # #       \r\n ######  ### #######    ######  ####### #    #  #####  #     # ####### #     #    #    #     # ######  ####### #     #  #####  ####### \r\n                                                                                                                                       \r\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nWelcome to DaHellCompanyYy\n");
        }
        public static int DocumentChoice()
        {
            int input;
            bool check;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Which document would you like to know about? Choose a number.");
                Console.WriteLine("\n\n(1)666\n(2)12311\n(3)9452\n(4)5437\n(5)44235\n\n");
                check = int.TryParse(Console.ReadLine(), out input);

                if (!check || input < 1 || input > 5)
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\nPlease choose a number between 1 5.");
                }

            } while (!check);

            return input - 1;
        }

        public static void Ausgabe(int Choice)
        {
            Console.Clear();
            documentList[Choice].Output();
            ablageortList[Choice].Output();
            verantwortlichenList[Choice].Output();
        }

        public static bool Repeat()
        {
            bool check;
            bool repeatMethod = false;
            do
            {
                int repeatAnswer;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nWould you like to check another document? 1/2");
                Console.WriteLine("\n1.Yes\n2.No");
                check = int.TryParse(Console.ReadLine(), out repeatAnswer);
                if (check == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Numbers................");
                }
                else if (repeatAnswer == 1)
                {
                    repeatMethod = true;
                    Console.Clear();
                }
                else if (repeatAnswer == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Big shame yo!");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("1 oR 2, Iz It DaT H@@@@RD?!?!!");
                    check = false;
                }
            } while (check == false);

            return repeatMethod;
        }
    }
}
