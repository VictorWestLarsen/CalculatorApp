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

        public static void Subtract()
        {
            string numbers;
            string[] subArray;
            string trimmed;
            double num;
            double sum;
            List<double> numList = new List<double>();
            Console.WriteLine("Please enter the numbers you wish to subtract");
            Console.WriteLine("Example: A - Y");
            numbers = Console.ReadLine();
            subArray = numbers.Split('-');
            for (int i = 0; i < subArray.Length; i++)
            {
                trimmed = subArray[i].Trim();
                if (double.TryParse(trimmed, out num))
                {
                    numList.Add(num);
                }
            }
            sum = numList[0];
            for (int i = 1; i < numList.Count; i++)
            {
                sum = CalculatorLibrary.Calculator.Subtract(sum, numList[i]);
            }
            Console.WriteLine(numbers + "=" + sum);
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
