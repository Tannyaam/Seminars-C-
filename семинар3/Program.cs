/* Задача 1 (В какой четверти находится точка)

int FindQuarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1; // не ставим доп условий, т.к. -1 получится только в случае, если по предыдущим if наши координаты никуда не подойдут
    // если произошел любой return, то метод завершает работу
}

Console.Write("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());

int result = FindQuarter(x, y);

if (result == -1)
    Console.WriteLine("Данная точка находится на осях");
else
    Console.WriteLine($"Данная точка находится в {result} четверти");
*/

/* Задача 2 (Какие координаты могут быть в указанной четверти)
void FindXY (int num)
{
    if (num == 1) Console.WriteLine("Координаты соответствуют условиям: х > 0 и y > 0");
    if (num == 2) Console.WriteLine("Координаты соответствуют условиям: х < 0 и y > 0");
    if (num == 3) Console.WriteLine("Координаты соответствуют условиям: х < 0 и y < 0");
    if (num == 4) Console.WriteLine("Координаты соответствуют условиям: х > 0 и y < 0");
}
Console.Write("Введите номер четверти (от 1 до 4) ");
int num = Convert.ToInt32(Console.ReadLine());
FindXY(num);
*/

/* Задача 3 (Вывести квадраты чисел до N)
void FindSquareFrom1ToN (int N)
{
    int i = 1;
    while (i <= N)
    {
        int result = i * i;
        i ++;
        Console.Write(result + " ");
    }
    Console.Write("Введено отрицательное число или 0 ");
}

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
FindSquareFrom1ToN (N);

double FindLenght(double xA, double yA, double xB, double yB)
{
    Math.Sqrt((xB - xA) * (xB - xA) + Math.Pow((yB - yA),2)); // SQRT - получение корня, Pow - возведение в указанную степень
}
*/