// Задача 1 (Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N)

void ShowNums (int n)
{
    if(n != 1) ShowNums(n - 1);
    
    Console.Write(n + " ");
}

// Console.Write("Введите число n ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNums(n);

// Задача 2 (Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N)

void ShowNumsFromMToN (int m, int n)
{
    if(n != m) ShowNumsFromMToN(m, n - 1);
    
    Console.Write(n + " ");
}

// Console.Write("Введите число m ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumsFromMToN(m, n);

// Задача 3 (Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр)

int NumbersSum(int n)
{
    int sum = 0;

    if(n != 0) return n % 10 + NumbersSum(n / 10);
    
    return 0;
}

// Console.Write("Введите число n ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NumbersSum(n));

// Задача 4 (Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии)

int Degree (int a, int b)
{
    if (b == 0) return 1;

    return a * Degree(a, b - 1);
}

Console.Write("Введите число, которое нужно возвести в степень ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(a, b));