// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = CreateMatrix(5, 2, 1, 10);
int[,] matrix2 = CreateMatrix(2, 3, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0)) //т.к. число столбцов матрицы1 должно быть равно числу строк матрицы2
{
    int[,] multiMatrix = MultiMatrix(matrix1, matrix2);
    PrintMatrix(multiMatrix);
} 
else Console.WriteLine("Произведение двух матриц невозможно.");

int[,] MultiMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int l = 0; l < arr2.GetLength(0); l++)
            {
                result[i, j] = result[i, j] + arr1[i, l] * arr2[l, j];
            }
        }
    }
    return result;
}

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

