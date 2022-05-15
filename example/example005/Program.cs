// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int m = 4;
int n = 3;
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
int summ = 0;
int size = mass.GetLength(0);//задали условие, чтобы не проверять его в else
if(mass.GetLength(1) < mass.GetLength(0))
{
size = mass.GetLength(1);
}
for (int i = 0; i < size; i++)
{


    summ = mass[i, i] + summ;


}
Console.Write(summ);