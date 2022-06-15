/* Задача 1
bool Polyndrom (int num)
{
    if (num / 10000 == num % 10)
    {
        num = num - (num % 10000);
        num = num % 10;
        if (num / 100 == num % 10)
        return true;
        else return false;
    }
    else return false;
}

Console.Write("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 10000 != 0)
    Console.WriteLine(Polyndrom(num));
else
    Console.Write("Введенное число не пятизначное");
*/

/* Задача 2

double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
}

Console.WriteLine("Введите координаты первой точки (x, y, z), каждая с новой строки ");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x, y, z), каждая с новой строки ");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindLenght(xA, yA, zA, xB, yB, zB));

*/

// /* Задача 3
void Find3Degree(int N)
{
    if (N > 0)
    {
        int i = 1;
        while (i <= N)
        {
            Console.Write(Math.Pow(i, 3) + " ");
            i ++;
        }
    }
    else Console.Write("Введено отрицательное число или 0");
}

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Find3Degree(N);
// */