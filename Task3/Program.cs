// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] Create2DArray(int rows, int cols)
{
    return new double[rows, cols];
}

double[] CreateArray(int size)
{
    return new double[size];
}

void Fill2DArray(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

double[] ArithmeticalMean(double[,] array, double[] arrayRes)
{
    int k = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double res = 0;
        double arithMean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res = res + array[i, j];
            arithMean = Math.Round(res / (i + 1), 1);
        }
        arrayRes[k] = arithMean;
        k++;
    }
    return arrayRes;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void PrintArrayRes(double[] arrayRes)
{
    for (int k = 0; k < arrayRes.Length; k++)
    {
        Console.Write($"{arrayRes[k]}\t");
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");
double[,] my2DArray = Create2DArray(rows, columns);
Fill2DArray(my2DArray, minValue, maxValue);
Print2DArray(my2DArray);
Console.WriteLine();
double[] myResultArray = CreateArray(columns);
double[] result = ArithmeticalMean(my2DArray, myResultArray);
PrintArrayRes(result);

