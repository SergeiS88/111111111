/*Задача 19
Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

///////////////////////v1///////////////////////////

// bool IsPalindrom(int x){
//     bool y = true;
//     int k = 1;
//     int k2 = 10;
//     int i = 0;
//     while(x/k != 0){
//         k=k*10;
//         i++;}
//         k = k/10;
//     for(int j = 0; j < i/2; j++){
//         if(x/(k) != x%k2){y = false;}
//         k2 = k2*10;
//         k = k/10;}
//     return y;
// }

// Console.WriteLine("Введите число и узнаете палиндром ли это: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool fl = IsPalindrom(num);
// if(fl == true){Console.WriteLine("Палиндром");}
// else{Console.WriteLine("не палиндром");}


//////////////////v2////////////

// bool IsPalindrom(string ch){
//     bool f = true;
//     for(int i =0; i < ch.Length/2; i++){
//         int j = ch.Length-i-1;
//         if(ch[i] != ch[j]) f = false;
//     }
//     return f;
// }

// Console.WriteLine("Введите что-нибудь и узнаете палиндром ли это: ");
// string str = Console.ReadLine();
// bool fl = IsPalindrom(str);
// if(fl == true){
//     Console.WriteLine("палиндром");
// }
// else{
//     Console.WriteLine("не палиндром");
// }


/*Задача 21
Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в
3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// double Length(double x1, double y1, double z1, double x2, double y2, double z2){
//     double l = Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)),2);
//     return  l;
// }

// Console.WriteLine("Введите координаты первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// double y1 = Convert.ToDouble(Console.ReadLine());
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// double y2 = Convert.ToDouble(Console.ReadLine());
// double z2 = Convert.ToDouble(Console.ReadLine());
// double leng = Length(x1,y1,z1,x2,y2,z2);
// Console.WriteLine($"Длинна отрезка между ними {leng}");

/*Задача 23
Напишите программу, которая принимает на вход
число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

// void CubsFrom0(int x){
//     for (int i = 1; i <= x; i++){
//             Console.WriteLine (i*i*i);
//     }
// }

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// CubsFrom0(num); 



