// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. 
// Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB. 
// Метод возвращает новую матрицу, которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы по умолчанию. 
// Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.

// Аргументы, передаваемые в метод/функцию:

// '1,2;3,4'
// На выходе:


// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50

// int InputInteger(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);

// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void FillArray(int[,] array)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = random.Next(0, 10);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }




// void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
// {
//     if (matrixA.GetLength(1) != matrixB.GetLength(0))
//     {
//         Console.WriteLine("It is impossible to multiply.");
//     }
//     else
//     {
//         int[,] array = MatrixMultiplication(matrixA, matrixB);
//     }

// }

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] array = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixB.GetLength(0); k++)
//             {
//                 array[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//             Console.Write($"{array[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return array;

// }


// int rows1 = InputInteger("Введите кол-во строк для матрицы 1: ");
// int columns1 = InputInteger("Введите кол-во столбцов для матрицы 1: ");

// int[,] matrixA = Create2DArray(rows1, columns1);
// FillArray(matrixA);
// int rows2 = InputInteger("Введите кол-во строк для матрицы 2: ");
// int columns2 = InputInteger("Введите кол-во столбцов для матрицы 2: ");

// int[,] matrixB = Create2DArray(rows2, columns2);
// FillArray(matrixB);
// Console.WriteLine("Исходная матрица:");
// PrintMatrix(matrixA);
// Console.WriteLine("Matrix B:");
// PrintMatrix(matrixB);

// System.Console.WriteLine(MultiplyIfPossible(matrixA,matrixB));



using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { 
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("It is impossible to multiply.");
        }
        else
        {
            MatrixMultiplication(matrixA, matrixB);
        }
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже
        int[,] array = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                    array[i, j] += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write($"{array[i,j]}\t");
            }
            Console.WriteLine();
        }
        return array;
    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    }
 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {1, 2},
                {3, 4},
                {2, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}