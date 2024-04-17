namespace _240322_Use_Lib_Resistor_Inheritance
{
    internal class Program
    {
        private enum CalcType
        {
            SERIES,
            PARALLEL
        }
        static void Main(string[] args)
        {
            while(!false)
            {
                CalcType calcType;
                string? input;
                double voltage;
                double[] resistorValues;
                _240322_Lib_Resistor_Inheritance.Calculate calc = new _240322_Lib_Resistor_Inheritance.Calculate();

                while (!false)
                {
                    Console.WriteLine("Enter the type and number of resistors you want to calculate" +
                                      "(i.e. 'p-5' or 's-3'):");

                    input = Console.ReadLine();

                    if (input == null)
                        break;

                    input = input.ToLower();

                    if (input.Length < 3 || input[1] != '-')
                    {
                        Console.WriteLine("Invalid input!\n");
                        continue;
                    }
                    switch(input[0])
                    {
                        case 'p':
                            calcType = CalcType.PARALLEL;
                            break;
                        case 's':
                            calcType = CalcType.SERIES;
                            break;

                        default:
                            Console.WriteLine("Invalid input!\n");
                            continue;
                    }

                    if (!int.TryParse(input.Substring(2), out int resistorNumber))
                    {
                        Console.WriteLine("Invalid input!\n");
                        continue;
                    }

                    resistorValues = new double[resistorNumber];

                    for (int i = 0; i < resistorNumber; i++)
                    {
                        double resistorValue;
                        Console.WriteLine($"Enter the value for resistor #{i+1}: ");
                        while(!double.TryParse(Console.ReadLine(), null, out resistorValue))
                        {
                            Console.WriteLine("Invalid input! Please try again: ");
                        }
                        resistorValues[i] = resistorValue;
                    }

                    Console.WriteLine("Enter the applied Voltage: ");
                    while(!double.TryParse(Console.ReadLine(), out voltage))
                    {
                        Console.WriteLine("Invalid input! Try again: ");
                    }

                    calc.ResistorValues = resistorValues;
                    calc.Voltage = voltage;

                    switch(calcType)
                    {
                        case CalcType.SERIES:
                            var resultS = calc.CalculateSerialVoltage();
                            Console.WriteLine($"\nSerial Resistance is: {resultS.sumR:0.00}Ω\n" +
                                $"Current is: {resultS.sumI:0.00}A\n");
                            for(int i = 0; i < resultS.singleV.Length; i++)
                            {
                                Console.WriteLine($"Voltage drop at resistor {i+1} is: {resultS.singleV[i]}V");
                            }
                            break;
                        case CalcType.PARALLEL:
                            var resultP = calc.CalculateParallelCurrent();
                            Console.WriteLine($"\nSerial Resistance is: {resultP.sumR:0.00}Ω\n" +
                                $"Current is: {resultP.sumI:0.00}A\n");
                            for (int i = 0; i < resultP.singleI.Length; i++)
                            {
                                Console.WriteLine($"Current through resistor {i + 1} is: {resultP.singleI[i]:0.00}A");
                            }
                            break;
                    }
                }
            }
        }
    }
}
