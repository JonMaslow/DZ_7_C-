/*Задача 47.
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[,] InitMatrix(int m, int n)
{
    int [,] matrix = new int [m,n];
    double[,] resultMatrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(-1000,1000);
            resultMatrix[i,j] = Convert.ToDouble(matrix[i,j])/100;
        }
    }
    return resultMatrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            Console.Write("{0,9:F2}", matrix[i,j]);
        }
        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите число m:");
int n = GetNumberFromConsole("Введите число n:");
double[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
