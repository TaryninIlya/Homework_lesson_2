using System.Text.RegularExpressions;
namespace HomeworkLesson2
{
    internal class Program
    {
        public class CamelCase
        {
            public void ProfileForm()
            {
                string pattern = @"^[\p{L} \.\-]+$";
                string? name;
                string? age_str;
                int age;
                string? surname;
                string? hobby;
                do
                {
                    Console.Write("Введите имя: ");
                    name = Console.ReadLine();
                }
                while (!Regex.IsMatch(name, pattern));
                do
                {
                    Console.Write("Введите фамилию: ");
                    surname = Console.ReadLine();
                }
                while (!Regex.IsMatch(surname, pattern));
                do
                {
                    Console.Write("Введите возраст: ");
                    age_str = Console.ReadLine();
                    if (int.TryParse(age_str, out age))
                    {
                        age = Convert.ToInt32(age_str);
                        if (age < 0 ^ age > 120)
                        {
                            age_str = null;
                        }
                    }
                    else
                    {
                        age_str = null;
                    }
                }
                while (age_str == null);
                do
                {
                    Console.Write("Введите род занятий: ");
                    hobby = Console.ReadLine();
                }
                while (!Regex.IsMatch(hobby, pattern));
                Console.WriteLine($"Имя: {name} Фамилия: {surname}  Возраст: {age_str}  Род занятий: {hobby} ");
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            CamelCase example_CamelCase = new CamelCase();
            while (true) { example_CamelCase.ProfileForm(); }
        }
    }
}