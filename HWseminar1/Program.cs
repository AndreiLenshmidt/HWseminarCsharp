// Home work 1.

// Задача1 - Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input a first Integer Number ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a second Integer Number ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2) 
//     Console.WriteLine($"The first Number is Maximal = {num1}");
// else
//     Console.WriteLine($"The socond Number is Maximal = {num2}");

// Задача2 - Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Input a first Integer number ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a second Integer number ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a third Integer number ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2) 
// {
//     if(number1 > number3)
//         Console.WriteLine($"Maximal number is {number1}");
//     else
//         Console.WriteLine($"Maximal number is {number3}");
// }
// else
//     if(number2 > number3)
//         Console.WriteLine($"Maximal number is {number2}");
//     else
//         Console.WriteLine($"Maximal number is {number3}");

// Задача 3 - Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input an Integer number ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number%2 == 0)
//     Console.WriteLine("The number is even");
// else
//     Console.WriteLine("The number is not even");

// Задача 4 - Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Input a number ");
// int number = Convert.ToInt32(Console.ReadLine());
// int current = 1;

// // Т.к. в условиях необходимо чтоб показывались все числа от 1 до N, то 
// // при отрицательном N отсчет от 1 нужно вести в обратную сторону 
// // т.е. 1 0 -1 -2 и т.д. поэтому current--
// if(number < 0)
// {
// while(number <= current) 
// {
//     if(current%2 == 0)
//         Console.Write(current + " ");
//     current--;
// }
// }

// while(current <= number) 
// {
//     if(current%2 == 0)
//         Console.Write(current + " ");
//     current++;
// }