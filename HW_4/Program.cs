// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponent(int number, int exp)
// {
//     int result = 1;
//     for(int i = 0; i<exp; i++)
//     {
//         result=result*number;
//     }
// return result;
// }

// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input exp.number: ");
// int exp = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Exponent(n, exp));

// ___________________________________________________________________________________________________________________
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FiguresSum(int number)
// {
//     int result = 0;
//     while (number / 10 > 0)
//     {
//         int fig = number % 10;
//         result = result + fig;
//         number /= 10;
//     }
//     number %= 10;
//     result = result + number;
//     return result;
// }
// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{n} -> {FiguresSum(n)}");


// ___________________________________________________________________________________________________________________
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] CreateRandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
int[] array = CreateRandomArray();
PrintArray(array);
