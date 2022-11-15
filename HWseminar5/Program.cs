// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] myArray = new int [size];
    
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return myArray;
// }

double [] CreateRandomDoubleArray (int size)
{
    double [] myArray = new double [size];
    
//     for (int i = 0; i < size; i++)
//     {
//         double random = new Random().NextDouble() * new Random().Next(Int16.MinValue, Int16.MaxValue);
//         myArray[i] = Math.Round(random, 2);
//     }
//     return myArray;
// }

// void PrintArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// void PrintDoubleArray (double [] array)
// {
//     for (int i=0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }


// Задача1 - Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int QuantityEvenNumber (int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//         if(array[i]%2 == 0)
//             count++;
//     return count;
// }

// Console.Write("Введите длину массива ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(size, 100, 999);
// PrintArray(myArray);

// Console.WriteLine($"В массиве {QuantityEvenNumber(myArray)} четных элементов");

// Задача 2 - Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// int SumUnevenItem (int [] array)
// {
//     int sum = 0;

//     for (int i = 1; i < array.Length; i+= 2)
//     {
//         sum+=array[i];
//     }
//     return sum;
// }

// Console.Write("Введите длину массива ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(size, Int16.MinValue, Int16.MaxValue);
// PrintArray(myArray);

// Console.WriteLine($"Сумма элементов массива стоящих на неченых позициях равна {SumUnevenItem(myArray)}");

// Задача 3 - Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double DiffMinMaxValue (double [] array)
// {
//     double minValue = array[0];
//     double maxValue = array[0];

//     for(int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < minValue)
//         minValue = array[i];

//         if(array[i] > maxValue)
//         maxValue = array[i];
//     }

//     return maxValue - minValue;
// }

// Console.Write("Введите длину массива ");
// int size = Convert.ToInt32(Console.ReadLine());

// double [] myArray = CreateRandomDobleArray(size);
// PrintDoubleArray(myArray);

// Console.WriteLine($"Разность минимального и максимального элементов массива равна {DiffMinMaxValue(myArray)}");

