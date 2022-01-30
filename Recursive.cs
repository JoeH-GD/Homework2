using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Recursive
    {
		//тут все стандартно, просто добавил сообщение об окончании вывода

		static void WriteAllNumbers(int a, int b)
		{
		    Console.WriteLine("{0} ", a);
			
			if (a<b)	WriteAllNumbers(a+1, b);
			else Console.WriteLine("Output is finished.\n");
		}

		//Это сломало мне мозг, но я все-таки решил
		static int SummAllNumbers(int i, int k)
        {
			int sum = 0;
			sum += i;
			if (i<k) sum = i + SummAllNumbers(i+1, k);

			return sum;
			
        }

		static void Main(string[] args)
		{
			Console.WriteLine("Enter first number");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter second number");
			int num2 = int.Parse(Console.ReadLine());


			WriteAllNumbers(num1, num2);

			Console.WriteLine("The summ of these numbers is {0}",SummAllNumbers(num1, num2));
			
			Console.ReadLine();
		}

	}

}

