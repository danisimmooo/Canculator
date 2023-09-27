using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            string action;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Введите первое число:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            firstValue=double.Parse(Console.ReadLine());

            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("Введите второе число:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            secondValue =double.Parse(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            action = Console.ReadLine();
            
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.DarkRed;
            switch(action)
            {
                case "+":
                    Console.WriteLine(firstValue+secondValue);
                    break;

                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;

                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;

                case "/":
                    Console.WriteLine(firstValue / secondValue);
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя");
                        
                    }
                   break;
                    

                default:
                    Console.WriteLine("Ошибка!Проверьте правильность данных.");
                    break;
                    

            }
            Console.ReadLine();


        }
    }
}

