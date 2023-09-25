// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x > 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 1;
//     if (x > 0 && y < 0) return 2;
//     return 5;
// }

// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindQuarter(x, y));

// ______________________________________________________________________________________________________

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

// void QuadTable(int n)
// {
//     int current = 1;
//     Console.Write(n + " -> "); 
//     while(current < n)
//     {
//       Console.Write(current * current + ", ");  
//         current++;
//     }
//     Console.WriteLine(current * current); 
// }

// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// QuadTable(n);

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int FindRange(int num)
// {
//     if (num == 1)
//     {
//         Console.WriteLine("x < 0 и y > 0");
//     }

//     if (num == 2)
//     {
//         Console.WriteLine("x > 0 и y > 0");
//     }

//     if (num == 3)
//     {
//         Console.WriteLine("x < 0 и y < 0");
//     }
//     if (num == 4)
//     {
//         Console.WriteLine("x > 0 и y < 0");
//     }
//     return 0;
// }

// FindRange(num);

//_______________________________________________________________________________________________________________________

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance (double xa, double ya, double xb, double yb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
}

System.Console.WriteLine("Напишите значения координат: ");
System.Console.WriteLine("Координата Х точки А: ");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Координата Y точки А: ");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Координата Х точки B: ");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Координата Y точки B: ");
double yb = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"A ({xa}, {ya}); B ({xb},{yb}) -> {Math.Round(Distance(xa, ya, xb, yb), 2)}");