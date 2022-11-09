// // Задача 1 - Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// // число A в натуральную степень B.

// using System;

namespace ConsoleApp1
{
    class Power
    {
        static double numberInPower(double number, int power)
        {
            double result = 1;

            for(int i = 0; i < power; i++)
            {
                result = number*result;
            }

            if (power < 0)
                {
                Console.WriteLine("Ошибка степень числа Pow не является натуральным числом");
                return -1;
                }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write($"Введите число Num = ");
            double num = Convert.ToDouble(Console.ReadLine());
            
            Console.Write($"Введите степень числа Pow = ");
            int pow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Число {num} в степени {pow} равно {numberInPower(num, pow)}");
        }      
    }
}

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// using System;

// namespace ConsoleApp2
// {
//     class Sum
//     {
//         static int SumOfDigits (int number)
//         {
//             int result = 0;
//             int current = 0;

//             while (number > 1)
//             {
//                 current = number%10;
//                 number = number/10;
//                 result = result + current;
//             }

//             if (number < 0)
//             {
//                 while (number < -1)
//                 {
//                     current = number%10;
//                     number = number/10;
//                     result = result + current;
//                 }
//             }

//             return result;
//         }
//         static void Main(string[] args)
//         {
//             Console.Write($"Введите число Num = ");
//             int num = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine($"Сумма цифр числа {num} равна {SumOfDigits(num)}");
//         }
//     }
// } 

// Задача 29: Напишите программу, в которой пользователь задаёт массив из m элементов 
// которые потом выводятся на экран.

// using System;

// namespace ConsoleApp3
// {
//     class InputArray
//     {
//         static int [] InputOfArray (int size)
//             {
//                 int [] array = new int [size];
                            
//                 Console.WriteLine("Введите элементы массива");

//                 for (int i = 0; i < size; i++)
//                 {
//                     array[i] = Convert.ToInt32(Console.ReadLine());
//                 }
//                 Console.WriteLine("Все элементы массива введены!");
//                 return array;
//             }
            
//         static void PrintArray (int [] array)
//             {
//                 for (int i=0; i < array.Length; i++)
//                     Console.Write(array[i] + " ");
//                 Console.WriteLine();
//             }

//         static void Main(string[] args)
//         {
//             Console.Write("Введите длину массива Size = ");
//             int size = Convert.ToInt32(Console.ReadLine());

//             PrintArray(InputOfArray(size));
//          }
//     }
// }
