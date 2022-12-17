// Задайте двумерный массив размера m на n, каждый элемент в масиве 
// находится по формуле: Amn = m+n. Выведите полученный массив
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] matrix = new int [3,4];
void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i + j;
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