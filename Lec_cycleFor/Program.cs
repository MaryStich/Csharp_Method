// таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }

// ___________________________________________________________________

// Дан текст, пробелы -> "_", маленькие "к" заменить на большие, большие "С" заменить на маленькие.

// string text = "Я ваС любил: любовь еще, быть может,"
//             +"В душе моей угасла не совсем;"
//             +"Но пусть она ваС больше не тревожит;"
//             +"Я не хочу печалить ваС ничем."
//             +"Я вас любил безмолвно, безнадежно,"
//             +"То робостью, то ревностью томим;"
//             +"Я ваС любил так искренно, так нежно,"
//             +"Как дай вам бог любимой быть другим.";
// // 

// string Replace(string text, char oldVal, char newVal)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldVal) result = result + $"{newVal}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ','_');
// string newTextK = Replace(newText, 'к','К');
// string newTextC = Replace(newTextK, 'С','с');
// System.Console.WriteLine(newTextC);

// ______________________________________________________________________

// отсортируйте массив от мин к макс

int[] arr = { 1, 5, 4, 3, 2, 1, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) 
//             {
//                 minPosition = j;
//             }
//         }

//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }

void SelectionSortMax2Min(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) 
            {
                maxPosition = j;
            }
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);

SelectionSortMax2Min(arr);
PrintArray(arr);
