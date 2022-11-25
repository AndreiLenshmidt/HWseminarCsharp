
// Задача 1 - Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// int [,] CreateRandomIntArray(int row, int col, int minValue, int maxValue)
// {
//     int[,] array = new int[row, col];

//     for(int i = 0; i < row; i++)
//         for(int j = 0; j < col; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
    
//     return array;
// }

// void ShowIntArrray(int[,]array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] +"\t");
//         }
//     Console.WriteLine();
//     }
// }

// void ArraySort(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int count = 0; count < array.GetLength(1); count++)
//         {
//             int min = array[i,count];
            
//             for(int j = count+1; j < array.GetLength(1); j++ )
//             {
//                 if (array[i, j] < min)
//                 {
//                     min = array[i,j];
//                     int temp = array[i, count];
//                     array[i, count] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
// }

// int[,] myArray = CreateRandomIntArray(4,7,-10,10);
// ShowIntArrray(myArray);
// Console.WriteLine(  );

// ArraySort(myArray);
// ShowIntArrray(myArray);

// Задача 2 - Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// int FindNumberRow(int[,] array)
// {
//     int numRow = 0;
//     int minSum = Int32.MaxValue;

//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumRow = 0;

//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRow += array[i,j];
//         }

//         if(sumRow<minSum)
//         {
//             minSum = sumRow;
//             numRow = i + 1;
//         }
//     }

//     return numRow;
// }

// int[,] myArray = CreateRandomIntArray(4,4,0,10);
// ShowIntArrray(myArray);
// Console.WriteLine();

// int numRow = FindNumberRow(myArray);
// Console.WriteLine($"Номер ряда с наименьшей суммой элементов {numRow}");

// Задача 3 - Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] MatrixMultiply(int[,] array1, int[,] array2)
// {
//     int[,] matrix3 = new int[array1.GetLength(0),array2.GetLength(1)];
    
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2.GetLength(1); j++)
//         {
//             for(int k = 0, l = 0; k < array2.GetLength(0); l++, k++)
//             {
//                 matrix3[i,j] +=array1[i,l]*array2[k,j];
//             }
//         }
//     }

//     return matrix3;
// } 

// Console.Write("Введите число строк матрицы 1= ");
// int row1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов матрицы 1 = ");
// int col1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число строк матрицы 2 = ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов матрицы 2 = ");
// int col2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Matrix1");
// int[,] matrix1 = CreateRandomIntArray(row1,col1,0,10);
// ShowIntArrray(matrix1);
// Console.WriteLine();

// Console.WriteLine("Matrix2");
// int[,] matrix2 = CreateRandomIntArray(row2,col2,0,10);
// ShowIntArrray(matrix2);
// Console.WriteLine();

// if (matrix1.GetLength(1)==matrix2.GetLength(0))
// {
//     int[,] matrix3 = MatrixMultiply(matrix1, matrix2);
//     ShowIntArrray(matrix3);
// }
// else
//     Console.WriteLine("Для данных матриц невозможно вычислить прозведение");

// Задача 4 - Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого 
// элемента. Массив размером 2 x 2 x 2

// void Show3DArrray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k})" + "\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] CreateUniqueItemArray(int l, int m, int n, int min = 10, int max = 100)
// {

// //    Основная идея метода в том, чтоб в момент присвоения элементу 3D массива значения проверять 
// //    его уникальность сразу, а не сравнивать рандомно сгенерированный элемент со всеми остальными
// //    иначе придется делать цикл в цикле 6 раз.

// //    1. Инициализируется пустой одномерный массив 

//     int[] allDigitArrai = new int[max - min]; // 1. Инициализируется пустой одномерный массив 

// //    2. Одномерный массив заполняется по порядку с 10 до 99

//     for (int i = 0; i < allDigitArrai.Length; i++)  
//     {
//         allDigitArrai[i] = min;
//         min++;
//     }

// //    3. Создается 3D массив 

//     int[,,] newArray = new int[l, m, n];

//     for (int i = 0; i < l; i++)
//         for (int j = 0; j < m; j++)
//             for (int k = 0; k < n; k++)
//             {

// //     4. Создается переменная (randomIndex) в которую записывается рандомное значение от 0 до 90
// //        она будет индексом одномерного массива.

//                 int randomIndex = new Random().Next(0, 90);

// //     5. Осуществляется проверка равен ли элмент одномерного массива 0. 
// //        Если равен, инкременируем (randomIndex), если индекс равен максимальному(89), 
// //        присваеиваем в индекс 0 и повторяем до тех пор пока элемент с этим индексом равен 0.

//                 while (allDigitArrai[randomIndex] == 0)
//                 {
//                     if (randomIndex >= 89)
//                         randomIndex = 0; 
                    
//                     randomIndex +=1;
//                 }

// //     6. После того как номер индекса скорректирован, или корректировка не потребавалась
// //        записываем в элемент 3D массива элемент одномерного массива с текущим индексом.
// //     7. После чего убираем элемент одномерного массива записывая в него "0".

//                     newArray[i, j, k] = allDigitArrai[randomIndex];
//                     allDigitArrai[randomIndex] = 0;
//             }

//     return newArray;
// }

// int[,,] uniqueItemArray = CreateUniqueItemArray(4, 4, 4);
// Show3DArrray(uniqueItemArray);

// Задача 5 - Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void ArraySpiral(int[,] array, int n, int k = 0)
// {

// //  1. В первую стороку записываются числа от 1 по порядку     

//     if (k==0)
//         for(int i = k; i < array.GetLength(0)-k; i++)
//             array[k,i] = i+1;
//     else 
//         for(int i = k; i < array.GetLength(0)-k; i++)
//             array[k,i] = i+array[k,k-1];

// //  2. В последний столбец (исключая последний элемент первой строки) записываются числа по порядку

//     for(int i = k+1; i < array.GetLength(1)-k; i++)
//         array[i,array.GetLength(0)-1-k] = array[k,array.GetLength(0)-1-k]+i-k;

// //  3. В последнуюю строку справа-налево (искл. последний элемент массива) также 
// //     записываются числа по порядку

//     for(int i = array.GetLength(0)-2-k, j = 1; i > k-1; i--, j++)
//         array[array.GetLength(0)-1-k,i] = array[array.GetLength(0)-1-k, array.GetLength(1)-1-k] + j;

// //  4. В первый столбец снизу вверх записываются остальниые числа

//     for(int i = array.GetLength(1)-2-k, j = 1; i > k; i--, j++)
//         array[i,k] = array[array.GetLength(0)-1-k,k] + j;

// //  5. Переменная k отвечает за номер итерации, и также через нее определены границы 
// //     (например для k = 0 это array[0,0] и array[1,0], для k = 1 это array[1,1] и array[2,1] и т.д.)
// //     также с помощью k увеличваются значения элементов массива.

//     k++;

// //  6. Рекурсивно вызивается метод ArraySpiral(), можно и с помощью цикла также увеличивать k для  
// //     заполнения массива, но я уже изучил рекурсию.

//     if(k<=n/2) ArraySpiral(array,n,k);
// }

// int n = 10;
// int[,] myArray = new int [n,n];

// ArraySpiral(myArray,n);
// ShowIntArrray(myArray);

