/*=======================================
| Konsolenanwendung Version: 01
| Programmname: Widerstandsberechnung
| Windows 10
| Autor: Raphael Patzelt
| Beschreibung:
|       Eingabe Anzahl von Widerstände
|       Einagbe Seriell/Paralell
|       Ausgabe des Zusammengesetzten Widerstandes
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
        static void Main()
        {
            int iResistorCount;
            bool bFlag;
            string sAbbruch = "N";

            while (sAbbruch == "N")
            {
                bFlag = true;
                //Einlesen der Anzahl der Widerstände
                WriteLine("Geben Sie die Anzahl der Widerstände ein:");
                while (!false)
                {
                    if (int.TryParse(ReadLine(), out iResistorCount))
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("Eingabe ungültig, bitte versuchen Sie es erneut:");
                    }
                }

                //Erstellen des Arrays mit der zuvor eingegebenen Zeilenanzahl
                double[] daResistorValues = new double[iResistorCount];

                //Einlesen der Widerstandswerte für jeden Widerstand
                for (int i = 0; i < daResistorValues.Length; i++)
                {
                    WriteLine($"Geben Sie den Wert für den Widerstand {i + 1} ein:");
                    while (!false)
                    {
                        if (double.TryParse(ReadLine(), out daResistorValues[i]))
                        {
                            break;
                        }
                        else
                        {
                            WriteLine("Eingabe ungültig, bitte versuchen Sie erneut");
                        }
                    }
                }

                //Abfrage ob parallel oder in Serie berechnet werden soll, und Ausgabe dieser Berechnung
                WriteLine("Geben Sie ein ob Sie die Widerstände in Serie oder Parallel berechnen wollen (s/p):");
                while (bFlag)
                {
                    switch (ReadLine().ToLower())
                    {
                        case "s":
                        case "serie":
                            WriteLine($"Alle Widerstände in Serie geschaltet ergeben einen Gesamtwiderstand von {Berechnung.SerienWid(daResistorValues)} Ohm");
                            bFlag = false;
                            break;

                        case "p":
                        case "parallel":
                            WriteLine($"Alle Widerstände in Serie geschaltet ergeben einen Gesamtwiderstand von {Berechnung.ParalleleWid(daResistorValues)} Ohm");
                            bFlag = false;
                            break;

                        default:
                            WriteLine("Eingabe ungültig, bitte versuche Sie es erneut:");
                            break;

                    }
                }
                while (!false)
                {
                    WriteLine("Wollen Sie das Programm beenden? (j/n)");
                    sAbbruch = ReadLine().ToUpper();

                    if (sAbbruch == "N" | sAbbruch == "J")
                    {
                        break;
                    }
                    WriteLine("Ungültige Eingabe! Nur \"N\" oder \"J\" erlaubt!");
                }
            }
        }
    }


    //===============|Statische Klasse|===============
    //static - Es muss kein Objekt erstellt werden, um auf die Klasse zuzugreifen
    static class Berechnung
    {
        //Berechnen der Widerstände wenn in Parallel geschalten
        public static double ParalleleWid(double[] daResistorValues)
        {
            double iSum = 0;
            for (int i = 0; i < daResistorValues.Length; i++)
            {
                if (daResistorValues[i] == 0)
                {
                    return 0;
                }
                iSum += 1 / daResistorValues[i];
            }
            return 1 / iSum;
        }


        //Berechnen der Widerstände wenn in Serie geschalten
        public static double SerienWid(double[] daResistorValues)
        {
            double iSum = 0;
            foreach (var item in daResistorValues)
            {
                iSum += item;
            }

            return iSum;
        }
    }
}
