// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int m = 3;
int n = 4;
double[,] mass = new double[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().NextDouble() * (21 + 20) - 20;//NextDouble()*(max+1 - min) + min
        Console.Write("{0,6:F2}", mass[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
