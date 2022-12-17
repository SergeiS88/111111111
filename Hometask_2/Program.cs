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
//     int y = x%100/10;
//     return y;
// }
// void OutPut(int x){
//     Console.WriteLine("\nЭто вторая цифра вашего числа:\n");
//     Console.WriteLine(x);
// }

// int i = 0;
// int num = EnterNum(i);
// int digit2 = SecondDigit(num);
// OutPut(digit2);

//------------------------------Задача 2-----------------------------------------------------------

// int EnterNum(int x){
//     int i = 0;
//     while (true)
//         {  
//             try
//             {
//                 if(i>0){Console.WriteLine("\nПожалуйста введите число.\n");}
//                 if(i==0){Console.WriteLine("\nВведите число и я скажу вам его третью цифру : \n");}
//                 x = Convert.ToInt32(Console.ReadLine());
//                 break;
//             }
//             catch{}
//             i++;
//         }
//     return x;
// }
// int ThirdDigit(int x){
//     int y;
//     y = x/100%10;
//     return y;
// }
// bool HowNumber(int x){
//     bool y = true;
//     if(x == 0){
//         y = false;
//     }
//     return y;
// }
// void OutPut(int x, bool y){
//     if(y == true){
//         Console.WriteLine("\nЭто третья цифра вашего числа: ");
//         Console.WriteLine(x);
//     }
//     else{
//         Console.WriteLine("\nТретьей цифры нет!");
//     }
// }   

// int i = 0;
// int number = EnterNum(i);
// int digit3 = ThirdDigit(number);
// bool trf = HowNumber(digit3);
// OutPut(digit3, trf);

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
// void OutPut(bool x){
//     if(x == true)
//     {
//     Console.WriteLine("\nВыходной!!!");
//     }
//     else 
//     {
//     Console.WriteLine("\nРабочий.\n");
//     }
// }

// int num = 0;
// int weekDay = EnterDayNum(num);
// bool day = IsWeekend(weekDay);
// OutPut(day);



