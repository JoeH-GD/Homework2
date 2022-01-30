using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class QuantityOfNumbers
    { 
        static int HowManyDigits(int number)
    {
        int counter = 0;
        while (number > 0)
        {
            number = number / 10;
            counter++;
        }
            return counter;

    }

    
        static void Main(string[] args)
        {
            Console.Title = "Number of Digets";
            Console.WriteLine("Халдон. Написать метод подсчета количества цифр числа.\n");

            Console.WriteLine("Enter a number");
         
        //В условии не сказано, обязательно ли входящее число должно быть положительным
        //На всякий случай решение предполагает, что на вход могло прийти отрицательное число
            int a = Math.Abs((int.Parse(Console.ReadLine())));
           

            int digits = HowManyDigits(a);

            Console.WriteLine(digits);
            Console.ReadLine();

         } 
    }
}
