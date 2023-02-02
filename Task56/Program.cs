// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrix(5, 6, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumElemArray = SumElemArray(array2D);
PrintArray(sumElemArray); // Вывод в консоль делаем для удобства проверки результата.
int minSumRows = CountMinElemArray(sumElemArray) + 1; //Т.к метод выводит индекс, то добавляем в результат 1.
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRows}");

int CountMinElemArray(int[] arr)
{
    int minElem = arr[0];
    int minElemIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElem) minElemIndex = i;
    }
    return minElemIndex;
}

int[] SumElemArray(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];

        }
        result[i] = sum;
        sum = 0;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}, ");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.WriteLine(arr[i] + ".");
    }
}