using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input(string str)
            {
                Console.Write(str);
                return Convert.ToInt32(Console.ReadLine());
            }

            //Задание 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            int NumberPow(int a, int b)
            {
                int x = a;
                for (int i = 1; i < Math.Abs(b); i++)
                    x *= a;
                return x;
            }

            Console.WriteLine("Задание 1:");
            int number1, number2;
            number1 = Input("Введите первое число: ");
            number2 = Input("Введите второе число: ");
            number1 = NumberPow(number1, number2);
            Console.WriteLine("Полученный результат -> " + number1);
            Console.WriteLine();

            //Задание 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            int Summ(int a, int b)
            {
                while (a != 0)
                {
                    b += a % 10;
                    a = a / 10;
                }
                return b;
            }

            Console.WriteLine("Задание 2:");
            number1 = Input("Введите число: ");
            number2 = 0;
            number2 = Summ(number1, number2);
            Console.WriteLine("Полученный результат -> " + number2);
            Console.WriteLine();

            //Задание 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
            int[] RandomAllArrayInput()
            {
                int[] a = new int[8];
                for (int i = 0; i < 8; i++)
                    a[i] = new Random().Next(-100, 100);
                return a;
            }

            void ArrayWrite(int[] a)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"{a[i]}, ");
                }
                Console.WriteLine(a[7]);
            }

            Console.WriteLine("Задание 3:");
            int[] array = new int[8];
            array = RandomAllArrayInput();
            ArrayWrite(array);

            Console.ReadKey();
        }
    }
}
