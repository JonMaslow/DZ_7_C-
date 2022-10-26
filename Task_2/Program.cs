/*Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(-10, 10);
        }
    }
    return resultMatrix;
}

void LookNumberInArray(int[,] matrix, int number)
{
    foreach (int element in matrix)
    {
        if (element == number)
        {
            Console.WriteLine($"Массив содержит число {number}");
            return;
        }
    }
    Console.WriteLine($"Массив не содержит число {number}\n");
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("\nПолученный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int row = GetNumberFromConsole("Введите число строк:");
int column = GetNumberFromConsole("Введите число столбцов:");
int[,] matrix = InitMatrix(row, column);
int lookNumber = GetNumberFromConsole("Введите число для поиска его в массиве:\n");
PrintMatrix(matrix);
Console.WriteLine();
LookNumberInArray(matrix, lookNumber);
