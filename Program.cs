using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Homelesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            Console.WriteLine("***************");
            Console.WriteLine("Exercise 2");
            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            double product = 1;


            for (int i = 1; i <= 5; i++)// вводим 5 чисел с клавиатуры
            {
                Console.Write("Enter" +i+ "th number: ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {

                    sum += number;// обновляем сумму


                    if (number > max)// Обновляем максимум и минимум
                        max = number;
                    if (number < min)
                        min = number;


                    product *= number;// обновляем произведение
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter the number again.");
                    i--;
                }
            }
            Console.WriteLine("Sum of numbers:" +sum);// Выводим результаты
            Console.WriteLine("Maximum:" +max);
            Console.WriteLine("Minimum:" +min);
            Console.WriteLine("product of numbers:" +product);
            Console.WriteLine("***************");
            Console.WriteLine("Exercise 3");
            Console.Write("Enter a six-digit number: ");
            string input = Console.ReadLine();

            if (input.Length == 6)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedNumber = new string(charArray);

                Console.WriteLine("Result:" +reversedNumber);
            }
            else
            {
                Console.WriteLine("Error! Enter a six-digit number:");
            }


        }
    }
}


    
    

