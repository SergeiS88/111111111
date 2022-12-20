// int Stepen(int a, int b){
//     int y = a;
//     for(int i = 1; i < b; i++){
//         y *= a;
//     }
//     return y;
// }

// Console.WriteLine("Ввод число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод число В: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Stepen(a, b);
// Console.WriteLine($"Результат - {c}");

/////////////////////Задача 2//////////////////////////

// int SumOfNums(int x){
//     int y = 0;
//     for(int i = 0; x!=0;i++){
//         y=y+x%10;
//         x = x/10;
//     }
//     return y;
// }

// Console.WriteLine("Ввод число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sumnum = SumOfNums(num);
// Console.WriteLine(sumnum);

////////////////////зАДАЧА 3/////////////////////////////

// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         myArray[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(lenght,min,max));