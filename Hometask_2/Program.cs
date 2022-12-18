//------------------------------Задача 1----------------
// int SecondDigit(int x = 0){
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
//     x = x%100/10;
//     return x;
// }
// void OutPutD2(int x){
//     Console.WriteLine("\nЭто вторая цифра вашего числа:\n");
//     Console.WriteLine(x);
// }

// OutPutD2(SecondDigit());
//------------------------------Задача 2---------------
long ThirdNum(long x = 0){
    while (true)
        {  
            try
            {
                Console.WriteLine("\nВведите число и я скажу вам его третью цифру : ");
                x = Convert.ToInt64(Console.ReadLine());
                break;
            }
            catch{}
        }
    x = x/100%10;
    return x;
}
void OutPutD3(long x){
    bool y = true;
    if(x == 0){
        y = false;
    }
    if(y == true){
        Console.Write("\n"+x);
        Console.WriteLine(" - Это третья цифра вашего числа: ");
    }
    else{
        Console.WriteLine("\nТретьей цифры нет!");
    }
}   

OutPutD3(ThirdNum());
//------------------------------Задача 2 __ v2--------
// char[] Enter(){
//     Console.WriteLine("Введите число чтоб увидеть его третью цифру: ");
//     string s = Console.ReadLine();
//     char[] n = new char[s.Length];
//     for(int i = 0; i < n.Length; i++){
//     n[i] = s[i];
//     }
//     return n;
// }
// void OutPutD3(char[] s){
//     if(s.Length < 3){
//         Console.WriteLine("Ваше число маловато!");
//     }
//     else{
//         int j = s.Length - 3;
//         Console.WriteLine(s[j]);
//     }
// }

// OutPutD3(Enter());
//------------------------------Задача 3-------------
// int EnterDayNum(int x = 0){
//     for(int i = 0; x > 7|x == 0; i++){ 
//         try
//         {
//             if(i>0){Console.WriteLine("\nПожалуйста введите цифру от 1 до 7 включительно.");
//                 Console.WriteLine("В неделе 7 дней!\nПн - 1\nВт - 2\nСр - 3\nЧт - 4\nПт - 5\nСб - 6\nВс - 7\n");}
//             if(i==0){Console.WriteLine("\nВведите цифру, обозначающую день недели и узнаете выходной ли он.\n");}
//                 x = Convert.ToInt32(Console.ReadLine());
//         }
//         catch{}
//     }
//     return x;
// }
// void IsWeekend(int x){   
//     bool y = true;
//     if(x < 6){
//         y = false;
//         }
//     if(y == true){
//     Console.WriteLine("\nВыходной!!!");
//     }
//     else {
//     Console.WriteLine("\nРабочий.");
//     }
// }

// IsWeekend(EnterDayNum());



