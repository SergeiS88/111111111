//////////////////////Задача 47////////////////////

// double[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
// {                                                                                
//     double[,] newArray = new double[rows,columns];                                     
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue+1) + new Random().NextDouble(); 
//         }
//     }
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);

///////////////////////////////Задача 50 ////////////////////

// int[,] array = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
// };

// void FindElement(int[,] array, int row, int column){
//     if(row < array.GetLength(0) && column < array.GetLength(1))Console.WriteLine(array[row-1,column-1]);
//     else{Console.WriteLine("такого числа в массиве нет");}
// }


// Console.Write("Введите строкe элемента ");
// int rowNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец элемента ");
// int columnNum = Convert.ToInt32(Console.ReadLine());
// FindElement(array, rowNum, columnNum);

///////////////////////////Задача 52////////////////////////////////

// double[] AverageColumns(int[,] array){
//     double[] average = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             average[j] += array[i,j]; 
//         }
//     }
//     for (int k = 0; k < average.Length; k++)
//     {
//         average[k] /= array.GetLength(0);
//     }
//     return average;
// }

// void PrintArray(double[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[,] myArray = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},};
// PrintArray(
//     AverageColumns(myArray));