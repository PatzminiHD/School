//*********************************************************************************************
//  Project:    _231020_Linear_Interpolation_with_Lib
//  Namespace:  _231020_Linear_Interpolation_with_Lib
//  Path:       E:\School\AIIT\5AHME\CSharp\
//  File:       Program.cs
// --------------------------------------------------------------------------------------------
//  Date:       10/20/2023 1:17:15 PM
//  Username:	PatzminiHD
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
//  10/20/2023 1:17:15 PM                      <PatzminiHD>                Creation of project ....
//*********************************************************************************************

// ----------------------------- using Directives to include different namespaces -------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _231020_Lib_Linear_Interpolation;

//  -------------------------------------------- START -----------------------------------------

namespace _231020_Linear_Interpolation_with_Lib
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
            Console.Title = "_231020_Linear_Interpolation_with_Lib";
            Console.ForegroundColor = ConsoleColor.Green;

            //	-----------------------------------------------
            //	Definition of variables & data structures
            //	-----------------------------------------------

            string sX1, sY1, sX2, sY2, sX;
            double dX1, dY1, dX2, dY2;
            double dX;
            string sCancel;
            Interpolation Calculate = new Interpolation();


            //	-----------------------------------------------
            //	Instructions & Procedures
            //	-----------------------------------------------

            while (true)
            {
                Console.Clear();
                Console.Write("Input the X Value of the lower Point: ");
                sX1 = Console.ReadLine();
                Console.Write("Input the Y Value of the lower Point: ");
                sY1 = Console.ReadLine();
                Console.Write("Input the X Value of the upper Point: ");
                sX2 = Console.ReadLine();
                Console.Write("Input the Y Value of the upper Point: ");
                sY2 = Console.ReadLine();
                Console.Write("Input the X Value to interpolate: ");
                sX = Console.ReadLine();

                if(double.TryParse(sX1, out dX1) && 
                   double.TryParse(sX2, out dX2) &&
                   double.TryParse(sY1, out dY1) &&
                   double.TryParse(sY2, out dY2) &&
                   double.TryParse(sX,  out dX))
                {
                    try
                    {
                        Calculate.X1 = dX1;
                        Calculate.Y1 = dY1;
                        Calculate.X2 = dX2;
                        Calculate.Y2 = dY2;
                        Calculate.X = dX;

                        Console.WriteLine($"\n\tSlope k :                 {Calculate.Slope():F2}" +
                                          $"\n\tIntersect d:              {Calculate.Intersect():F2}" +
                                          $"\n\tInterpolated Point (X/Y): ({dX:F2}/{Calculate.Y():F2})");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("One of the inputs was not valid!");
                }

                do
                {
                    //	-----------------------------------------------
                    //	Programm-Ende
                    //	-----------------------------------------------
                    Console.WriteLine("\n\n\tExit Program? (Y/N)\n\n");
                    sCancel = Console.ReadLine().ToUpper();
                }
                while (sCancel != "Y" && sCancel != "N");
                
                if (sCancel == "Y")
                    break;
            }

        }   // --> end of main	


    }   // --> end of class


}   //  --> end of namespace

//  -------------------------------------------- END  -----------------------------------------
