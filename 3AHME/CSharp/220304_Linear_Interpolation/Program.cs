/* Console Application: ver. 01
 * Name: Linear_Interpolation
 * OS: Windows 10
 * Author: PatzminiHD  Date: 11.03.2022
 * Description: Interpolates the Y - Value of a point when given two other points of
 * a straight line. To read the Values a Method is used. With try - catch - finally and
 * throw we catch runtime errors.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _220304_Linear_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dX1, dY1, dX2, dY2, dX;
            string sCancel = "N";
            while(sCancel == "N")
            {
                Clear();
                //=========|try-catch-finally|==========
                //Catch possible runtime errors
                try
                {
                    WriteLine("This program interpolates from the left and right point an intermediate point!\n");

                    //Input of the two adjacent point coords
                    dX1 = Input("left X");
                    dY1 = Input("left Y");
                    dX2 = Input("right X");
                    dY2 = Input("right Y");


                    dX = Input("intermediate X");

                    WriteLine($"\nThe Interpolated Point is: ({dX}/{Interpolation.InterpolatetValue(dX1, dY1, dX2, dY2, dX)})");
                }
                //Catch runtime error -> The hierarchy of Exceptions has to be accounted for
                catch(DivideByZeroException error)
                {
                    WriteLine(error.Message);
                }
                catch(Exception error)
                {
                    WriteLine(error.Message);
                }
                //Runs always after try or catch
                finally
                {
                    WriteLine("Do you want to quit the Application? (Y/N)");
                    sCancel = ReadLine().ToUpper();
                    while(sCancel != "N" && sCancel != "Y")
                    {
                        WriteLine("Invalid Input. Please try again (Y/N)");
                        sCancel = ReadLine().ToUpper();
                    }
                }
            }
        }

        //==========|Input Method|==========
        //Read Value, Convert and throw Exception
        static private double Input(string sText)
        {
            WriteLine($"\tInput of the {sText} Coordinate:");
            if (double.TryParse(ReadLine(), out double dOut)) return dOut;
            throw new Exception($"Input of {sText} - Coordinate cannot be converted to double");
        }
    }
    static class Interpolation
    {
        //==========|Slope|==========
        static public double Slope(double leftX, double leftY, double rightX, double rightY)
        {
            //When there is only one thing to be done after an "if" the "{}" can be left out
            //return in the TRUE branch, throw in the FALSE branch
            if (rightX - leftX != 0)
                return (rightY - leftY) / (rightX - leftX);
            throw new DivideByZeroException("Slope infinite");
        }
        //==========|Axis Offset|==========
        static public double AxisOffset(double leftX, double leftY, double rightX, double rightY)
        {
            return leftY - leftX * Slope(leftX, leftY, rightX, rightY);
        }
        //==========|Interpolation Y - Value|==========
        //Calculation by calling the other Methods
        static public double InterpolatetValue(double leftX, double leftY, double rightX, double rightY, double XValue)
        {
            return XValue * Slope(leftX, leftY, rightX, rightY) + AxisOffset(leftX, leftY, rightX, rightY);
        }
    }
}
