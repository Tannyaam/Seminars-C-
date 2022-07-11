string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} слово: "); 
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задача 1 (Посчитать кол-во слов, в которых кол-во букв 5 и больше)

int NumberOfLongWords(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i].Length >= 5) count++;

    return count;
}

/*
Console.Write("Введите количество имен ");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine("Кол-во слов " + NumberOfLongWords(names));
*/


// Задача 2 (Написать программу, которая принимает на вход два массива строк и возвращает массив из попарно объединенных исходных элементов)
string[] JoinStringArray(string[] array1, string[] array2)
{
    if(array1.Length > array2.Length)
    {
        for (int i = 0; i < array2.Length; i++)
        {
            array1[i] = array1[i] + " " + array2[i];
        }
        return array1;
    }
    else
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array2[i] = array1[i] + " " + array2[i];
        }
        return array2;
    }
}

/*
Console.Write("Введите количество имен для 1 массива ");
int sizeNamesArray = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(sizeNamesArray);
Console.Write("Введите количество приветствий для 2 массива ");
int sizeWords = Convert.ToInt32(Console.ReadLine());
string[] words = CreateStringArray(sizeWords);
ShowArray(JoinStringArray(words, names));
*/


// Задача 3 (Написать программу, которая считает кол-во слов, начинающихся на букву Y или W)
int CountWordsStartsWithYOrW(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].ToLower();

        if(array[i][0] == 'y' || array[i][0] == 'w')
            count++;
    }

    return count;
}


Console.Write("Введите количество слов ");
int size = Convert.ToInt32(Console.ReadLine());
string[] words = CreateStringArray(size);

/* Console.Write("Введите искомую букву 1 ");
char Letter1 = Convert.ToChar(Console.ReadLine());

Console.Write("Введите искомую букву 2 ");
char Letter2 = Convert.ToChar(Console.ReadLine());
*/

Console.WriteLine("Кол-во слов, которые начинаются с 'y' или 'w' " + CountWordsStartsWithYOrW(words));



