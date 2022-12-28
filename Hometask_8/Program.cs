/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


// void Show2DArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }

// int[,] Array2DSortRows(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int[,] myArray = new int[,]{
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
// };

// Show2DArray(
//     Array2DSortRows(myArray));



//////////////////////////////////////////

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

// int MinSumRow(int[,] array){
//     int minRow = 0;
//     int minSum = 0;
//     for (int k = 0; k < array.GetLength(1); k++)
//     {
//         minSum = minSum + array[0,k];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if(sum < minSum){
//             minSum = sum; 
//             minRow = i;
//         }

//     }
//     return minRow;
// }

//  int[,] myArray = new int[,]{
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
//     {5, 2, 6, 0},
// };

// Console.WriteLine("Строка: " + (MinSumRow(myArray)+1));

//////////////////////////////////////////////////////////////

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

// int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2){
//     int matrix1Rows = matrix1.GetLength(0);
//     int matrix1Columns = matrix1.GetLength(1);
//     int matrix2Rows = matrix2.GetLength(0);
//     int matrix2Columns = matrix2.GetLength(1);
//     int[,] compMatr = new int[matrix1Rows,matrix2Columns];
//     for (int i = 0; i < matrix1Rows; i++)
//     {
//         for (int j = 0; j < matrix2Columns; j++)
//         {
//             for (int k = 0; k < matrix1Columns; k++)
//             {
//                 compMatr[i,j] += matrix1[i,k] * matrix2[k,j];

//             }
//         }
//     }
//     return compMatr;

// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }


// int[,] matr1 = new int[,]{
//     {2, 4},
//     {3, 2},
// };
// int[,] matr2 = new int[,]{
//     {3, 4},
//     {3, 3},
// };

// Show2DArray(
//     CompositionMatrix(matr1, matr2));

/////////////////////////////////////////////////////////////////////////

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

// void PrintArray3D(int[,,] array3D){
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write(array3D[j,k,i]+" ");
//             }
//                 Console.WriteLine();
//         }
//     }
// }


// int[,,] myArray3D = new int[,,]{
//     {{66,27},{25, 90}},
//     {{34, 26},{41, 55}},
// };

// PrintArray3D(myArray3D);

//////////////////////////////////////////////////////////////
    

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

// int[,] GetArray(int[,] array, int num)   //не смог пока докрутить ничего универсального для квадратных массивов, только так :(((.
// {
//     int side = array.GetLength(0);
//     int i = 0;
//         for (int j = 0; j < side; j++)
//         {
//             num++;
//             array[i,j] = num;
//         }
//         for (int j = 0; j < side; j++)
//         {
//             num++;
//             array[j,side-1] = num;
//         }
//         for (int j = 2; j >= 0; j--)
//         {
//             num++;
//             array[side-1,j] = num;
//         }
//         for (int j = 2; j >= 1 ; j--)
//         {
//             num++;
//             array[j,i] = num;
//         }
//         i++;
//         for (int j = 1; j < side-1; j++)
//         {
//             num++;
//             array[i,j] = num;
//         }
//         Show2DArray(array);
//         for (int j = side-2; j > 0; j--)
//         {
//             num++;
//             array[side-2,j] = num;
//         }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }

// int[,] array = new int[4,4];
// Show2DArray(GetArray(array, 0, 0));