// // Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// // Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// // Для остальных чисел вернуть True или False.

// DONE!!!

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {  
//         int digit_1 = number / 10000;
//         int digit_2 = number / 1000 % 10;
//         int digit_4 = number / 10 % 10;
//         int digit_5 = number % 10;
        
//         if (number < 1000 || number > 100000)
//         {
//             System.Console.WriteLine($"{number} -> Число не пятизначное");
//             return false;
//         }
//         else if (digit_1 == digit_5 && digit_2 == digit_4)
//         {
//             Console.Write($"{number} -> ");
//             return true;
//         }
//         else
//         {
//             Console.Write($"{number} -> ");
//             return false;
//         }


//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64548;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

// ___________________________________________________________________________________________________

// Внутри класса Answer напишите метод ShowCube, 
// который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

// DONE!!!

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//         int count = 1;
//       while(count <= N)
//     {
//         Console.WriteLine(count*count*count);
//         count++;
//     }      
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 5;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }

//___________________________________________________________________________________________________________________

// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек 
// pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
      return Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}