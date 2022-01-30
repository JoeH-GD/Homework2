using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Autorization

    {
        //В книге, где было описано сравнение строк я нашел метод решенный через массив и for each и он был красивее
        //Но мне хотелось решить задачу самостоятельно, как я бы ее решал с тем багажом, который у меня есть
        static bool Authorisation(string login, string password)
        {
            // Ставим не авторизован по умолчанию, во избежание случайного входа в систему без ввода логина и пароля
            bool authorised = false;
            string loginCorrect = "root";
            string passwordCorrect = "GeekBrains";
            
           //Метод Compare возвращает целочисленные значения от -1 до 1. Запишем их в переменные
           int logginCheck = string.Compare(loginCorrect, login);
           int passwordCheck = string.Compare(passwordCorrect, password);

            //Если обе строки совпали с заданными - авторизуем пользователя
            if (logginCheck == 0 && passwordCheck == 0)
            {
                authorised = true;
            }

            //Это можно было не делать, поскольку переменная сохранит значение false 
            // Но так просто удобнее для пользователя
            else
            {
                Console.WriteLine("Incorrect login or password. Press enter to try again!");

                Console.ReadLine();
            }

            // Просто чтобы было красивее
            Console.Clear();
            return authorised;
        }
        static void Main(string[] args)
        {
            Console.Title = "Authorisation";
            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.\n" +
                " На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).\n" +
                " Используя метод проверки логина и пароля, написать программу:\n" +
                "пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.\n" +
                " С помощью цикла do while ограничить ввод пароля тремя попытками.\n");

            int counter = 3;

            // Переменная нужна, чтобы сохранить результат, который вернет метод авторизации
            bool isAutorized = false;
           
            do
            {

                //Запрашиваем ввод от пользователя и сохраняем его в переменные
                Console.Write("Enter the login:");
                string loginEntered = Console.ReadLine();
                Console.Write("Enter the password:");
                string passwordEntered = Console.ReadLine();

                isAutorized = Authorisation(loginEntered, passwordEntered);

                //Предупредим пользователя о количестве оставшихся попыток
                counter--;
                Console.WriteLine("You have {0} attempts left", counter);

                //Если пользователь успешно авторизовался - нужно прервать цикл до выполнения условий
                if (isAutorized == true)
                {
                    Console.WriteLine("congrats! You're in!");

                    break;
                }
               
            }
            while (counter > 0);
           
            //Сообщение выводится только если авторизация все еще не пройдена после трех попыток
            if (isAutorized == false)
            {
                Console.WriteLine("You've tried three times. The system is temporary blocked. Try again later.");
            }
           
            Console.ReadLine();
        }
    }
}
