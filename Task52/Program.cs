// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк в массиве:");
int numberI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве:");
int numberJ = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixRndInt(numberI, numberJ, 0, 10);
PrintMatrix(array2d);
double[] result = ArithMeanByColumns(array2d, numberI, numberJ);
// double[] resultRound = Math.Round(result, 1);// не удается преобразовать из "double[]" в "decimal". сделал метод

System.Console.WriteLine("Среднее арифметическое каждого столбца:");
ResultRound(result);
System.Console.Write("[");
PrintArray(result);
System.Console.WriteLine("]");

double[] ArithMeanByColumns(double[,] matrix, int numI, int numJ)
{

    double[] array = new double[numJ];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        array[j] = sum / numI;
    }
    return array;
}

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{

    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" | ");
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},   ");
        else Console.Write($"{arr[i]}");
    }
}

void ResultRound(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i], 1);
    }
}