// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Введите длину трехмерного массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину трехмерного массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту трехмерного массива: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int mx = Convert.ToInt32(Console.ReadLine());

int sizeCube = r * c * d;
int[,,] array3D = new int[r, c, d];

if (mn > 9 && mx < 100)
{
    if (r * c * d < mx - mn) //если размер массива укладывается в возможный диапазон элементов
    {
        array3D = CreateCube(r, c, d, mn, mx);
        PrintCube(array3D);
    }
    else Console.WriteLine("Трехмерный массив, с указанными параметрами невозможно заполнить неповторяющимися числами.");
}
else Console.WriteLine("Задан неверный диапазон элементов массива. Массив необходимо заполнить двузначными числами.");


int[,,] CreateCube(int rows, int columns, int depth, int min, int max)
{
    int[,,] cube = new int[rows, columns, depth];
    int count = min;

    if (cube.Length < max - min - 1)
    {
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                for (int z = 0; z < cube.GetLength(2); z++)
                {
                    cube[i, j, z] = count;
                    count++;
                }
            }
        }
    }
    return cube;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int z = 0; z < cube.GetLength(2); z++)
            {
                Console.Write($"{cube[i, j, z]}({i},{j},{z})");
            }
        }
    }
}

