using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumber
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int num;
            int Solut;

            Console.WriteLine("Insert Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Solut = num % 2;

            if (Solut == 1)
            {
                Console.WriteLine("Result = " + num.ToString() + " was Odd Number");
            }
            else
            {
                Console.WriteLine("Result = " + num.ToString() + " was Even Number");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
