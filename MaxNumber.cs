using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class MaxNumber
    {
        static void MaxOfThree(int a, int b, int c)
        {
            //Оператор &, если я не ошибаюсь, всегда проверит оба условия, поэтому в этом случае его можно использовать
            //При тестах где a больше b но не больше c все работает корректно
            Console.WriteLine("Max out of a b and c is {0}", a > b & a > c ? a : b > c ? b : c);
        }

        static void Main(string[] args)
        {
            Console.Title = "Max out of three";

            Console.WriteLine("Haldon. Find maximum out of three numbers");
            Console.WriteLine("========================================");
          
            #region EnterVariables
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());
            #endregion EnterVariables

            MaxOfThree(num1, num2, num3);

            Console.ReadLine();

        }
    }
}
