using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _211223_AIIT_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Das Ergebnis Lautet: {Berechne.Moment(Input.GetInput("Geben Sie die Kraft ein:"), Input.GetInput("Geben Sie den Abstand ein:"))}");
            ReadKey();
        }
    }
    class Berechne
    {
        public static double Moment(double dInput1, double dInput2)
        {
            return dInput1 * dInput2;
        }

    }

    class Input
    {
        public static double GetInput(string sQuestion)
        {
            WriteLine(sQuestion);
            double.TryParse(ReadLine(), out double dInput);
            return dInput;
        }
    }
}
