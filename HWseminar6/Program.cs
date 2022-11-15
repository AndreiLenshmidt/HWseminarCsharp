// Задача 1 - Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

// void CountPositiveNum(int m)
// {

// int count = 0;

// for(int i = 1; i <= m; i++)
// {
//     Console.Write($"Число номер {i} равно ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     if(num > 0) count++;
// }

// Console.WriteLine($"Вы ввели {count} чисел больше 0");

// }

// Console.Write("Сколько чисел вы хотите ввести? Введите колличество чисел М = ");
// int m = Convert.ToInt32(Console.ReadLine());

// CountPositiveNum(m);

// Задача 2 - Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(int k1, int k2, int b1, int b2)
{
    if(k1==k2 && b1==b2)
        Console.WriteLine("Прямые полностью совпадают");

    if(k1==k2 && b1!=b2)
        Console.WriteLine("Прямые паралельны и не имеют точек пересечения");

    if(k1!=k2 && b1!=b2) 
    {
        int x, y;

        x = (b2-b1) / (k1-k2);
        y = k1*x + b1;

        Console.WriteLine($"Прямые пересекаются в точке с координатами Х = {x}, У = {y}");
    }
}

Console.Write("Введите K1 для прямой у = К1*Х + В1, К1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B1 для прямой у = К1*Х + В1, B1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к2 для прямой у = К2*Х + В2, К2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к1 для прямой у = К2*Х + В2, B2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(k1, k2, b1, b2);