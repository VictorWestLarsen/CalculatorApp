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
        public static void Add ()
        {
            double sum = 0;
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
            }
            for (int j = 0; j < nmb.Count; j++)
            {
                sum = CalculatorLibrary.Calculator.Add(sum, nmb[j]);
            }
            Console.WriteLine(Number + " = " + sum);
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

            Console.WriteLine(number + " = " + sum);
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
            double sum = 0;
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

                sum = nmb[0];
                for (int k = 1; k < nmb.Count; k++)
                {
                    sum = CalculatorLibrary.Calculator.Divide(sum, nmb[k]);
                }
            }
            Console.WriteLine(Numbers + " = " + sum);
        }
        public static void Maximum()
        {
            string Number;
            string[] tmp;
            List<double> nmb = new List<double>();
            double v;
            Console.WriteLine("Please enter the numbers you wish to find the maximum of ");
            Console.WriteLine("like this x,y,...");
            Number = Console.ReadLine();
            tmp = Number.Split(',');
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
                
            }
            double max = Calculator.Maximum(nmb.ToArray());
            Console.WriteLine("The maximum number is: " + max);
        }
        public static void Sum()
        {
            string input;
            double parseHolder;
            string[] tempArray;
            string trimHolder;
            double resultat;
            List<double> numList = new List<double>();
            Console.WriteLine("Please enter a series of numbers to find the sum.");
            Console.WriteLine("Example: 1,2,3,4,5,6,7,8,9");
            input = Console.ReadLine();
            tempArray = input.Split(',');
            for (int i = 0; i < tempArray.Length; i++)
            {
                trimHolder = tempArray[i];
                trimHolder.Trim();
                if (double.TryParse(trimHolder, out parseHolder))
                {
                    numList.Add(parseHolder);
                }
            }
            resultat = CalculatorLibrary.Calculator.Sum(numList.ToArray());

            Console.WriteLine("The total sum of the numbers are: " + resultat);



        }

        public static void Minimum()
        {
            string Number;
            string[] tmp;
            List<double> nmb = new List<double>();
            double v;
            Console.WriteLine("Please enter the numbers you wish to find the maximum of ");
            Console.WriteLine("like this x,y,...");
            Number = Console.ReadLine();
            tmp = Number.Split(',');
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

            }
            double min = Calculator.Minimum(nmb.ToArray());
            Console.WriteLine("The minimum number is: " + min);
        }
    }
}
