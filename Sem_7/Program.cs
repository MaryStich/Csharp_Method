// Задайте двумерный массив случайных чисел m х n

// int InputInteger(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!); // ! ставится для команды Parse, тк она не сможет обработать пустую строку. ! дает понять, что мы это знаем и контролируем ввод.

// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void FillArray(int[,] array, int min, int max)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = random.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t"); //Используем табуляцию, тк при использовании пробелов и чисел разной разрядности, таблица съедет.
//         }
//         Console.WriteLine();
//     }
// }

// int rows = InputInteger("Введите кол-во строк: ");
// int columns = InputInteger("Введите кол-во столбцов: ");
// int min = InputInteger("Минимальное значение: ");
// int max = InputInteger("Максимальное значение: ");

// int[,] myArray = Create2DArray(rows, columns);
// FillArray(myArray, min, max);
// Print2DArray(myArray);

// ____________________________________________________________________________________________________
// Задайте двумерный массив случайных чисел m х n. Каждый элемент в массиве находится по формуле Аmn=m+n

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
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = i+j;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t"); //Используем табуляцию, тк при использовании пробелов и чисел разной разрядности, таблица съедет.
//         }
//         Console.WriteLine();
//     }
// }

// int rows = InputInteger("Введите кол-во строк: ");
// int columns = InputInteger("Введите кол-во столбцов: ");


// int[,] myArray = Create2DArray(rows, columns);
// FillArray(myArray);
// Print2DArray(myArray);

// __________________________________________________________________________________________
// Задайте двумерный массив, найдите эл-ты у которых оба индекса четные, замените эти элементы на их квадраты.

// int InputInteger(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!); // ! ставится для команды Parse, тк она не сможет обработать пустую строку. ! дает понять, что мы это знаем и контролируем ввод.

// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void FillArray(int[,] array, int min, int max)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = random.Next(min, max + 1);
// }

// int[,] ChangeEvenIndexNums(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i%2==0 && j%2==0)
//             {
//                 array[i,j]*=array[i,j];
//             }
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t"); //Используем табуляцию, тк при использовании пробелов и чисел разной разрядности, таблица съедет.
//         }
//         Console.WriteLine();
//     }
// }

// int rows = InputInteger("Введите кол-во строк: ");
// int columns = InputInteger("Введите кол-во столбцов: ");
// int min = InputInteger("Минимальное значение: ");
// int max = InputInteger("Максимальное значение: ");

// int[,] myArray = Create2DArray(rows, columns);
// FillArray(myArray, min, max);
// System.Console.WriteLine("Исходный массив: ");
// Print2DArray(myArray);
// System.Console.WriteLine("Скорректированный массив: ");
// Print2DArray(ChangeEvenIndexNums(myArray));


// ___________________________________________________________________________________________________

// Задайте двумерный массив, найти сумму эл-тов находящ на главной диагонали (i==j).

int InputInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!); // ! ставится для команды Parse, тк она не сможет обработать пустую строку. ! дает понять, что мы это знаем и контролируем ввод.

}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(min, max + 1);

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
}

int FindMinSide(int rows, int columns)
{
    if (rows < columns)
        return rows;
    else
        return columns;
}

int GetSumMainDiagonal(int[,] array, int rows, int columns)
{
    int minSide = FindMinSide(rows, columns);
    int sum = 0;

    for (int i = 0; i < minSide; i++)
    {
        sum += array[i, i];
    }
    return sum;
}



int rows = InputInteger("Введите кол-во строк: ");
int columns = InputInteger("Введите кол-во столбцов: ");
int min = InputInteger("Минимальное значение: ");
int max = InputInteger("Максимальное значение: ");

int[,] myArray = Create2DArray(rows, columns);
FillArray(myArray, min, max);
Print2DArray(myArray);
System.Console.Write($"\nСумма главной диагонали: {GetSumMainDiagonal(myArray, rows, columns)}");

