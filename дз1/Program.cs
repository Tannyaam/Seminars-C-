/* Задача 1

int num1, num2;

Console.Write("Введите первое число ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max=" + num1);
}
else
{
    Console.WriteLine("max=" + num2);
}
*/



/* Задача 2

int num1, num2, num3;

Console.Write("Введите первое число ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("max=" + num1);
    }
    else
    {
        Console.WriteLine("max=" + num3);
    }
}
else
{
    if(num2 > num3)
    {
        Console.WriteLine("max=" + num2);
    }
    else
    {
        Console.WriteLine("max=" + num3);
    }
}
*/


/* Задача 3


int num;

Console.Write("Введите число ");
num = Convert.ToInt32(Console.ReadLine());

if(num% 2 == 0 )
{
    Console.Write("Введенное число четное");
}
else 
{
    Console.Write("Введенное число нечетное");
}
*/


/* Задача 4

int N;
Console.Write("Введите число ");
N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= N)
{
    Console.Write(current + " ");
    current +=2;
}
*/