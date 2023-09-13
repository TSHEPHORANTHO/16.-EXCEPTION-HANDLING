using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.EXCEPTION_HANDLING
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {
                //Int=(ToInt32)/Decimal=(ToDecimal)/Double=(ToDouble)
                Console.WriteLine("Enter First Number ");
                Double Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Double Num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Your first Number divided by Second Number =R");
                Console.WriteLine(Num1 / Num2);
            }
            catch
            {
                Console.Write("Error!!! Code 10110");

            }
            //Print
            Console.ReadLine();



        }
    }
}
