// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// void PrintArray1(int[] array)
// {
//     System.Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.Write("] -> ");
// }

// void PrintArray2(int[] array)
// {
//     System.Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine("]");
// }

// int[] CreateRandomArray()
// {
//     int[] array = new int[5];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// int[] ReversedArray(int[] array)
// {
//     int temp;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// int[] myArray=CreateRandomArray();
// PrintArray1(myArray);
// PrintArray2(ReversedArray(myArray));

// ______________________________________________________________________________________
// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10


// System.Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string Dec2Bin(int number)
// {
//     string result = string.Empty; //если создаем строку, всегда указываем, что она пустая.
//     while (number > 0)
//     {
//         result = number % 2 + result;
//         number /= 2;
//     }
//     return result;
// }

// System.Console.WriteLine(Dec2Bin(n));

// _______________________________________________________________________________________________________________

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. (Любая сторона не может быть больше суммы двух других.)

// int a = new Random().Next(3,15);
// int b = new Random().Next(3,15);
// int c = new Random().Next(3,15);

// System.Console.Write($"{a}, {b}, {c}");

// bool TriangCheck(int a, int b, int c)
// {
//     int x1=a+b;
//     int x2=a+c;
//     int x3=b+c;
//     if(a>x3 || b>x2 || c>x1)
//     {
//         return false;
//     }
//     else return true;
// }

// System.Console.Write($" -> {TriangCheck(a, b, c)}");

// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
// (каждый сл элемент массива складывается и суммы двух предыдущих)

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] Fibonacci(int n)
{
    // string result= 0 1 ;
    int[] array = new int[n];
    array[0]=0;
    array[1]=1;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int n = new Random().Next(3, 9);
System.Console.Write($"{n} -> ");
PrintArray(Fibonacci(n));
