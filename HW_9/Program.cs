// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

void ShowNum(int n)
{
    if (n > 0)
    {
        System.Console.Write(n + " ");
        ShowNum(n - 1);

    }
}

Console.Write($"Задача 64: \n");
Console.Write("M to N numbers: ");
ShowNum(10);
Console.WriteLine();
Console.WriteLine($"______________________________________________\n");

// _____________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Input(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumFromM2N(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        return SumFromM2N(n + 1, m) + n;
    }

}

Console.Write($"Задача 66: \n");
int n = Input("Input N: ");
int m = Input("Input M: ");

Console.WriteLine($"Sum from M to N: {SumFromM2N(n, m)}");
System.Console.WriteLine($"______________________________________________\n");

// _____________________________________________________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if(m>0 && n==0)
    {
       return Akkerman(m-1,1);
    }
    else
    {
        return Akkerman(m-1,Akkerman(m,n-1));
    }
}

Console.Write($"Задача 68: \n");
System.Console.WriteLine($"Akkerman result -> {Akkerman(2,3)}");
System.Console.WriteLine($"______________________________________________\n");