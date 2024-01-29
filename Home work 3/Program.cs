using System;
using System.Linq;

namespace Home_work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise1 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string monthOfYear;
            Console.Write("Введите месяц, чтобы узнать пору года: ");
            monthOfYear = Console.ReadLine().ToLower();
            switch (monthOfYear)
            {
                case "декабрь":
                case "январь":
                case "февраль":
                    Console.WriteLine("На дворе зима");
                    break;
                case "март":
                case "апрель":
                case "май":
                    Console.WriteLine("На дворе весна");
                    break;
                case "июнь":
                case "июль":
                case "август":
                    Console.WriteLine("На дворе лето");
                    break;
                case "сентябрь":
                case "октябрь":
                case "ноябрь":
                    Console.WriteLine("На дворе осень");
                    break;
                default:
                    Console.WriteLine("Вы указали неверный месяц, или допустили ошибку в слове. Пожалуйста, повторите ввод.");
                    break;
            }


            //Exercise2
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int numberOfMonth;
            Console.Write("Введите номер месяца, чтобы узнать пору года: ");
            numberOfMonth = Convert.ToInt32(Console.ReadLine());
            if (numberOfMonth == 1 || numberOfMonth == 2 || numberOfMonth == 12)
            {
                Console.WriteLine("На дворе зима.");
            }
            else if (numberOfMonth == 3 || numberOfMonth == 4 || numberOfMonth == 5)
            {
                Console.WriteLine("На дворе весна.");
            }
            else if (numberOfMonth == 6 || numberOfMonth == 6 || numberOfMonth == 8)
            {
                Console.WriteLine("На дворе лето.");
            }
            else if (numberOfMonth == 9 || numberOfMonth == 10 || numberOfMonth == 11)
            {
                Console.WriteLine("На дворе осень.");
            }
            else
            {
                Console.WriteLine("Вы указали неверный месяц, или допустили ошибку в слове. Пожалуйста, повторите ввод.");
            }



            //Exercise3
            Console.Write("Введите чило для проверки на четность: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число чётное.");
            }
            else
            {
                Console.WriteLine("Число нечётное.");
            }


            //Exercise4
            Console.Write("Введите текущую температуру на улице: ");
            int outdoorTemperature = Convert.ToInt32(Console.ReadLine());
            if (outdoorTemperature > -5)
            {
                Console.WriteLine("Тепло");
            }
            else if (outdoorTemperature <= -5 && outdoorTemperature > -20)
            {
                Console.WriteLine("Нормально");
            }
            else
            {
                Console.WriteLine("Холодно");
            }


            //Exercise5
            Console.WriteLine("Введите номер и получите цвет которому он соответствуе в палитре радуги: ");
            int rainbowColor = Convert.ToInt32(Console.ReadLine());
            switch (rainbowColor)
            {
                case 1:
                    Console.WriteLine("Красный");
                    break;
                case 2:
                    Console.WriteLine("Оранжевый");
                    break;
                case 3:
                    Console.WriteLine("Жёлтый");
                    break;
                case 4:
                    Console.WriteLine("Зелёный");
                    break;
                case 5:
                    Console.WriteLine("Голубой");
                    break;
                case 6:
                    Console.WriteLine("Синий");
                    break;
                case 7:
                    Console.WriteLine("Фиолетовый");
                    break;
                default:
                    Console.WriteLine("Такого цвета в радуге нет");
                    break;
            }

        }
    }
}
