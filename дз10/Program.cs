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

// Задача 1 (Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву)
int CountWordsStartsWithVowels (string[] array)
{
    char[] vowelsEn = {'a', 'e', 'i', 'o', 'u', 'y'};
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].ToLower();
        
        for (int j = 0; j < vowelsEn.Length; j++)
            if(array[i][0] == vowelsEn[j]) count++;
    }
    return count;
}

/*
Console.Write("Введите количество слов ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(size);

Console.WriteLine("Количество слов, которые начинаются с гласной: " + CountWordsStartsWithVowels(array));
*/

// Задача 2 (Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно)

string[] CombiningElements(string[] array)
{
    string[] newArray = new string[array.Length/2];
    int j = 0;

    for (int i = 0; i < array.Length; i+=2)
    {
        newArray[j] = array[i] + array[i + 1];
        j++;
    }
    return newArray;
}

Console.Write("Введите количество слов ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(size);
ShowArray(CombiningElements(array));