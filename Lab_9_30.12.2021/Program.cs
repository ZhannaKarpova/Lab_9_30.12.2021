using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_30._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int total;
            char oper;
            Console.WriteLine("Добро пожаловать в калькулятор");
            Console.WriteLine("Введите первое число:");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                b = Convert.ToInt32(Console.ReadLine());
                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                    try
                    {
                        Console.WriteLine(a / b);
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (System.DivideByZeroException) when (a == 0 && b == 0)
                    {

                        Console.WriteLine("Ошибка " + "Нельзя делить на ноль");
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);


                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadLine();
            }
            Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
        }

    }
}

