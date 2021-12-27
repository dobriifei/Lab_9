using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор");
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите код операции");
                Console.WriteLine("1-сложение, 2-вычитание, 3-умножение, 4-деление");
                double result = Convert.ToDouble(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        result = a + b;
                        Console.WriteLine(" результат сложения равен {0}", result);
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine("результат вычитания равен  {0}", result);
                        break;
                    case 3:
                        result = a * b;
                        Console.WriteLine("результат умножения равен {0}", result);
                        break;
                    case 4:
                        result = a / b;
                        Console.WriteLine("результат деления {0}", result);
                        break;
                    default:
                        Console.WriteLine("нет операции с указанным номером");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

