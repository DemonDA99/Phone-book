using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.book();
        }
    }
    class Person
    {
        public string name;
        public string number;
        public static void book()
        {
            Person person = new Person();

            FormatName();
            FormatNumber();
       
            Console.WriteLine($"Имя: {person.number}");
            Console.WriteLine($"Номер: {person.number}");
        }
        public static void FormatNumber()
        {
            Person a = new Person();
            string forNum = @"^((\+7|7|8)+([0-9]){10})$";
            while (true)
            {
                Console.WriteLine("Введите номер телефона");
                a.number = Console.ReadLine();
                if(Regex.IsMatch(a.number, forNum))
                {
                    Console.WriteLine("Ok");
                    break;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public static void FormatName()
        {
            Person b = new Person();
            Console.WriteLine("Введите ФИО");
            b.name = Console.ReadLine();
            bool point = true;

            while (point)
            {
                if(!b.name.StartsWith(" ") && !b.name.EndsWith(" "))
                {
                    Console.WriteLine("Ok");
                    break;
                }
                else
                {
                    Console.WriteLine("sintacs errorre");
                    break;
                }
            }
        }
    }
}
