using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számológép
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double szam1 = 0;
                double szam2 = 0;
                double eredmeny = 0;

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Számológép");
                Console.WriteLine("-----------------------------");

                Console.Write("Adja meg az első számot:  ");
                szam1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Adja meg a második számot:  ");
                szam2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Adja meg a műveletet:  ");
                Console.WriteLine("\t+ Összeadás");
                Console.WriteLine("\t- Kivonás");
                Console.WriteLine("\t* Szorzás");
                Console.WriteLine("\t/ Osztás");
                Console.Write("Válasszon egy opciót:  ");


                switch (Console.ReadLine())
                {

                    case "+":
                        eredmeny = szam1 + szam2;
                        Console.WriteLine("Végösszeg:");
                        Console.WriteLine($"{szam1}+{szam2} =" + eredmeny);
                        break;

                    case "-":
                        eredmeny = szam1 - szam2;
                        Console.WriteLine("Végösszeg:");
                        Console.WriteLine($"{szam1}-{szam2} =" + eredmeny);
                        break;

                    case "*":
                        eredmeny = szam1 * szam2;
                        Console.WriteLine("Végösszeg:");
                        Console.WriteLine($"{szam1}*{szam2} =" + eredmeny);
                        break;

                    case "/":
                        eredmeny = szam1 / szam2;
                        Console.WriteLine("Végösszeg:");
                        Console.WriteLine($"{szam1}/{szam2} =" + eredmeny);
                        break;

                    default:
                        Console.WriteLine("Nem megfelelő adat");
                        break;



                }
                Console.WriteLine("Szeretné folytatni?  (I=igen  ,  N=nem):  ");
            } while (Console.ReadLine().ToUpper() == "I");

            Console.WriteLine("Viszlát!");
            System.Environment.Exit(0);
            Console.ReadKey();
        }
    }
}
