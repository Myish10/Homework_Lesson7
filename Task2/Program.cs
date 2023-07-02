// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PosNum(int[,] array, int rows, int cols, int num)
{
    // int numItems = rows * cols;
    int k = 1;
    if (num < 1 || num > rows * cols)
        Console.WriteLine($"Числа с номером {num} в массиве нет");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (k == num) Console.WriteLine($"Число с номером {num} --> {array[i, j]}");
                k++;
            }
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение массива: ");
int maxValue = InputNum("Введите максимальное значение массива: ");
int number = InputNum("Введите номер позиции числа: ");


int[,] my2DArray = Create2DArray(rows, columns);
Fill2DArray(my2DArray, minValue, maxValue);
Print2DArray(my2DArray);
PosNum(my2DArray, rows, columns, number);