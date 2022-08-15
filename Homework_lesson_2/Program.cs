
using System;
using System.Text.RegularExpressions;

namespace Homework_lesson_2
{
    internal class Program
    {


        public class class_implementation
        {
            public void Interview()
            {
                //
                string pattern = @"^[\p{L} \.\-]+$";
                //
                Console.Write("Введите имя: ");
                string? name = Console.ReadLine();
                if (!Regex.IsMatch(name, pattern)) { name = "Неверный ввод";}
                //
                Console.Write("Введите фамилию: ");
                string? surname = Console.ReadLine();
                if (!Regex.IsMatch(surname, pattern)) { surname = "Неверный ввод"; }
                //
                Console.Write("Введите возраст: ");
                string? age_str = Console.ReadLine();
                int age;
                if (!int.TryParse(age_str, out age))
                {
                    age_str = "Неверный ввод";
                }
                else
                {
                    age = Convert.ToInt32(age_str);
                    if (age<0 ^ age>120) 
                    {
                        age_str = "Неверный ввод";
                    }
                }
                //
                Console.Write("Введите род занятий: ");
                string? Hobby = Console.ReadLine();
                //
                Console.WriteLine($"Имя: {name} Фамилия: {surname}  Возраст: {age_str}  Род занятий: {Hobby} ");
                Console.WriteLine(" ");
            }


        }
        //
        static void Main(string[] args)
        {
            class_implementation example_class_implementation = new class_implementation();
            while (true)
            { example_class_implementation.Interview();}
            
        }
    }
}

