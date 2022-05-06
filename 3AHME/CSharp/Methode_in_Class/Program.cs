using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Methode_in_Class
{
    class Program
    {
        static void Main()
        {
            /*Console.WriteLine("Geben Sie Wert 1 ein:");
            dWert1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie Wert 2 ein:");
            dWert2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Das Ergebnis der Addition:{Add(dWert1, dWert2)}");*/


            //Objekt der Klasse Program, um auf die Methode Multi zugreifen zu können
            //<Klassenname> <Objektname> = SW <Konstruktor(Parameter)>;
            Program Berechne = new Program();
            //Mathematik Mathe = new Mathematik();

            double dErgebnis = Division(9.9, 3.3);
            WriteLine($"\nErgebnis der Division: {dErgebnis}");

            WriteLine($"\nErgebnis der Integer-Division: {Division(9, 3)}");

            WriteLine($"\nErgebnis der Multiplikation: {Berechne.Multi(9, 3)}");


            //Zugriff auf die Modulo Methode in der statischen Klasse Mathematik
            //Da kein Objekt erstellt wird, erfolgt der aufruf über <Klassenname>.<Methodenname>
            WriteLine($"\nErgebnis der integer Modulo-Operation: {Mathematik.Modulo(9, 4)}");

            WriteLine($"\nErgebnis der double Modulo-Operation: {Mathematik.Modulo(9.7, 2.3)}");

            ReadKey();
        }

        //==========|Statische Methode|==========
        //private - gilt nur in der Klasse Program
        //static - mit <Klassenname.Methodenname> aufrufbar (Kein Objekt nötig)
        private static double Division(double input1, double input2)
        {
            return input1 / input2;
        }
       

        //==========|Erste Überladung der Methode Division|==========
        //Überladene Methoden müssen sich in Datentyp und/oder Parameterliste unterscheiden
        //Beim aufruf wird entsprechend der übergebenen Parameter die richtige Methode automatisch ausgewählt
        private static int Division(int input1, int input2)
        {
            return input1 / input2;
        }

        //==========|Öffentliche Methode|=========
        //public - Öffentliche Methode - Namespace übergreifend
        //Es muss ein Objekt erstellt werden, dass auf die Methode zugegriffen werden kann
        public double Multi(double input1, double input2)
        {
            return input1 * input2;
        }
    }

    //==========|Statische Klasse|==========
    //static - Es muss kein Objekt erstellt werden, um auf die Klasse zuzugreifen
    static class Mathematik
    {
        public static int Modulo(int input1, int input2)
        {
            return input1 % input2;
        }

        public static double Modulo(double input1, double input2)
        {
            return input1 % input2;
        }
    }
    //Statische Klassen dürfen nur statische Methoden enthalten!
}
