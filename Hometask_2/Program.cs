//------------------------------Задача 1------------------------------------------------------------

// int EnterNum(int x){
//     for(int i = 0; x > 999|x < 100; i++)
//         {   
//         try
//             {
//             if(i>0){Console.WriteLine("\nПожалуйста введите трёхзначное число:\n");}
//             if(i==0){Console.WriteLine("\nВведите трёхзначное число и я скажу вам вторую его цифру:\n");}
//             x = Convert.ToInt32(Console.ReadLine());
//             }
//         catch{}
//         }
//     return x;
// }
// int SecondDigit(int x){
//     x = x%100/10;
//     return x;
// }
// void OutPutD2(int x){
//     Console.WriteLine("\nЭто вторая цифра вашего числа:\n");
//     Console.WriteLine(x);
// }

// int start = 0;
// int num = EnterNum(start);
// int digit2 = SecondDigit(num);
// OutPutD2(digit2);

//------------------------------Задача 2-----------------------------------------------------------

// int EnterNum(int x){
//     while (true)
//         {  
//             try
//             {
//                 Console.WriteLine("\nВведите число не более девятизначного\nи я скажу вам его третью цифру : ");
//                 x = Convert.ToInt32(Console.ReadLine());
//                 break;
//             }
//             catch{}
//         }
//     return x;
// }
// int ThirdDigit(int x){
//     x = x/100%10;
//     return x;
// }
// bool HowNumber(int x){
//     bool y = true;
//     if(x == 0){
//         y = false;
//     }
//     return y;
// }
// void OutPutD3(int x, bool y){
//     if(y == true){
//         Console.WriteLine("\nЭто третья цифра вашего числа: ");
//         Console.WriteLine(x);
//     }
//     else{
//         Console.WriteLine("\nТретьей цифры нет!");
//     }
// }   

// int start = 0;
// int number = EnterNum(start);
// int digit3 = ThirdDigit(number);
// bool trf = HowNumber(digit3);
// OutPutD3(digit3, trf);

//------------------------------Задача 3------------------------------------------------------------

// int EnterDayNum(int x){
//     for(int i = 0; x > 7|x == 0; i++)
//     {       try
//                 {
//                 if(i>0){Console.WriteLine("\nПожалуйста введите цифру от 1 до 7 включительно.");
//                     Console.WriteLine("В неделе 7 дней!\nПн - 1\nВт - 2\nСр - 3\nЧт - 4\nПт - 5\nСб - 6\nВс - 7\n");}
//                 if(i==0){Console.WriteLine("\nВведите цифру, обозначающую день недели и узнаете выходной ли он.\n");}
//                     x = Convert.ToInt32(Console.ReadLine());
//                 }
//             catch{}
//     }
//     return x;
// }
// bool IsWeekend(int x){   

//     bool y = true;
//     if(x < 6)
//     {
//     y = false;
//     }
//     return y;
// }
// void OutPutDay(bool x){
//     if(x == true)
//     {
//     Console.WriteLine("\nВыходной!!!");
//     }
//     else 
//     {
//     Console.WriteLine("\nРабочий.");
//     }
// }

// int start = 0;
// int weekDay = EnterDayNum(start);
// bool day = IsWeekend(weekDay);
// OutPutDay(day);



