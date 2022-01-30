using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class SummOddNumbers
    {
        static void Main(string[] args)
        {
            Console.Title = "SummOddNumbers";
            Console.WriteLine("Халдон. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n");
            int summ = 0;
            int x = 0;

            Console.WriteLine("Enter any number");

            // Использован цикл с постпроверкой, чтобы прогамма в любом случае обработала первый ввод 
            //если пользователь сразу введет 0, то получит сообщение о завершении программы
            do
            {
               x = int.Parse(Console.ReadLine());
               
               #region NumToSum    
                //Использовано сокращенное "И" потому что при несблюдении любого условия число нас не неинтересует
                //Экономим на вычислениях
                if (x % 2 != 0 && x > 0)
                {
                  
                        summ = summ + x;
                  
                  
                }
                #endregion NumToSum
              
               #region numToIgnore
                //Тоже сокращенное "И" и слева провера на четность, потому что если число ее не пройдет - правое условие не вычисляется
                //Учитывая, что любое число, кроме 0, ему не равно, есть шанс сэкономить на вычислениях
                else if (x < 0 || (x % 2 == 0 && x != 0))

                {
                  
                        Console.WriteLine("enter another number");
              
                }
                #endregion numToIgnore

               #region Exit
                else
                {
                    Console.WriteLine("You've entered 0 - the count is finished. Result {0}", summ);
                }
                #endregion Exit
            }

            while (x != 0);

               Console.ReadLine();

        }
    }
}
