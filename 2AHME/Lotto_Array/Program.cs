/*=======================================
| Konsolenanwendung Version: 02
| Programmname: 08_Lotto_Array (mit Datenfeld)
| Linux (KDE Neon)
| Autor: Raphael Patzelt
| Beschreibung:
|   Programm wie 08_Lotto, allerdings werden die Zufallszahlen in einem Array abgespeichert und mittels Array Eigenschaften und Array
|   Methoden sortiert bzw. die Zusatzzahl aus dem Array herausgenommen
=======================================*/
using System;
using System.Collections;
using System.Linq;
using static System.Console;

namespace Lotto_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int iZusatzzahl;
            int[] iALotto = new int[7]; //Datenfeld vom Typ Int mit 7 Zeilen und dem Namen iALotto deklariert und instanziert
            Random rnd = new Random(); //Objekt der Random Klasse mit dem Namen rnd
            bool bCorrectAnswer = true, bContinueProgram = true;
            while (bContinueProgram)
            {
                Array.Clear(iALotto, 0, 7);
                Array.Resize(ref iALotto, 7);
            for(int i = 0; i < 7; i++)      //Schleife zur erzeugung der Zufallszahlen
            {
                iALotto[i] = rnd.Next(1, 45);   //Über den Punkt Operator kann auf die Methoden (Next) des Objektes rnd Zugregriffen werden
                for(int j = 0; j < i; j++)      //Schleife die verhindert dass Zahlen doppelt vorkommen
                {
                    if(iALotto[i] == iALotto[j])
                    {
                        i--;
                        break;
                    }
                }
                //WriteLine($"Lottozahl {i + 1}: {iALotto[i]}");
            }
            
            foreach (var item in iALotto)
            {
                WriteLine($"\tLottozahl: {item}");
            }

            iZusatzzahl = iALotto[iALotto.Length - 1];      //Length - Array Eigenschaft, liefert die Länge des Arrays
            Array.Resize(ref iALotto, 6);       //Resize - Array Methode, Verändert die Länge des Datenfeldes
            Array.Sort(iALotto);        //Sort - Array Methode, Sortiert die Werte im Datenfeld in aufsteigender Reihenfolge

            WriteLine($"\n\t\tLottozahlen + Zusatzzahl\n");

            foreach (var item in iALotto)       //Für jeden Wert im Array iALotto wird die Schleife einmal ausgeführt. Pro Schleifendurchlauf
            // wird ein Wert aus iALotto in der Variable item abgespeichert der in der Schleife verwendet werden kann
            // var - Schlüsselwort, passt den Datentyp von Item an iALotto an
            {
                WriteLine($"\tLottozahl: {item}");
            }
            WriteLine($"\tZusatzzahl: {iZusatzzahl}");

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
