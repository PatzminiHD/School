using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231020_Lib_Linear_Interpolation
{
    /// <summary>
    /// This Lib can be used for linear interpolation between two given points
    /// </summary>
    public class Interpolation
    {
        //==========
        //Properties
        //==========
        //Encapsulated variables of the Class Library

        /// <summary>
        /// Properties of the library
        /// </summary>
        private double _dx1;
        private double _dy1;
        private double _dx2;
        private double _dy2;
        private double _dx;
        

        //================
        //Property Methods
        //================
        //Organise access to encapsulated variables

        /// <summary>
        /// X1 - left interpolation point
        /// </summary>
        public double X1 { get => _dx1; set => _dx1 = value; }
        //get gets the value of _dx1 to the Method
        //  => Method returns value of the variable to the calling program
        //set saves the give value to _dx1
        //  => Method changes the value of the private variable

        /// <summary>
        /// Y1 - left interpolation point
        /// </summary>
        public double Y1
        {
            get { return _dy1; }
            set
            {
                if(value == 0)
                    throw new ArgumentOutOfRangeException("Y1 cannot be zero");

                _dy1 = value;
            }
        }

        /// <summary>
        /// X2 - right interpolation point
        /// </summary>
        public double X2 { get => _dx2; set => _dx2 = value; }

        /// <summary>
        /// Y2 - right interpolation point
        /// </summary>
        public double Y2 { get => _dy2; set => _dy2 = value; }
        /// <summary>
        /// X - point to be interpolated
        /// </summary>
        public double X { get => _dx; set => _dx = value; }


        //===========
        //Contructors
        //===========

        /// <summary>
        /// Default Constructor without parameters
        /// </summary>
        public Interpolation() { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x"></param>
        public Interpolation(double x1, double y1, double x2, double y2, double x)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.X = x;
        }

        //=======
        //Methods
        //=======

        /// <summary>
        /// Calculate the Slope for the given points
        /// </summary>
        /// <returns>The slope as a double</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double Slope()
        {
            //If x1 and x2 are equal
            if (this._dx1 == this._dx2)
                //Throw 
                throw new ArgumentOutOfRangeException("X1 is equal to X2");

            //If x is not between x1 and x2
            if (this._dx1 > this._dx || this._dx > this._dx2)
            {
                //Swap point 1 and point 2
                double tmp = this._dx1;
                this._dx1 = this._dx2;
                this._dx2 = tmp;

                tmp = this._dy1;
                this._dy1 = this._dy2;
                this._dy2 = tmp;

                //Is x is still not between swapped x1 and x2
                if (this._dx1 > this._dx || this._dx > this._dx2)
                    //Throw exception
                    throw new ArgumentOutOfRangeException("X does not lie between X1 and X2");
            }

            return (this._dy2 - this._dy1) / (this._dx2 - this._dx1);
        }

        /// <summary>
        /// Calculate the offset of the interpolated line of the given points
        /// </summary>
        /// <returns>The offset as a double</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double Intersect()
        {
            if (this._dx1 == this._dx2)
                throw new ArgumentOutOfRangeException("X1 is equal to X2");

            //If x is not between x1 and x2
            if (this._dx1 > this._dx || this._dx > this._dx2)
            {
                //Swap point 1 and point 2
                double tmp = this._dx1;
                this._dx1 = this._dx2;
                this._dx2 = tmp;

                tmp = this._dy1;
                this._dy1 = this._dy2;
                this._dy2 = tmp;

                //Is x is still not between swapped x1 and x2
                if (this._dx1 > this._dx || this._dx > this._dx2)
                    //Throw exception
                    throw new ArgumentOutOfRangeException("X does not lie between X1 and X2");
            }

            return this._dy1 - (Slope() * this._dx1);
        }

        /// <summary>
        /// Calculate the Y value for the given points and x value
        /// </summary>
        /// <returns>The Y value as a double</returns>
        public double Y()
        {
            return Slope() * this._dx + Intersect();
        }
    }
}
