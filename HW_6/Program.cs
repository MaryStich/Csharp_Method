// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    System.Console.Write("\n[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine("]");
}

// System.Console.WriteLine("Input array size: ");
// int size = int.Parse(Console.ReadLine());
// int[] array = new int[size];

System.Console.WriteLine("Input array : ");
string[] input = Console.ReadLine();
// // int result = Convert.ToInt32(input);
return input;
System.Console.WriteLine(input);

// var array = input.Split(' ').Select(Int32.Parse).ToArray();
// // int size = array.Length
// int[] arr = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
// {
//     arr[i] = array[i];
// }
// return arr;

// int CountPositive(var array)
// {
//     int count=0;
//     for(int i=0;i<array.Length;i++)
//     {
//         if(array[i]>0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// PrintArray(array);
// CountPositive(array);
// System.Console.WriteLine($" -> {count}");

// int countPositive(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//       count++;
//   }
//   return count;
// }

// int[] inputInt(int M)
// {
//   int[] array = new int[M];
//   for (int i = 0; i < M; i++)
//   {
//     Console.Write("Введите целое число: ");
//     array[i] = int.Parse(Console.ReadLine());
//   }
//   return array;
// }

// Console.Write("Введите кол-во целых чисел: ");
// int M = int.Parse(Console.ReadLine());
// int[] array = inputInt(M);
// Console.Write($"Ввели {countPositive(array)} положительных чисел");

// PrintArray(arr);
// _________________________________________________________________________________________________________________________
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
