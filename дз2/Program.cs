/* Задача 1

int SecondNumber (int num)
{
int num2 = num / 10;
num2 = num2 % 10;
return num2;
}

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000)
Console.WriteLine("Вторая цифра введенного числа " + SecondNumber(num));
else
Console.WriteLine("Введенное число не трехзначное");
*/


/* Задача 2
int ThirdNumber (int num)
{
int result;
if (num / 10 != 0)
    {
    num = num / 10;
    if (num / 10 != 0)
        {
        num = num / 10;
        result = num % 10;
        }
    else result = -1;
    }
else result = -1;

return result;
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdNumber(num);

if (ThirdNumber(num) == -1)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine("Третья цифра " + ThirdNumber(num));

Задача 2 (второе решение)
void ThirdNumber (int num)
{
int result;
if (num / 10 != 0)
    {
    num = num / 10;
    if (num / 10 != 0)
        {
        num = num / 10;
        result = num % 10;
        Console.WriteLine("Третья цифра " + result);
        }
    else
    Console.WriteLine("Третьей цифры нет");
    }
else
Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdNumber(num);
*/

/* Задача 3
int DayOfTheWeek (int num)
{
int result;
if (num >=1 && num < 6)
    result = 1;
else 
    result = 0;

return result;
}

Console.WriteLine("Введите число, соответствующее порядковому номеру дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num < 8)
{
    if (DayOfTheWeek(num) == 1)
        Console.WriteLine("Введенный день недели не выходной");
    else
        Console.WriteLine("Введенный день недели выходной");
}
else
Console.WriteLine("Введенное число не соответствует условиям");
*/

// Задача 3 (второе решение)
void DayOfTheWeek (int num)
{
if (num >=1 && num < 6)
    Console.WriteLine("Введенный день недели не выходной");
else 
    Console.WriteLine("Введенный день недели выходной");
}

Console.WriteLine("Введите число, соответствующее порядковому номеру дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num < 8)
{
    DayOfTheWeek(num);
}
else
Console.WriteLine("Введенное число не соответствует условиям");