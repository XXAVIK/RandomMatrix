using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов матрицы: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrixA = GenerateRandomMatrix(rows, cols);

        int[,] matrixB = GenerateRandomMatrix(rows, cols);

        Console.WriteLine("Матрица A:");
        PrintMatrix(matrixA);

        Console.WriteLine($"Сумма всех элементов: {CalculateSum(matrixA)}");

        Console.WriteLine("Матрица B:");
        PrintMatrix(matrixB);

        int[,] sumMatrix = AddMatrices(matrixA, matrixB);
        Console.WriteLine("Сумма матриц A и B:");
        PrintMatrix(sumMatrix);
    }

    // Метод для сложения двух матриц
    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    // Метод для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Метод для создания случайной матрицы
    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }

        return matrix;
    }

    // Метод для вычисления суммы элементов матрицы
    static int CalculateSum(int[,] matrix)
    {
        int sum = 0;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
            }
        }

        return sum;
    }
}

