/*=======================================
| Konsolenanwendung Version: 01
| Programmname: Wiederstandsberechnung
| Datum: 11.11.2021
| Für: Windows 10
| Autor: Raphael Patzelt
| Beschreibung:
| -
=======================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Widerstandsberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            int iAnzahlWid;
            string sSchaltung, sAbbruch = "N";
            double dWidKehr = 0, dWidErgebnis = 0;

            while (sAbbruch == "N")
            {

                WriteLine("Wieviele Widerstände wollen Sie berechnen?");
                if (int.TryParse(ReadLine(), out iAnzahlWid))
                {
                    double[] dAWidWerte = new double[iAnzahlWid];
                    WriteLine("Wollen Sie seriell oder parallel berechnen? (s/p)");
                    sSchaltung = ReadLine().ToUpper();



                    for (int i = 0; i < iAnzahlWid; i++)
                    {
                        WriteLine($"Geben Sie den Wert für den {i + 1}. Widerstand ein:");
                        if (double.TryParse(ReadLine(), out double dWid))
                        {
                            if (dWid > 0)
                            {
                                dAWidWerte[i] = dWid;
                            }
                            else
                            {
                                WriteLine("Es sind nur positive Widerstandswerte erlaubt!");
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                            WriteLine("Ungültige Eingabe - nur Kommerzahlen erlaubt!");
                        }
                    }

                    switch (sSchaltung)
                    {
                        case "P":
                            foreach (var item in dAWidWerte)
                            {
                                dWidKehr += 1 / item;
                            }
                            dWidErgebnis = 1 / dWidKehr;
                            break;

                        case "S":
                            foreach (var item in dAWidWerte)
                            {
                                dWidErgebnis += item;
                            }
                            break;

                        default:
                            WriteLine("\n\tFalsche Eingabe, - nur \"P\" (Parallel) oder \"S\" (Seriell) erlaubt");
                            break;
                    }

                }
                else
                {
                    WriteLine("\n\tBitte überprüfen Sie die Eingabe - nur Zahlen erlaubt!");
                }

                WriteLine($"Das Ergebnis lautet: {dWidErgebnis}");


                //WriteLine("Wollen Sie das Programm beenden? (j/n)");
                //sAbbruch = ReadLine().ToUpper();

                //while(sAbbruch != "N" && sAbbruch != "J")
                //{
                //    WriteLine("Ungültige Eingabe! Nur \"N\" oder \"J\" erlaubt!");
                //    sAbbruch = ReadLine().ToUpper();
                //}


                //===============Alternative zum obigen Schleifenabbruch================\\
                while(!false)
                {
                    WriteLine("Wollen Sie das Programm beenden? (j/n)");
                    sAbbruch = ReadLine().ToUpper();

                    if (sAbbruch == "N" | sAbbruch == "J")
                    {
                        break;
                    }
                    WriteLine("Ungültige Eingabe! Nur \"N\" oder \"J\" erlaubt!");
                }

                WriteLine("\n");
            }

        }
    }
}
