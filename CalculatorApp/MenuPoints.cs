using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public static class MenuPoints
    {
        public static void Add ()
        {
            string Number;
            string[] tmp;
            List <double> nmb = new List<double>();
            double v;
            Console.WriteLine("Please enter the numbers you wish to add");
            Console.WriteLine("like this x + y");
            Number = Console.ReadLine();
            tmp = Number.Split('+');
            for (int i = 0; i < tmp.Length; i++)
            {
                string holder = tmp[i];
                holder = holder.Trim();

                if (double.TryParse(holder, out v))
                {
                    nmb.Add(v);
                }
                else
                {
                    Console.WriteLine("You can only add numbers, fucktard");
                    return;
                }

                double sum = 0; 
                for (int j = 0; j < nmb.Count; j++)
                {
                    sum = CalculatorLibrary.Calculator.Add(sum, nmb[j]);
                }
                Console.WriteLine("It adds up to: " + sum);
            }

        }
        public static void Divide()
        {
            string Numbers;
            string[] tmp;
            List<double> nmb = new List<double>();
            double v;
            Console.WriteLine("Please enter the numbers you wish to divide with the number you wish to divide it by");
            Console.WriteLine("Like this x/y");
            Numbers = Console.ReadLine();
            tmp = Numbers.Split('/');

            for (int i = 0; i < tmp.Length; i++)
            {
                string holder = tmp[i];
                holder = holder.Trim();

                if (double.TryParse(holder, out v))
                {
                    nmb.Add(v);
                }
                else
                {
                    Console.WriteLine("You can only divide numbers, fucktard");
                    return;
                }

                double sum = nmb[0];
                for (int k = 1; k < nmb.Count; k++)
                {
                    sum = CalculatorLibrary.Calculator.Divide(sum, nmb[k]);
                }
                Console.WriteLine("The numbers divide is: " + sum);
            }
        }
    }
}
