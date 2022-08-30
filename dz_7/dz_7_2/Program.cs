//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите строчку, значение которого хотите получить: ");
int strok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбик, значение которого хотите получить: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int m = 4;
int n = 5;

int[,] array = new int[m, n];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
}
void PrintArray(int[,] matr)
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
PrintArray(array);
Console.WriteLine();

    if (strok < 0 | strok > array.GetLength(0) - 1 | stolb < 0 | stolb > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[strok, stolb]);
    }



 
    // Console.Write("Введите строку:");
    // int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
    // Console.Write("Введите столбец:");
    // int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
    // int n = 4;
    // int m = 5;
    // Random random = new Random();
    // int[,] arr = new int[n, m];
    // Console.WriteLine("Исходный массив:");
    // for (int i = 0; i < arr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < arr.GetLength(1); j++)
    //     {
    //         arr[i, j] = random.Next(10, 99);
    //         Console.Write("{0} ", arr[i, j]);
    //     }
    //     Console.WriteLine();
    // }
    // if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
    // {
    //     Console.WriteLine("Элемент не существует");
    // }
    // else
    // {
    //     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
    // }
    // Console.ReadLine();
 
