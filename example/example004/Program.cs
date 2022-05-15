// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса равны друг другу, и замените эти элементы на их
// квадраты.
int m = 4;
int n = 3;
int [,] mass = new int [m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j]=new Random().Next(1,10);
     
        Console.Write(mass[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
          if(i==j)
        {
            mass[i,j]=mass[i,j]*mass[i,j];
        }
        Console.Write(mass[i,j]+" ");
    }
    Console.WriteLine();
}