using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Халдон. Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр.
//Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

namespace Homework2
{
    class GoodNumbers
    {
       

        static void Main(string[] args)
        {
          Console.Title = "Count Good Numbers";

          Console.WriteLine ("Халдон.Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.\n" +
             " «Хорошим» называется число, которое делится на сумму своих цифр.\n " +
              "Реализовать подсчёт времени выполнения программы, используя структуру DateTime.\n");

            DateTime start = DateTime.Now;
            int counter = 0;
           
            int maxNumber = 1000000000;

            for (int i= 1; i <= maxNumber; i++)
            {
             
            //Переменную суммы создаем в теле цикла, за его пределами она нам не нужна, бережем память
            int sum = 0;

                #region GoodNumber
                int numberCheck = i;
                while (numberCheck > 0 )
                {
                   sum = sum + (numberCheck % 10);
                   numberCheck = numberCheck / 10;
                }
                #endregion GoodNumber

                //Проверяем, является ли число хорошим
                if (i%sum == 0)
                {
                    counter++;
                }

            }

//Проверка выполнена на основе уменьшения области поика до диапазона 1 - 20
            Console.WriteLine(counter);
            Console.WriteLine(DateTime.Now - start);


            Console.ReadLine();
           
        }
    }
}
