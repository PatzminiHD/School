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

        //=======
        //Methods
        //=======
    }
}
