Console.Clear();
Console.WriteLine("Хотите узнать какое из двух чисел больше?");
Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2){
    Console.WriteLine("Первое число больше второго.");
}
else if(num1 < num2){
     Console.WriteLine("Второе число больше первого.");
}
else Console.WriteLine("Ваши числа равны");
Console.WriteLine();

Console.WriteLine("А Хотите узнать какое из ТРЁХ чисел будет большим?");
Console.WriteLine("Введите первое число:");
int num11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num22 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите и третье число:");
int num33 = Convert.ToInt32(Console.ReadLine());
int max = num11;
if(num2 > max){
    max = num22;}
if(num33 > max){
    max = num33;}
Console.WriteLine($"число {max} Самое большое");
Console.WriteLine();

Console.WriteLine("Введите число и вы узнаете чётное ли оно:");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2 == 0){
    Console.WriteLine("Ваше число чётное.");}
else{
    Console.WriteLine("Ваше число не чётное.");
}
Console.WriteLine();

Console.WriteLine("Введите число и узнаете все натуральные чётные числа меньше вашего:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i < num){
    if(i%2 == 0){
        Console.Write(i + ",");
    }
    i++;
}
Console.WriteLine();
Console.WriteLine("Спасибо за винмание!");
