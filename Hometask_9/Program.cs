/*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

// void PrintNum(int num)
// {
//     if(num > 0)
//     {
//         PrintNum(num-1);
//         Console.WriteLine(num);
//     }
// }
// int n = 3;
// PrintNum(n);

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// int SumBetween(int m, int n)
// {
//     int min = n;
//     if(m<n) min = m; 
//     if(m < n)
//     {
//         return n = n + SumBetween(m, n-1);
//     } 
//     if(m > n)
//     {
//         return m = m + SumBetween(m-1, n);
//     } 
//     return min;
// }
// Console.WriteLine(SumBetween(4,8));



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

// int Akkerman(int n, int m)
// {
//     if (n == 0) return m + 1;
//     if (n != 0 && m == 0) return Akkerman(n - 1, 1);
//     if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
//     return Akkerman(n,m);
// }
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Akkerman(n, m));
            