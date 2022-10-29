/*Задача 52.
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[,] InitMatrix(int m, int n)
{
    double[,] resultMatrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(1, 10);
        }
    }
    return resultMatrix;
}

double[] GetMatrixModified(double[,] resultMatrix)
{
    double[] matrixModified = new double[resultMatrix.GetLength(1)];
    double summ = new double();
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        summ = 0;
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            summ += resultMatrix[i, j];
            matrixModified[j] = summ;
            matrixModified[j] = matrixModified[j] / resultMatrix.GetLength(0);
        }
    }
    return matrixModified;
}
void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("\nИзначальный массив:\n");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintMatrixModified(double[] matrixModified)
{
    Console.WriteLine("\nСреднее арифметическое каждого столбца:\n");
    for (int i = 0; i < matrixModified.Length; i++)
    {
        Console.Write("{0,7:F1}", matrixModified[i]);
    }
}

int row = GetNumberFromConsole("Введите число строк:");
int column = GetNumberFromConsole("Введите число колонок:");
double[,] initialMatrix = InitMatrix(row, column);
double[] matrixModified = GetMatrixModified(initialMatrix);
PrintMatrix(initialMatrix);
PrintMatrixModified(matrixModified);