// Задайте двумерный массив размером m*n, заполненный случайными числами
// m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] matrix = new int [3,4];
void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-100,100);
        }
    }
}

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();