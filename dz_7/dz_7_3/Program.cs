//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите m: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// int count = 1;
// int[,] array = new int[m, n];
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }

//     }
// }
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
            
//         }
//         Console.WriteLine();
//     }

// FillArray(array);
// PrintArray(array);
// sqrt(array);
// Console.WriteLine();
// PrintArray(array);

Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr = new int [n, m];
int []sum = new int [m];


for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        arr[i, j] = new Random().Next(1, 10);

        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        sum[i] += arr[j, i];
    }
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    Console.Write((sum[i] / n)  + "\t");
}
