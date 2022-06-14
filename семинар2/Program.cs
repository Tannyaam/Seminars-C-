/* Задача 1
int NewNumber (int num)
{
    int a = num / 100;
    int b = num % 100;
    int c = b % 10;

    return a * 10 + c;
}

Console.Write("Будет сгенерировано случайное трехзначное число: ");
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

Console.Write("Из сгенерированого числа будет убрана 2-я цифра и получено новое двузначное число: ");
num = NewNumber (num);
Console.WriteLine(num);
*/

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