// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateRandomArray()
{
    int[] array = new int[12];
    for (int i = 0; i < 12; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    // Console.WriteLine();
}

int ArraySum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i];
    }
    return result;
}

void PosNegSum(int[] array)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            pos += array[i];
        }
        else
        {
            neg +=array[i];
        }
    }
    System.Console.WriteLine($"Sum of positive array elements -> {pos}\nSum of negative array elements -> {neg}");
}

int[] myArray = CreateRandomArray();
PrintArray(myArray);

// ArraySum(myArray);
PosNegSum(myArray);

// ______________________________________________________________________________________________________________
// *Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int[] CreateRandomArray()
// {
//     int[] array = new int[15];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 124);
//     }
//     return array;
// }

// int FindDoubleDigit(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] myArray = CreateRandomArray();
// PrintArray(myArray);
// System.Console.WriteLine();
// System.Console.WriteLine(FindDoubleDigit(myArray));

// _________________________________________________________________________________________________
// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// bool FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     if (array[i] == number)
//     {
//         return true;
//     }
//     }
// return false;
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min rndm: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max rndm: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number to find: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);

// PrintArray(myArray);
// System.Console.WriteLine();
// System.Console.Write(number + " -> ");
// System.Console.WriteLine(FindNumber(myArray, number));


// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int[] CreateRandomArray()
// {
//     int[] array = new int[10];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     return array;
// }


// int[] ChangePos2Neg(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// int[] myArray = CreateRandomArray();
// System.Console.Write("Изначальный массив: -> ");
// PrintArray(myArray);
// System.Console.WriteLine();
// System.Console.Write("Зеркальный массив: -> ");
// PrintArray(ChangePos2Neg(myArray));
