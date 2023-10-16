//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую(любую) и последнюю(с любой) строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2


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
    Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{   
    row1-=1;
    row2-=1;
    if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
    {
        Console.WriteLine("Index of row is out of bound");
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    }
}

int rows = InputInteger("Введите кол-во строк: ");
int columns = InputInteger("Введите кол-во столбцов: ");
int min = InputInteger("Минимальное значение: ");
int max = InputInteger("Максимальное значение: ");
int row1 = InputInteger("Первая строка для замены: ");
int row2 = InputInteger("Вторая строка для замены: ");

int[,] myArray = Create2DArray(rows, columns);
FillArray(myArray,min,max);
Print2DArray(myArray);
ChangeRows(myArray, row1,row2);
Print2DArray(myArray);

// ______________________________________________________________________________________________-

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

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
//             Console.Write($"{array[i, j]} ");

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Rows2Columns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//         Console.WriteLine("Invalid array!");
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j = i+1;j<array.GetLength(1);j++)
//         {
//             int temp=array[i,j];
//             array[i,j]=array[j,i];
//             array[j,i]=temp;
//         }
//     }
// }

// int rows = InputInteger("Введите кол-во строк: ");
// int columns = InputInteger("Введите кол-во столбцов: ");
// int min = InputInteger("Минимальное значение: ");
// int max = InputInteger("Максимальное значение: ");

// int[,] myArray = Create2DArray(rows, columns);
// FillArray(myArray,min,max);
// Print2DArray(myArray);
// Rows2Columns(myArray);
// Print2DArray(myArray);

// _________________________________________________________________________
//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// void FindMinNum(int[,] array)
// {
//     int min = array[0, 0];
//     int minI = 0;
//     int minJ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }

// }


// int[,] ClearRowColumnWithMin(int[,] array)
// {
//     int min = array[0, 0];
//     int minI = 0;
//     int minJ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minI, j] = 0;
//     }
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minJ] = 0;
//     }
//     return array;
// }


// int rows = InputInteger("Введите кол-во строк: ");
// int columns = InputInteger("Введите кол-во столбцов: ");
// int min = InputInteger("Минимальное значение: ");
// int max = InputInteger("Максимальное значение: ");

// int[,] myArray = Create2DArray(rows, columns);
// FillArray(myArray, min, max);
// Print2DArray(myArray);
// ClearRowColumnWithMin(myArray);
// Print2DArray(myArray);

