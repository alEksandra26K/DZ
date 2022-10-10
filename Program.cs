/*
//1
int number = new Random().Next(100, 999);
Console.WriteLine($"Ваше рандомное число от 100 до 999: {number}");
int number1 = (number / 10) % 10;
Console.WriteLine($"Рандомное число {number} , второе число {number1} "); 
*/

//2
/*int number = new Random().Next(1, 100000);
Console.WriteLine($"Ваше рандомное число от 1 до 100000: {number}");

if (number <= 99)
{
    Console.WriteLine("нет 3 цифры");
}
else if (number > 99 && number <= 999)
{
    Console.WriteLine($"3 цифра: {number % 10}");
}
else if (number > 999 && number < 10000)
{
    Console.WriteLine($"3 цифра: {(number / 10) % 10}");
}
else if (number > 9999 && number < 100000)
{
    Console.WriteLine($"3 цифра: {(number / 100) % 10}");
}
else
{
    Console.WriteLine("3 цифра: 0");
}*/




/*
//3
Console.WriteLine("Введите день недели");
int day = int.Parse(Console.ReadLine()!);
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
if (day == 2)
{
    Console.WriteLine("Вторник");
}
if (day == 3)
{
    Console.WriteLine("Среда");
}
if (day == 4)
{
    Console.WriteLine("Четверг");
}
if (day == 5)
{
    Console.WriteLine("Пятница");
}
if (day == 6)
{
    Console.WriteLine("Суббота");
}
if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
if (day >= 1 && day <= 5)
{
    Console.WriteLine("Не выходной");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Пожалуйста, введите число от 1 до 7");
}*/