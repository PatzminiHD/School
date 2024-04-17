using System.ComponentModel.Design;

namespace _240322_Lib_Resistor_Inheritance
{
    public abstract class CalculateBase
    {
        //Private Properties
        private protected double[]? resistorValues;

        //Public Property Methods
        public double[]? ResistorValues {
            get { return resistorValues; }
            set { resistorValues = value; }
        }

        //Constructor
        public CalculateBase()
        {

        }

        //Methods
        public double CalculateSerial()
        {
            if (resistorValues == null)
                throw new ArgumentException("Resistors have not been set yet!");

            return resistorValues.Sum();
        }

        public double CalculateParallel()
        {
            if (resistorValues == null)
                throw new ArgumentException("Resistors have not been set yet!");

            if (resistorValues.Contains(0))
            {
                throw new ArgumentException("Resistor value can not be zero for parallel");
            }

            double helper = 0;
            foreach(double value in resistorValues)
            {
                helper += 1 / value;
            }

            return 1 / helper;
        }
    }
}
