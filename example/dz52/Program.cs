// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.
int m =3;
int n = 4;
double summ = 0;
double composition = 0;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < mass.GetLength(1); j++)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        summ = summ + mass[i, j];


    }
    composition = summ / mass.GetLength(0);
    Console.Write(composition + " ");
    summ = 0;
}
