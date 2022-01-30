using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Халдон. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
//и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме 
// Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса."

namespace Homework2
{
    class RecommendedWeight
    {
        static void WeightRecomendation(double currentWeight, double currentHeight)
        {
            //Две переменные нормы индекса тела, первая - для вычисления сколько сбросить
            //Вторая - сколько добавить
            double weightIndexNormMax = 25;
            double weightIndexNormMin = 18.5;

            double weightIndex = currentWeight / Math.Pow(currentHeight, 2);

            //Сколько килограмм сбросить
            double kgToLose = currentWeight - (weightIndexNormMax *Math.Pow(currentHeight,2));

            //Сколько килограмм набрать
            double kgToGain = (weightIndexNormMin * Math.Pow(currentHeight, 2)) - currentWeight;

            //Учитывая, что в развитых странах проблема ожирения актуальна проверку нужно начинать с избыточной массы. 
            //С вероятностью примерно 50% дальнейшие вычисления не понадобятся
            //Экономим ресурсы
            if (weightIndex >25 ) {

                Console.WriteLine("Your weight index is {0:F1}. You need to loose {1:F1} kilogramms", weightIndex, kgToLose);
            }

            else if (weightIndex < 18.5)
              {
                Console.WriteLine("Your weight index is {0:F1}. You need to gain {1:F1} kilogramms", weightIndex, kgToGain);

            }

            else
                {
                Console.WriteLine("Your weight index is {0:F1}. You are perfect!", weightIndex);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Recomended weight";

            Console.WriteLine("Халдон. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы\n" +
                                 " и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.\n" +
                                  " Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.\n");

            //просим вести вес с запятой перед десятичной частью
            Console.WriteLine("Enter your weight in kilograms, use ,  before fraction :");
            double weight = double.Parse(Console.ReadLine());

            // просим ввести рост с запятой перед десятичной частью
            Console.WriteLine("Enter your height in meters, use ,  before fraction :");
            double height = double.Parse(Console.ReadLine());

            WeightRecomendation(weight, height);

            Console.ReadLine();
          

        }
    }
}
