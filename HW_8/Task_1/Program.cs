// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход двумерный массив целых чисел matrix 
// и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.

// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'
// На выходе:


// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Матрица с упорядоченными по убыванию строками:
// 9   7   1   
// 3   2   1   
// 6   5   4

int InputInteger(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);

}


int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0, 10);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}


void SortRowsDescending(int[,] matrix)
{
    int b = matrix.GetLength(1); // количество столбцов = 3
    for (int c = 0; c < matrix.GetLength(0); c++) // идем по строкам
    {
        for (int j = 0; j < b; j++) // пока номер столбца  их меньше количества
        {
            for(int i = 0;i<b-1;i++) // для элемента столбца меньшего, чем количество столбцов-1
            {
                if (matrix[c, i] < matrix[c, i + 1])
                {
                    int temp = matrix[c, i];
                    matrix[c, i] = matrix[c, i + 1];
                    matrix[c, i + 1] = temp;
                }
            }

        }
    }

}

int rows = InputInteger("Введите кол-во строк: ");
int columns = InputInteger("Введите кол-во столбцов: ");
Console.WriteLine("Исходная матрица:");
int[,] matrix = Create2DArray(rows, columns);
FillArray(matrix);

PrintMatrix(matrix);

SortRowsDescending(matrix);

Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
PrintMatrix(matrix);
System.Console.WriteLine($"{matrix.GetLength(1)}");

void SortRowsDescending(int[,] matrix)
    {
        int j = 0;
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)               //checking all rows
        {
            for (j = 0; j < matrix.GetLength(1); j++)                //Starting from each element in column
            {
                int max = j;
                for (k = j; k < matrix.GetLength(1); k++)            // checking if any number is greater than in j-position
                {
                    if (matrix[i, max] < matrix[i, k])                         // if new max if found remeber its position                                          
                    {
                        max = k;
                    }
                }
                var temp = matrix[i, max];                      // Swap max and current j-position
                matrix[i, max] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
    }