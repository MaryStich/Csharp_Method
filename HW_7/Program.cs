//задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//внутри класса answer напишите метод createrandommatrix, который принимал бы числа m и n (размерность массива), а также minlimitrandom и maxlimitrandom,
//которые указывают на минимальную и максимальную границы случайных чисел.

//также, задайте метод printarray, который выводил бы массив на экран.

//для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и
//добавления символа табуляции (\t) после каждого элемента матрицы. таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

//m = 3, n = 4, minlimitrandom = -10, maxlimitrandom = 10

//0,5    7    -2    -0,2
//1    -3,3    8    -9,9
//8    7,8    -7,1    9

//using System;

//public class Answer
//{
//    public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
//    {
//        double[,] matrix = new double[m, n];
//        Random random = new Random();
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom) + random.NextDouble();
//            }
//        }
//        return matrix;

//    }

//    public static void PrintArray(double[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:f2}\t");

//            }
//            Console.WriteLine();
//        }
//    }

//    // Не удаляйте и не меняйте метод Main! 
//    public static void Main(string[] args)
//    {
//        int m, n, minLimitRandom, maxLimitRandom;

//        if (args.Length >= 4)
//        {
//            m = int.Parse(args[0]);
//            n = int.Parse(args[1]);
//            minLimitRandom = int.Parse(args[2]);
//            maxLimitRandom = int.Parse(args[3]);

//            double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

//            // Выберем случайные индексы трех элементов матрицы array
//            int row1 = new Random().Next(0, m);
//            int col1 = new Random().Next(0, n);
//            int row2 = new Random().Next(0, m);
//            int col2 = new Random().Next(0, n);
//            int row3 = new Random().Next(0, m);
//            int col3 = new Random().Next(0, n);

//            // Проверяем, являются ли выбранные элементы дробными числами
//            bool isFractional1 = (array[row1, col1] % 1) != 0;
//            bool isFractional2 = (array[row2, col2] % 1) != 0;
//            bool isFractional3 = (array[row3, col3] % 1) != 0;

//            // Если два из трех элементов не являются дробными числами, то бросаем исключение
//            if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
//            {
//                Console.WriteLine("Все ок!");
//            }
//            else
//            {
//                throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
//            }
//        }
//        else
//        {
//            m = 3;
//            n = 4;
//            minLimitRandom = -10;
//            maxLimitRandom = 10;

//            double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//            PrintArray(result);
//        }
//    }
//}


// _________________________________________________________________________________________________________________________________________

//Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

//Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число.
//Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

//Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
//Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.

//Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице.
//Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением.
//Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции,
//а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

//Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице.
//Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition.
//Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

//Пример


//n = 3;
//m = 4;
//k = 2;
//x = 8;
//y = 3;

//int[,] result = CreateIncreasingMatrix(n, m, k);
//PrintArray(result);
//PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

///*
//1   3   5   7   
//9   11  13  15  
//17  19  21  23  
//There is no such index
//*/

//n = 4;
//m = 5;
//k = 3;
//x = 2;
//y = 2;

//int[,] result = CreateIncreasingMatrix(n, m, k);
//PrintArray(result);
//PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

///*
//1   4   7   10  13  
//16  19  22  25  28  
//31  34  37  40  43  
//46  49  52  55  58  
//The number in [2, 2] is 37
//*/

using System;

public class Answer {

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
        int[,] matrix = new int[m, n];
        matrix[0, 0] = 1;
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                matrix[i, j] += k;
            }
        }
        return matrix;

    }
    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        if (matrix[rowPosition, columnPosition] == null)
        {
            return new int[] {0};
        }
        else
        {
            int results = { matrix[rowPosition, columnPosition], 0 };
        }
        return results;

    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        if (results[0] == 0)
        {
            Console.WriteLine("There is no such index");
        }
        else
        {
            Console.WriteLine($"The number in [{X,Y}] is {matrix[X, Y]}");
        }


    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 2;
            y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}