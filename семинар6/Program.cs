// Задача 1 (переворачиваем массив)

int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1;

    for (int i = 0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}


/* 
int[] myArray = FillArray(3, -9, 9);
myArray = ReverseArray(myArray);
*/

int[] PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    return array;
}


// Задача 2 (Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины)

bool CheckSides(int side1, int side2, int side3)
{
    if(side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2) return true;
    else return false;
}

/*
int side1 = Convert.ToInt32(Console.ReadLine());
int side2 = Convert.ToInt32(Console.ReadLine());
int side3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckSides(side1, side2, side3));
*/

// Задача 3 (Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1)
int[] Fibonacci(int n)
{
    int[] arrayF = new int[n];
    arrayF[0] = 0;
    arrayF[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arrayF[i] = arrayF[i - 1] + arrayF[i - 2];
    }
    return arrayF;
}

/*
int[] arrayF = Fibonacci(9);
PrintArray(arrayF);
*/

// Задача 4 (Напишите программу, которая будет преобразовывать десятичное число в двоичное)

string ConversionTo2 (int n)
{
    string conversion = string.Empty;
        while(n > 0)
    {
        conversion = n % 2 + conversion;
        n = n / 2;
    }
    return conversion;
}

Console.WriteLine(ConversionTo2(2));