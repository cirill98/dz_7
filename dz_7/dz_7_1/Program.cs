//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите высоту: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

void FillArray(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Math.Round(new Random().NextDouble(), 2);
            matr [i, j] = rand.Next(-10, 10) + Math.Round(new Random().NextDouble(), 2);
        }
    }
}

void Print(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
FillArray(array);
Print(array);