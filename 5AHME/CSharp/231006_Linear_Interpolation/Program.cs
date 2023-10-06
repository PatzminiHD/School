//*********************************************************************************************
//  Project:    _231006_Linear_Interpolation
//  Namespace:  _231006_Linear_Interpolation
//  Path:       E:\School\AIIT\5AHME\CSharp\
//  File:       Program.cs
// --------------------------------------------------------------------------------------------
//  Date:       10/6/2023 12:15:14 PM
//  Username:	OliverBleen
//  Developer:  <PatzminiHD>
// --------------------------------------------------------------------------------------------
//  Machine:	DESKTOP-UIJDDHM
//  System-OS:  WIN11-Enterprise
//  IDE:        MS Visual Studio Community 2022
// --------------------------------------------------------------------------------------------
//  
// --------------------------------------------------------------------------------------------
//  Description of Task:
//	
//              				
//				
// 
// --------------------------------------------------------------------------------------------
//  Date:                       Author:                     Reason for Change
//  10/6/2023 12:15:14 PM       <PatzminiHD>                Creation of project ....
//*********************************************************************************************

// ----------------------------- using Directives to include different namespaces -------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//  -------------------------------------------- START -----------------------------------------

namespace _231006_Linear_Interpolation
{
    internal class Program
    {
        // --------------------------------------------------------
        //	Hauptprogramm:   Main()
        // --------------------------------------------------------		

        static void Main(string[] args)
        {

            //	-----------------------------------------------
            //	Setups
            //	-----------------------------------------------
            Console.Title = "_231006_Linear_Interpolation";
            Console.ForegroundColor = ConsoleColor.Green;

            //	-----------------------------------------------
            //	Definition of variables & data structures
            //	-----------------------------------------------

            (double x, double y) dPnt1;
            (double x, double y) dPnt2;
            (double x, double y) dPntCalc;

            string x1, y1, x2, y2, x;


            //	-----------------------------------------------
            //	Instructions & Procedures
            //	-----------------------------------------------


            Console.WriteLine(-2 < -1);
            Console.WriteLine(-2 < 5);
            Console.WriteLine(2 < -5);
            Console.Write("Input value x1: ");
            x1 = Console.ReadLine();
            Console.Write("Input value y1: ");
            y1 = Console.ReadLine();
            Console.Write("Input value x2: ");
            x2 = Console.ReadLine();
            Console.Write("Input value y2: ");
            y2 = Console.ReadLine();
            Console.Write("Input value x: ");
            x = Console.ReadLine();

            if(double.TryParse(x1, out dPnt1.x) &&
               double.TryParse(y1, out dPnt1.y) && 
               double.TryParse(x2, out dPnt2.x) && 
               double.TryParse(y2, out dPnt2.y) &&
               double.TryParse(x,  out dPntCalc.x))
            {
                try
                {
                    dPntCalc.y = Line(dPnt1, dPnt2, dPntCalc.x).k * dPntCalc.x + Line(dPnt1, dPnt2, dPntCalc.x).d;
                    Console.WriteLine($"\n\tSlope is:       {Line(dPnt1, dPnt2, dPntCalc.x).k:F3}");
                    Console.WriteLine($"\n\tAxis offset is: {Line(dPnt1, dPnt2, dPntCalc.x).d:F3}");
                    Console.WriteLine($"\n\tInput Point is: ({dPntCalc.x}/{dPntCalc.y})");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.ToString());
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else
            {
                Console.WriteLine("ERROR: One of the inputs could not be parsed to double:\n");
                Console.WriteLine($"\tInput x1: {x1}");
                Console.WriteLine($"\tInput y1: {y1}");
                Console.WriteLine($"\tInput x2: {x2}");
                Console.WriteLine($"\tInput y2: {y2}");
                Console.WriteLine($"\tInput x:  {x}");
            }

            //	-----------------------------------------------
            //	Programm-Ende
            //	-----------------------------------------------
            Console.WriteLine("\n\n\tENTER => Programm-Ende\n\n");
            Console.Read();

        }   // --> end of main


        private static (double k, double d) Line((double x, double y) dPnt1, (double x, double y) dPnt2, double x)
        {
            double dSlope, dAxisOffset;

            if(dPnt1.x == dPnt2.x)
            {
                //Throw Exception
                throw new ArgumentException("x1 is equal to x2");
            }
            if(dPnt1.x > x || x > dPnt2.x)
            {
                //Throw Exception
                throw new ArgumentOutOfRangeException("x does not lie between x1 and x2");
            }

            dSlope = (dPnt2.y - dPnt1.y) / (dPnt2.x - dPnt1.x);
            dAxisOffset = dPnt1.y - (dSlope * dPnt1.x);

            return (dSlope, dAxisOffset);
        }


    }   // --> end of class


}   //  --> end of namespace

//  -------------------------------------------- END  -----------------------------------------
