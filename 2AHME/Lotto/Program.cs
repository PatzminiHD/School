/*=======================================
| Konsolenanwendung Version: 01
| Programmname: 08_Lotto (ohne Datenfeld)
| Linux (KDE Neon)
| Autor: Raphael Patzelt
| Beschreibung:
|   Verwenden einer Zufallszahl: ein Objekt aus der Klasse Random
|   erstellen
|   Verschachtelte Schleifen: in der äußeren while Schleife werden ein for- und
|   eine weitere while Schleife verwendet
|   Verschachtelte if - Verzweigungen und logisch verknüpfte Bedingungen
|   Allgemein: Es werden 6 Zufallszahlen erzeugt, die sich nicht wiederholen dürfen und
|   in aufsteigender Reihenfolge geordnet werden.
=======================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int iZufall0 = 0;
            int iZufall1 = 0;
            int iZufall2 = 0;
            int iZufall3 = 0;
            int iZufall4 = 0;
            int iZufall5 = 0;
            int iZufall6 = 0;
            int iHelp;
            bool bCorrectAnswer = true, bContinueProgram = true;

            //==========Hauptschleife==========
            while (bContinueProgram)
            {
            
                Console.WriteLine("\n\tProgramm zum Erzeugen eines Lottotipps mit Joker");

                Random rnd = new Random();

                //==========Unterschleife==========
                //Erzeugen von Zufallszahlen, die sich nicht wiederholen dürfen (if - Abfragen)
                for (int i = 0; i < 7; i++)
                {
                    if (i == 0)
                    {
                        iZufall0 = rnd.Next(1, 45);
                        Console.WriteLine($"Lottozahl {i + 1}: {iZufall0}");
                    }
                    if (i == 1)
                    {
                        iZufall1 = rnd.Next(1, 45);
                        if (iZufall0 != iZufall1)
                        {
                            Console.WriteLine($"Lottozahl {i + 1}: {iZufall1}");
                        }
                        else
                        {
                            i--;
                            continue;
                        }

                    }
                    if (i == 2)
                    {
                        iZufall2 = rnd.Next(1, 45);
                        if (iZufall0 != iZufall2 & iZufall1 != iZufall2)
                        {
                            Console.WriteLine($"Lottozahl {i + 1}: {iZufall2}");
                        }
                        else
                        {
                            i--;
                            continue;
                        }

                    }
                    if (i == 3)
                    {
                        iZufall3 = rnd.Next(1, 45);
                        if (iZufall0 != iZufall3 & iZufall1 != iZufall3 & iZufall2 != iZufall3)
                        {
                            Console.WriteLine($"Lottozahl {i + 1}: {iZufall3}");
                        }
                        else
                        {
                            i--;
                            continue;
                        }
                    }
                    if (i == 4)
                    {
                        iZufall4 = rnd.Next(1, 45);
                        if (iZufall0 != iZufall4 & iZufall1 != iZufall4 & iZufall2 != iZufall4 & iZufall3 != iZufall4)
                        {
                            Console.WriteLine($"Lottozahl {i + 1}: {iZufall4}");
                        }
                        else
                        {
                            i--;
                            continue;
                        }
                    }
                    if (i == 5)
                    {
                        iZufall5 = rnd.Next(1, 45);
                        if (iZufall0 != iZufall5 & iZufall1 != iZufall5 & iZufall2 != iZufall5 & iZufall3 != iZufall5 & iZufall4 != iZufall5)
                        {
                            Console.WriteLine($"Lottozahl {i + 1}: {iZufall5}");
                        }
                        else
                        {
                            i--;
                            continue;
                        }
                    }
                    if (i == 6)
                    {
                        iZufall6 = rnd.Next(1, 45);
                        if (iZufall0 != iZufall6 & iZufall1 != iZufall6 & iZufall2 != iZufall6 & iZufall3 != iZufall6 & iZufall4 != iZufall6 & iZufall5 != iZufall6)
                        {
                            Console.WriteLine($"Zusatzzahl : {iZufall6}");
                        }
                        else
                        {
                            i--;
                            continue;
                        }
                    }


                }
                //Sortieren der Lottozahlen 1-6 in aufsteigender Reihenfolge
                Console.WriteLine("\nLottozahlen in aufsteigender Reihenfolge\n");

                bool flag = true;

                //==========Unterschleife==========
                while (flag)
                {
                    if (iZufall0 > iZufall1)
                    {
                        iHelp = iZufall0;
                        iZufall0 = iZufall1;
                        iZufall1 = iHelp;

                    }
                    else
                    {
                        if (iZufall1 > iZufall2)
                        {
                            iHelp = iZufall1;
                            iZufall1 = iZufall2;
                            iZufall2 = iHelp;

                        }
                        else
                        {
                            if (iZufall2 > iZufall3)
                            {
                                iHelp = iZufall2;
                                iZufall2 = iZufall3;
                                iZufall3 = iHelp;

                            }
                            else
                            {
                                if (iZufall3 > iZufall4)
                                {
                                    iHelp = iZufall3;
                                    iZufall3 = iZufall4;
                                    iZufall4 = iHelp;

                                }
                                else
                                {
                                    if (iZufall4 > iZufall5)
                                    {
                                        iHelp = iZufall4;
                                        iZufall4 = iZufall5;
                                        iZufall5 = iHelp;

                                    }
                                    else
                                    {
                                        flag = false;
                                    }
                                }
                            }
                        }
                    }

                }
                //==========Ausgabe der geordneten Zahlen==========
                Console.WriteLine($"1 Lottozahl: {iZufall0}");
                Console.WriteLine($"2 Lottozahl: {iZufall1}");
                Console.WriteLine($"3 Lottozahl: {iZufall2}");
                Console.WriteLine($"4 Lottozahl: {iZufall3}");
                Console.WriteLine($"5 Lottozahl: {iZufall4}");
                Console.WriteLine($"6 Lottozahl: {iZufall5}");
                Console.WriteLine($"Zusatzzahl: {iZufall6}");

                Console.WriteLine("\nWollen Sie das Programm fortfahren? (J/N)");
                bCorrectAnswer = true;


                //==========Unterschleife==========
                //Stellt sicher, dass das Programm nur mit J oder N fortgesetzt oder beendet werden kann
                while (bCorrectAnswer)
                {

                    switch (Console.ReadLine())
                    {
                        case "J":
                        case "j":
                            bContinueProgram = true;
                            bCorrectAnswer = false;
                            break;

                        case "N":
                        case "n":
                            bContinueProgram = false;
                            bCorrectAnswer = false;
                            break;

                        default:
                            bCorrectAnswer = true;
                            Console.WriteLine("Ungültige Eingabe, bitte versuchen Sie es erneut:");
                            break;
                    }
                }

            }
        }
    }
}