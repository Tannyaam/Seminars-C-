/* Задача 1
int FindSumOfDigits(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;  // sum += num % 10; 
        num = num / 10;        // num /= 10
    }
    return sum;
}
*/

/* Задача 2 (принимает на вход число N, выводит сумму чисел от 1 до N)

int FindSum (int num)
{
    int sum = 0;
    int i = 1;

    while(i <= num)
    {
        sum = sum + i;
        i++;
    }
    return sum;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(FindSum(num));
*/


/* Задача 3 (принимает на вход число N, выводит произведение чисел от 1 до N)

int FindFactorial (int num)
{
    int sum = 1;
    int i = 1;

    while(i <= num)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(FindFactorial(num));
*/

// Задача 4 (принимает на вход число N, выводит кол-во цифр в этом числе)

int FindDigitsCount (int num)
{
    int i = 0;

    while(num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(FindDigitsCount(num));