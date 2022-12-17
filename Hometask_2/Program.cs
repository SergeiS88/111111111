////////////Задача 1////////////////////////////////////////////////

// int SecondDigit(int x)
// {
//     int a = x%100;
//     int y = a/10;
//     return y;
// }

// Console.WriteLine("Введите трёхзначное число: ");
// int InsertNum = Convert.ToInt32(Console.ReadLine());
// int Digit2 = SecondDigit(InsertNum);
// Console.WriteLine("Это вторая цифра вашего числа: ");
// Console.WriteLine(Digit2);

/////////////Задача 2//////////////////////////////////////////////

// int ThirdDigit(int x)
// {
//     return x/100;
// }

// Console.WriteLine("Введите трёхзначное число: ");
// int InsertNum = Convert.ToInt32(Console.ReadLine());
// if(InsertNum > 100)
// {
//     int digit3 = ThirdDigit(InsertNum);
// Console.WriteLine("Это третья цифра вашего числа: ");
// Console.WriteLine(digit3);
// }
// else 
// {
//     Console.WriteLine("Третьей цифры нет!");
// }

//////////////Задача 3///////////////////////////////////////

bool IsWeekend(int x)
{
    bool y = true;
    if(x < 6)
    {
    y = false;
    }
    return y;
}

Console.WriteLine("Введите цифру, обозначающую день недели и узнаете выходной ли он.");
int insertDay = Convert.ToInt32(Console.ReadLine());
while (insertDay > 7)
{
    Console.WriteLine("В неделе 7 дней! Попробуйте ещё раз:");
    insertDay = Convert.ToInt32(Console.ReadLine());
}

bool day = IsWeekend(insertDay);
if(day == true)
{
    Console.WriteLine("Выходной!!!");
}
else {Console.WriteLine("Нет, рабочий.");}
