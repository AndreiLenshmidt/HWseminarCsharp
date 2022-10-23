// // Задача 1 - Напишите программу, которая принимает на вход 
// // пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// // Выполнение промежуточных вычислений, нахождение количества цифр(длины) числа,
// // для положительных и отрицательных чисел метод выдает одинаковую длину
// int LengthOfNum (int arg1)
// {
//     if(arg1<0) arg1 = -arg1;
//     string text = Convert.ToString(arg1);
//     int length = text.Length;
//     return length;
// }
// // Выполнение промежуточных вычислений 10^(длины числа) - arg2 для CheckForPolindrome
// int PowerTenInLength (double arg1)
// {
// double pow10 = Math.Pow(10, arg1-1);
// int pow = Convert.ToInt32(pow10);
// return pow;
// }
// // Выполнение проверки на полиндромность 
// bool CheckForPolindrome(int arg1, int arg2)
// {
// // Инициализация внутренних переменных num2 и num3, они равны arg1 т.к. в цикле над числом 
// // "num" (arg1) производится две противоположные операции с перезаписью значений
// int num2 = arg1;
// int num3 = arg1;

// while (arg2>=1 && num3>0)
// {
//     int firstDigit = num2/arg2; 
//     int lastDigit = num3%10;

//     num2 = num2 - firstDigit*arg2;
//     arg2 = arg2/10;
//     num3 = num3/10;
// // Сравнение первой и последней цифр числа
//     if (firstDigit == lastDigit)
//         return true;    
//     else 
//     {
//         return false;
//     }
// }
// return true;    
// }

// Console.Write("Введите число Z = ");
// int num = Convert.ToInt32(Console.ReadLine());

// double leng = LengthOfNum(num);
// Console.WriteLine($"Количесво цифр в числе = {LengthOfNum(num)}");

// int powInteger = PowerTenInLength(leng);
// Console.WriteLine($"Число 10 в степени ({leng} - 1) = {powInteger}");

// bool pol = CheckForPolindrome(num, powInteger);

// if (pol == true)
//     Console.Write($"Число {num} полиндром");
// else
//     Console.Write($"Число {num} НЕ полиндром");

// // Задача 2 - Напишите программу, которая принимает на вход координаты 
// // двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// double CutInSquare (int coordinate1, int coordinate2)
// {
//     double cut = Math.Pow(coordinate2-coordinate1,2);
//     return cut;
// }

// double Distance (double cut1, double cut2, double cut3)
// {
//     double result = Math.Sqrt(cut1+cut2+cut3);
//     return result;
// }

// Console.Write("Введите коордиату Х для первой точки Х1 = ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коордиату Y для первой точки Y1 = ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коордиату Z для первой точки Z1 = ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коордиату Х для второй точки Х2 = ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коордиату Y для второй точки Y2 = ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коордиату Z для второй точки Z2 = ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(CutInSquare(x1,x2), CutInSquare(y1,y2), CutInSquare(z1,z2));
// distance = Math.Round(distance,2);
// Console.WriteLine($"Расстояние между точкой А({x1},{y1},{z1}) и точкой В({x2},{y2},{z2}) равно {distance})");

// // Задача 3 - Напишите программу, которая принимает на вход число (N) и 
// // выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// int Cube (int arg1)
// {
//     int res = arg1*arg1*arg1;
//     return res;
// }

// Console.Write("Введите число N = ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// if(number>0)
//     while (count<=number)
//     {
//         int result = Cube(count);
//         Console.Write($"{result} ");
//         count++;
//     }
// // При N<0, таблица кубов будет такой (1 0 -1 -8 - 27 ... -N) т.к. по условию таблица начинается с 1 до N
// else 
//     while (count>=number)
//     {
//         int result = Cube(count);
//         Console.Write($"{result} ");
//         count--;
//     }