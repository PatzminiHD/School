/*=======================================
| Konsolenanwendung Version: 02
| Programmname: try_catch_throw
| Datum: 03.02.2022
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

namespace _220203_try_catch_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            string sAbbruch = "N";
            double dZähler, dNenner;
            while (sAbbruch == "N")
            {
                Console.Clear();
                try
                {
                    dZähler = Input("Zähler");
                    dNenner = Input("Nenner");
                    Console.WriteLine($"{dZähler}/{dNenner} =\n\t{Mathematik.Division(dZähler, dNenner)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e);
                }


                Console.WriteLine("\n\nWollen Sie das Programm beenden? (J/N)");
                sAbbruch = Console.ReadLine().ToUpper();
                while (sAbbruch != "N" && sAbbruch != "J")
                {
                    Console.WriteLine("Ungültige Eingabe, nur 'J' oder 'N' erlaubt:");
                    sAbbruch = Console.ReadLine().ToUpper();
                }
            }
        }
        static private double Input(string sInput)
        {
            Console.WriteLine($"Eingabe {sInput}:");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out double dOutput))
                {
                    throw new System.Exception($"Eingabe {sInput} nicht gültig!");
                }
                else
                {
                    return dOutput;
                }
            }
        }
    }
    static class Mathematik
    {
        public static double Division(double dDividend, double dDivisor)
        {
            if (dDividend != 0)
            {
                if (dDividend <= 1000)
                {
                    if (dDivisor != 0)
                    {
                        return dDividend / dDivisor;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Dividend darf nicht > 1000 sein");
                }
            }
            else
            {
                throw new Exception("");
            }
        }
    }
}
