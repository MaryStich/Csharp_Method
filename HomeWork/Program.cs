// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int MiddleDigit(int num)
{
    int dec = num / 10;
    int ed = dec % 10;
    return ed;
}

int NumLength(int num)
{
    int count = 0;
    //int i = num;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.Write("Insert three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(NumLength(num));

while(NumLength(num) != 3)
{
    Console.Write("Insert THREE-DIGIT number: "); 
    num = Convert.ToInt32(Console.ReadLine());  
}
 Console.WriteLine($"{num} -> {MiddleDigit(num)}");


