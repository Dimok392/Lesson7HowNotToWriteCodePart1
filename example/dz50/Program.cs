// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.WriteLine("Введите номер Строки");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер Столбца");
int column = int.Parse(Console.ReadLine());
int m = 5;
int n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 100);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
bool b = false;
for (int i = line; i < mass.GetLength(0); i++)
{
    for (int j = column; j < mass.GetLength(1); j++)
    {
        if (i == line && j == column) b=true;
    }
    
}
if (b) Console.WriteLine(mass[line, column] + " ");
else Console.WriteLine($"в массиве нет такого элемента");