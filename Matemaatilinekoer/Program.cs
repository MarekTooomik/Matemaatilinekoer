using System;

namespace MatemaatilineKoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemaatiline Koer");

            Console.Write("Palun sisesta esimene arv: ");
            float firstNr = float.Parse(Console.ReadLine());

            Console.Write("Palun sisesta tehe: ");
            string operation = Console.ReadLine();

            Console.Write("Palun sisesta teine arv: ");
            float secondNr = float.Parse(Console.ReadLine());

            try
            {
                switch (operation)
                {
                    case "+":
                        float resultAdd = firstNr + secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd);
                        break;
                    case "-":
                        float resultSubtract = firstNr - secondNr;
                        Console.WriteLine("Kahe numbri lahutamise on vastus: " + resultSubtract);
                        break;
                    case "*":
                        float resultMultiply = firstNr * secondNr;
                        Console.WriteLine("Kahe numbri korrutamise on vastus: " + resultMultiply);
                        break;
                    case "/":
                        if (secondNr == 0)
                        {
                            Console.WriteLine("Nulliga ei saa jagada!");
                        }
                        else
                        {
                            float resultDivide = firstNr / secondNr;
                            Console.WriteLine("Kahe numbri jagamise on vastus: " + resultDivide);
                        }
                        break;
                    default:
                        Console.WriteLine("Vale tehte tüüp!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Vale numbri formaat. Kas sa ei saa siis aru.");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
            }
        }
    }
}