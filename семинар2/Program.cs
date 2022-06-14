/* Задача 1
int NewNumber (int num)
{
    int a = num / 100;
    int b = num % 10;

    return a * 10 + b;
}

Console.Write("Будет сгенерировано случайное трехзначное число: ");
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

Console.Write("Из сгенерированого числа будет убрана 2-я цифра и получено новое двузначное число: ");
num = NewNumber (num);
Console.WriteLine(num);

ИЛИ

int NewNumber ()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Будет сгенерировано случайное трехзначное число: " + num);
    int a = num / 100;
    int b = num % 10;

    int result = a * 10 + b;
    return result;
}

Console.WriteLine("Из сгенерированого числа будет убрана 2-я цифра и получено новое двузначное число: " + NewNumber());
*/

/* Задача 2
void BMultipleOfA (int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления второго числа на первое равен " + num2 % num1);
    }
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

BMultipleOfA (num1, num2);

ИЛИ 

string BMultipleOfA (int num1, int num2)
{
    if (num2 % num1 == 0) //можно убрать фигурные скобки, если всего 1 действие совершается
    return "Второе число кратно первому";
    else
    return "Остаток от деления второго числа на первое равен " + num2 % num1;
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(BMultipleOfA (num1, num2));
*/

/* Задача 3
void NumMultipleOf7And23 (int num)
{
    if (num % 7 == 0 && num % 23 ==0)
    Console.WriteLine("Число кратно 7 и 23");
    else
    Console.WriteLine("Число не кратно 7 и 23");
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

NumMultipleOf7And23 (num);

ИЛИ
*/

bool NumMultipleOf7And23 (int num)
{
    if (num % 7 * 23 ==0)
    return true;
    else
    return false;

    // или записать вместо всего просто: return (num % 7 * 23 ==0);
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumMultipleOf7And23 (num));