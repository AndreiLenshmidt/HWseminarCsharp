// Задача 1 - Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomDoubleArray(int row, int col)
{
    double[,] array = new double [row, col];

    for(int i = 0; i < row; i++)
        for(int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*100, 2);
        }
    
    return array;
}

void ShowDoubleArrray(double[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +"\t");
        }
    Console.WriteLine();
    }
}

// Console.Write("Введите число строк массива ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов массива ");
// int col = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandomDoubleArray(row, col);
// ShowDoubleArrray(myArray);

// Задача 2 - Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandomIntArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];

    for(int i = 0; i < row; i++)
        for(int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    
    return array;
}

void ShowIntArrray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +"\t");
        }
    Console.WriteLine();
    }
}

int FindItemArray(int col, int row, int[,] array)
{
    return array[col, row];
}

// Console.Write("Введите позицию строки массива ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите позицию столбца массива ");
// int col = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomIntArray(6, 6, -10, 10);
// ShowIntArrray(myArray);

// Console.WriteLine();

// if(col<myArray.GetLength(0)&&col>=0 && row<myArray.GetLength(1)&&row>=0)
//     Console.WriteLine(FindItemArray(col, row, myArray));
// else 
//     Console.WriteLine("Такого элемента нет");

// Задача 3 - Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

double[] AverageInRow(int[,] array)
{
    double [] arrayAverage = new double [array.GetLength(1)];

    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            arrayAverage[i] +=array[j,i];
        }

        arrayAverage[i] = Math.Round(arrayAverage[i] / array.GetLength(0), 2);
    }

    return arrayAverage;
}

void ShowArray(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

// Console.Write("Введите число строк массива ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов массива ");
// int col = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomIntArray(row, col, 0, 10);
// ShowIntArrray(myArray);
// Console.WriteLine();
// Console.WriteLine("Среднее арифметическое элементов каждого столбца двухмерного массива равно:");
// Console.WriteLine();
// double[] arrayAverage = AverageInRow(myArray);
// ShowArray(arrayAverage);