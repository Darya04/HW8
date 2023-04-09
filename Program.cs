// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] FillMatrixWithRandom(int row, int column)
// {
// int[,] array = new int[row, column];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(0, 10);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]} \t");
// }
// Console.WriteLine();
// }
// }



// int[,] SwitchRows(int [,] matrix)
// {
// for (int k = 0; k < 10; k++)
// {
//     for (int i = 0; i < matrix.GetLength(0)- 1; i++)
//     {
//         for (int j = i+1; j < matrix.GetLength(1); j++)
//         {
//              if(matrix[k,i] < matrix[k,j])
//                 {
//                     int temp = matrix[k,i];
//                     matrix[k,i] = matrix[k,j];
//                     matrix[k,j] = temp;
//                 }       
//         }
//     }
// }
//     return matrix;
// }
// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// SwitchRows(matrix);
// PrintMatrix(matrix);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] FillMatrixWithRandom(int row, int column)
// {
// int[,] array = new int[row, column];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(0, 10);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// int Sum (int [,] matrix)
// {
//     int sum=0;
//     for (int i=0; i<matrix.GetLength(0); i++)

//     {
//         sum+=sum;
       
//     }
//     return sum;
// }
// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// Sum(matrix);
// PrintMatrix(matrix);
