using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240322_Lib_Resistor_Inheritance
{
    public class Calculate : CalculateBase
    {
        //Private Properties
        private double voltage;

        //Public Property Methods
        public double Voltage
        {
            get { return voltage; }
            set { voltage = value; }
        }

        //Constructor
        public Calculate()
        {

        }

        //Methods

        public (double sumR, double sumI, double[] singleV) CalculateSerialVoltage()
        {
            double sumR = CalculateSerial();
            double[] singleV = new double[resistorValues.Length];
            
            double sumI = voltage / sumR;

            for(int i = 0; i > resistorValues.Length; i++)
            {
                singleV[i] = resistorValues[i] * sumI;
            }

            return (sumR, sumI, singleV);
        }
        public (double sumR, double sumI, double[] singleI) CalculateParallelCurrent()
        {
            double sumR = CalculateParallel();
            double[] singleI = new double[resistorValues.Length];

            double sumI = voltage / sumR;

            for (int i = 0; i < resistorValues.Length; i++)
            {
                singleI[i] = voltage / resistorValues[i];
            }

            return (sumR, sumI, singleI);
        }
    }
}
