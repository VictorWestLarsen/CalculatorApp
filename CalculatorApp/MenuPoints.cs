using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorApp
{
    public static class MenuPoints
    {
        public static void Multiply()
        {
            string number;

            string numTrim;

            string[] numArray;

            double num;

            double sum;

            List<double> numList = new List<double>();

            Console.WriteLine("Please enter the two numbers you want multiplied: \n Example: X * X");

            number = Console.ReadLine();

            numArray = number.Split('*');

            for (int i = 0; i < numArray.Length; i++)
            {
                numTrim = numArray[i].Trim();

                if (double.TryParse(numTrim, out num))
                {
                    numList.Add(num);
                }
            }

            sum = numList[0];

            for (int i = 1; i < numList.Count; i++)
            {
                sum = Calculator.Multiply(sum, numList[1]);
            }

            Console.WriteLine(number + "=" + sum);
        }
    }
}
