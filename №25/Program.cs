// Цикл принимает на вход два числа (А и В) и возводит А в натуральную степень В.


Console.Write("Введите число: ");
double a = Double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число: ");
int b = Int32.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Power(a, b));

double Power(double x, int y)
{

    double pow = x;
    for(int i = 1; i < y; i++)
    {
        pow *= x;
    }
    return pow;
}
