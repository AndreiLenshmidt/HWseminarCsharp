// // Home work 2.

// //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// // показывает вторую цифру этого числа.

// int SecondNum(int sthNum)
// {
//    int sthNum1 = (sthNum/10)%10;
//    return sthNum1;
// }

// Console.Write("Введите число от 100 до 999 А = ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1>100 && num1<=999)
// {
//     int result1 = SecondNum(num1);
//     Console.WriteLine($"Вторая цифра числа {num1} равна {result1}");
// }
// else
// Console.WriteLine("Введенное вами число не трехзначное");

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// //  что третьей цифры нет.

// int ThirdNum(int num)
// {
// while (num > 1000 || num <-1000)
// num = num/10;
// int result = num%10;
// return result;
// }

// Console.Write("Введите целое число от Z = ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2>100 || num2<-100)
// {
// int resNum2 = ThirdNum(num2);
// Console.WriteLine($"Третья цифра числа {num2} равна {resNum2}");
// }
// else Console.WriteLine("Третьей цифры нет");

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// // и проверяет, является ли этот день выходным.

// bool DayOfWeek(int dw)
// {
// if (dw > 5 && dw < 8)
// return true;
// else
// return false;
// }

// Console.Write("Введите день недели цифрой от 1 до 7 от DW = ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num3>0 && num3<8)
// {
// bool dayWeek = DayOfWeek(num3);
// Console.WriteLine(dayWeek);
// }
// else
// Console.Write("Введеное вами число не является днем недели, введите число от 1 до 7");

