// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int MiddleDigit(int num)
// {
//     int dec = num / 10;
//     int ed = dec % 10;
//     return ed;
// }

// int NumLength(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Insert three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// /////////Console.WriteLine(NumLength(num));

// while(NumLength(num) != 3)
// {
//     Console.Write("Insert THREE-DIGIT number: "); 
//     num = Convert.ToInt32(Console.ReadLine());  
// }
//  Console.WriteLine($"{num} -> {MiddleDigit(num)}");

//________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Input any number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int NumLength(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// ////Console.WriteLine(NumLength(num));

// int FindThird(int num)
// {
//     int digpos = NumLength(num);
//     //int step = NumLength(num) - 3;
//     while(digpos > 3)
//     {
//         num = num / 10;
//         digpos--;
//     }
//     num = num % 10;
//     return num;
// }
// ////Console.WriteLine(FindThird(num));

// while(NumLength(num) < 3)
// {
//     Console.Write("3rd digit missed! Insert THREE-DIGIT number: "); 
//     num = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Third digit of: {num} -> {FindThird(num)}");

//___________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


bool CheckWeekend(int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine("Input 1 - 7 number: ");
int num = Convert.ToInt32(Console.ReadLine());

while(num == 0 || num > 7)
{
    Console.WriteLine("Range must be 1 to 7: ");
    num = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine($"The day #{num} is weekend -> {CheckWeekend(num)}");