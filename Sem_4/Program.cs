// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

// int NumLength(int num)
// {
//     int count = 1;
//     while(Math.Abs(num) / 10 > 0) // Число форматируется в абсолютное
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{n} -> {NumLength(n)}");

//_____________________________________________________________________________________________________________________

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // строка инициализации массива
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array) //метод для вывода массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//       Console.Write(array[i] + " ");  
//     }
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min rndm: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max rndm: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, min, max));

//____________________________________________________________________________________________________

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28

// 4 -> 10

// 8 -> 36

// int SumNumbers(int num)
// {
//     int sum = 0;
//     int count = 1;
//     while(count <= num)
//     {
//         sum = sum+count;
//         count++;
//     }
//     return sum;
//    }

// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumNumbers(n));



//______________________________________________________________________________________________________
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int fact = 1;
    int count = 1;
    while(count <= num)
    {
        fact = fact*count;
        count++;
    }
    return fact;
   }

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Factorial(n));