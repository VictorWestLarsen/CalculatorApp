using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public static class MenuPoints
    {
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
    }
}
