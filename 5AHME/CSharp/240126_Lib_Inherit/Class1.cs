using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lib_Vererbung
{
    public class Slope
    {
        /*=====================
         * Eigenschaften 
         ====================*/
        //gekapselten Variablen der Klassenbibliothek
        /// <summary>
        /// Propertys of the library
        /// </summary>
        private double _dx1;
        private double _dy1;
        private double _dx2;
        private double _dy2;



        /*=====================
         * Eigenschaftsmethoden
         ====================*/
        //organisieren den Zugriff aus die gekapselten Variablen
        /// <summary>
        /// X1 - left interpolation point
        /// </summary>
        public double X1 { get => _dx1; set => _dx1 = value; }
        //get übergibt den Inhalt von _dx1 an die Methode => Methode übergibt Inhalt der Var. an das aufrufende Prg.
        //set speichert den Wert (value) in _dx1 ab => Methode ändert den Inhalt der Var. in der Lib.

        /// <summary>
        /// Y1 - left interpolation point
        /// </summary>
        public double Y1
        {
            get { return _dy1; }
            set
            {
                if (value == 0)
                    throw new Exception("Y1 Koordinat gleich 0");
                else
                    _dy1 = value;
            }
        }
        /// <summary>
        /// X2 - right interpolation point
        /// </summary>
        public double X2
        {
            get { return _dx2; }
            set
            {
                if (_dx1 != value)
                    _dx2 = value;
                else
                    throw new Exception("X1 = X2 => slope infinit!");
            }
        }
        /// <summary>
        /// Y2 - right interpolation point
        /// </summary>
        public double Y2 { get => _dy2; set => _dy2 = value; }



        /*=====================
         * Konstruktoren 
         ====================*/
        /// <summary>
        /// Standardkonstruktor without parameter
        /// </summary>
        public Slope()
        { }

        /// <summary>
        /// Specific Konstructor with parameters
        /// </summary>
        /// <param name="x_Pkt1">X1 - left point</param>
        /// <param name="y_Pkt1">Y1 - left point</param>
        /// <param name="x_Pkt2">X2 - right point</param>
        /// <param name="y_Pkt2">Y2 - right point</param>
        /// <param name="x_Interp">X - interpolate</param>
        public Slope(double x_Pkt1, double y_Pkt1, double x_Pkt2, double y_Pkt2)
        {
            X1 = x_Pkt1;
            Y1 = y_Pkt1;
            X2 = x_Pkt2;
            Y2 = y_Pkt2;

        }

        /*=====================
         * Methoden
         ====================*/
        /// <summary>
        /// calculates the slope of a straight between 2 points
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double slope()
        {
            return ((_dy2 - _dy1) / (_dx2 - _dx1));

        }
        /// <summary>
        /// calculates the axis intercept of a straight line
        /// </summary>
        /// <returns></returns>
        public double intercept()
        {
            return (_dy1 - _dx1 * slope());
        }

    }

    public class Interpolate : Slope
    {
        /*=====================
         * Eigenschaften 
         ====================*/
        /// <summary>
        /// Eigenschaften / Daten der Klasse
        /// </summary>
        private double _dx;

        /*=====================
         * Eigenschaftsmethoden 
         ====================*/
        /// <summary>
        /// X - point to be interpolated
        /// </summary>
        public double X { get => _dx; set => _dx = value; }

        /*=====================
         * Konstruktoren 
         ====================*/
        /// <summary>
        /// Standardkonstruktor Interpolate
        /// </summary>
        public Interpolate()
        { }

        /*=====================
         * Methoden 
         ====================*/

        /// <summary>
        /// interpolates the y value for given x
        /// </summary>
        /// <returns></returns>
        public double Y()
        {
            return (slope() * _dx + intercept());
        }

    }
}
