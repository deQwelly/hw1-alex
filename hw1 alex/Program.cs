using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw1_alex
{
    internal class Program
    {
        static double ParsTheNumber(string varriable)
        {
            if (double.TryParse(varriable, out double number_1))
            {
                return number_1;
            }
            else
            {
                return 71680297;
            }
        }
        static void Main(string[] args)
        {   
            /// Задание №1
            Console.WriteLine("Задание №1:");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай\n");

            
            /// Задание №2
            Console.WriteLine("Задание №2:");
            Console.Write("Введите первую переменную: ");
            string variable1 = Console.ReadLine().Replace(".", ",");    ///определяем переменную 1 с учетом ошибки определения вещественного числа
            Console.Write("Введите вторую переменную: ");
            string variable2 = Console.ReadLine().Replace(".", ",");    ///то же самое для переменной 2

            if (ParsTheNumber(variable1) == 71680297)
            {
                Console.WriteLine("Вы ввели недопустимыые значения");
            }
            else
            {
                if (ParsTheNumber(variable2) == 71680297)
                {
                    Console.WriteLine("Вы ввели недопустимыые значения");
                }
                else
                {
                    Console.WriteLine($"{ParsTheNumber(variable2)}\n{ParsTheNumber(variable1)}");
                }
            }
            
            /// Задание №3
            Console.WriteLine("\nЗадание №3:");
            Console.WriteLine("Введите радиус окружности: ");
            string radius = Console.ReadLine().Replace(".", ",");
            double temp = ParsTheNumber(radius);
            if (temp == 71680297)
            {
                Console.WriteLine("Вы ввели недопустимое значение");
            }
            else
            {
                Console.WriteLine($"Длина окружности с заданным радиусом: {Math.PI * 2 * temp}");
                Console.WriteLine($"Площадь окружности с заданным радиусом: {Math.PI * Math.Pow(temp, 2)}\n");
            }
            
            /// Задание №4
            Console.Write("Задание №4:\nВведите x: ");
            string x = Console.ReadLine();
            temp = ParsTheNumber(x);
            if (temp == 71680297)
            {
                Console.WriteLine("Вы ввели недопустимое значение");
            }
            else
            {
                Console.WriteLine($"Косинус x: {Math.Cos(temp)}");
            }
            
            /// Задание №5
            Console.WriteLine("\nЗадание №5:");
            Console.WriteLine("Введите коэффициенты квадратного уравнения (после каждого введенного значения нажмите enter): ");
            string a = Console.ReadLine().Replace(".", ",");
            string b = Console.ReadLine().Replace(".", ",");
            string c = Console.ReadLine().Replace(".", ",");
            double temp_a = ParsTheNumber(a);
            double temp_b = ParsTheNumber(b);
            double temp_c = ParsTheNumber(c);
            if (temp_a == 71680297 | temp_b == 71680297 | temp_c == 71680297)
            {
                Console.WriteLine("Вы ввели недопустимые значения");
            }
            else
            {
                double d = (Math.Pow(temp_b, 2)) - (4 * temp_a * temp_c);
                if (d < 0 )
                {
                    Console.WriteLine("Решений нет");
                }
                else
                {
                    Console.WriteLine($"x1 = {(-temp_b + Math.Sqrt(d)) / (2 * temp_a)}");
                    Console.WriteLine($"x1 = {(-temp_b - Math.Sqrt(d)) / (2 * temp_a)}");
                }
            }

            ///Задание №6
            Console.WriteLine("\nЗадание №6:");
            Console.WriteLine("Введите 3 значения a, b, c соответственно (после каждого введенного значения нажмите enter): ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            Console.WriteLine("a b c");
            Console.WriteLine($"{a} {b} {c} - исходные значения");
            string temp_1 = a;
            string temp_2 = b;
            string temp_3 = c;
            b = c;
            a = temp_2;
            c = temp_1;
            Console.WriteLine($"{a} {b} {c} - первая схема");
            b = temp_1;
            c = temp_2;
            a = temp_3;
            Console.WriteLine($"{a} {b} {c} - вторая схема");

            ///Задание №7
            Console.WriteLine("\nЗадание №7:");
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(rnd.Next(100, 999));
            }

            ///Задание №8
            Console.WriteLine("\nЗадание №8:");
            string str = Convert.ToString(rnd.Next(100, 999));
            Console.WriteLine(str);
            Console.WriteLine(str[2] + str.Substring(0, 2));

            ///Задание №9
            Console.WriteLine("\nЗадание №9:");
            Console.WriteLine("Цена конфет - 175р/кг, печенья - 100р/кг, яблок - 155р/кг");
            Console.WriteLine("Введите вес конфет, печенья и яблок соответственно (вес указывать в кг, после каждого введенного значения нажмите enter)");
            string candies = Console.ReadLine().Replace(".", ",");
            string coockies = Console.ReadLine().Replace(".", ",");
            string apples = Console.ReadLine().Replace(".", ",");
            double candies_kg = ParsTheNumber(candies);
            double coockies_kg = ParsTheNumber(coockies);
            double apples_kg = ParsTheNumber(apples);
            if (candies_kg == 71680297 | coockies_kg == 71680297 | apples_kg == 71680297)
            {
                Console.WriteLine("Вы ввели некорректные значения");
            }
            else
            {
                Console.WriteLine($"Сумма покупки: {(candies_kg * 175) + (coockies_kg * 100) + (apples_kg * 155)}");
            }
        }
    }
}
