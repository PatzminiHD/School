/*=======================================
| Konsolenanwendung Version: 01
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
            try
            {
                Mathematik mathe = new Mathematik();
                Console.WriteLine(mathe.Division(0, 0));
                Console.Read();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
    class Mathematik
    {
        public double Division(double dDividend, double dDivisor)
        {
            if (dDivisor != 0 && dDividend != 0)
            {
                return dDividend / dDivisor;
            }
            else
            {
                if(dDividend == 0)
                {
                    //Laufzeitfehler
                    throw new DivideByZeroException();
                }
                else
                {
                    //RuntimeError
                    throw new Exception("DividingSomethingByZeroIsSenseless");
                }
            }
        }
    }
}
