using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _220127_Übersetzung_void
{
    class Program
    {
        static void Main(string[] args)
        {
            string sAbbruch = "N";
            int iEingabe1, iEingabe2;
            double dErgebnis = 0;
            Berechnungen berechnungen = new Berechnungen();
            while (sAbbruch == "N")
            {
                WriteLine("Geben Sie die Zähnezahl des Antriebs ein:");
                while (!false)
                {
                    if (int.TryParse(ReadLine(), out iEingabe1))
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("Ungültige Eingabe! Bitte versuchen Sie es erneut:");
                    }
                }


                WriteLine("Geben Sie die Zähnezahl des Abtriebs ein:");
                while (!false)
                {
                    if (int.TryParse(ReadLine(), out iEingabe2))
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("Ungültige Eingabe! Bitte versuchen Sie es erneut:");
                    }
                }
                berechnungen.Übersetzung(iEingabe1, iEingabe2, out dErgebnis);
                
                if(dErgebnis > 1)
                {
                    WriteLine($"Die Untersetzung beträgt {dErgebnis}");
                }
                else
                {
                    WriteLine($"Die Übersetzung beträgt {dErgebnis}");
                }

                WriteLine("Wollen sie dass Programm beenden? (J/N): ");
                sAbbruch = ReadLine().ToUpper();
                while (sAbbruch != "N" & sAbbruch != "J")
                {
                    WriteLine("Ungültige Eingabe. Wollen sie dass Programm beenden? (J/N): ");
                    sAbbruch = ReadLine().ToUpper();
                }
            }
        }
    }
    public class Berechnungen
    {
        public void Übersetzung(double iInput1, int iInput2, out double dErgebnis)
        {
            dErgebnis = iInput2 / iInput1;
        }
    }
}
