//Задача1 - Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNum(int n)
// {
//     Console.Write(n+" ");
//     if(n>1) ShowNum(n-1);
// }

// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// ShowNum(number);

// Задача2 - Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// int FindSum(int firstNum, int secondNum)
// {
//     if(firstNum<secondNum) 
//     {
//         return firstNum+=FindSum(firstNum+1,secondNum);
//         return firstNum;
//     }
//     else if(firstNum>secondNum) 
//     {
//         return secondNum+=FindSum(firstNum, secondNum+1);
//         return secondNum;
//     }
//     else return firstNum;
// }

// Console.Write("Введите первое число ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(firstNum,secondNum));

//  Задача3 - Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

// uint AkkermanFunction(uint n, uint m)
// {
//     if(n==0) return m+1;
//     else if(n!=0 && m==0) return AkkermanFunction(n-1, 1);
//     else return AkkermanFunction(n-1, AkkermanFunction(n, m-1));
// }

// Console.Write("Введите первое число ");
// uint m = Convert.ToUInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// uint n = Convert.ToUInt32(Console.ReadLine());

// uint res = AkkermanFunction(m, n);
// Console.WriteLine(res);