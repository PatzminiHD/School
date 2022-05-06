using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Methoden_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            double dWert1, dWert2, dWert3, dWert4;

            Console.WriteLine("Geben Sie Wert 1 ein:");
            dWert1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie Wert 2 ein:");
            dWert2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Das Ergebnis der Addition:{Add(dWert1, dWert2)}");

            dWert3 = dWert1;
            dWert4 = dWert2;

            Div(ref dWert3, ref dWert4);
            Console.WriteLine($"Das Ergebnis der Division: {dWert3}");

            Console.WriteLine($"Das Ergebnis der Addition:{Add(dWert1, dWert2)}");

            Console.Read();

            //====================lokale Methode====================
            //Gilt nur in der static void main - Methode!!

            double Add(double input1, double input2)
            {
                return input1 + input2;
            }

            //====================lokale void Methode====================
            //liefert Wert in der ref Variable zurück - Parameter oder Übergabeparameter müssen ref Variablen sein
            //Übergabe Reihenfolge bestimmt in welchen Parameter das Ergebnis zurückgeliefert wird

            void Div(ref double Eingabe1, ref double Eingabe2)
            {
                Eingabe1 = Eingabe1 / Eingabe2;
            }
        }


    }
}
