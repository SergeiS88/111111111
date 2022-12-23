// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//  int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int EvenNumberedCount(int[] array){
//     int count = 0;
//     for(int i=0; i<array.Length; i++){
//         if((array[i] & 1) == 0){    //(array[i]%2 == 0)
//             count+=1;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());   

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);
// Console.WriteLine(EvenNumberedCount(newArray));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//  int[] CreateRandomArray(int size, int minValue, int maxValue){
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array){
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int Sum(int[] array){
//     int sum = 0;
//     for(int i=0; i<array.Length; i++){
//         if((i & 1) == 0){   //(i%2 == 0)
//             sum+=array[i];
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());   

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);

// Console.WriteLine(Sum(newArray));


//////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//  double[] CreateRandomArray(int size, int minValue, int maxValue){
//     double[] myArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//     }
//     return myArray;
// }

// void ShowArray(double[] array){
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// double Func(double[] array){
//     double max = array[0];
//     double min = array[0];
//     for(int i=0; i < array.Length; i++){
//         if(array[i] < min) min = array[i];
//         else{
//          if(array[i]> max) max = array[i];   
//         }
//     }
    
//     return max - min;
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());   

// double[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);

// Console.WriteLine(Func(newArray));
