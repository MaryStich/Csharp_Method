﻿// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, 
// на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате 
// "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, 
// округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

// Пример


// n = 3;
// m = 4;
// k = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));

/*
1   3   5   7   
9   11  13  15  
17  19  21  23  
The averages in columns are:
9.00    11.00   13.00   15.00
*/

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }


    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int value = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        }
        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        Console.WriteLine("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"{list[i]:f2}\t");
        }

    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        double[] average = new double[matrix.GetLength(1)];
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < columns; i++)
        {
            double sum = 0;
            for (int j = 0; j < rows; j++)
            {
                sum += matrix[j, i];
            }
            average[i] = sum / rows;
        }
        return average;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}