//====Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "C" заменить маленьким "с".

// Ясна ли задача?

string text = " -Я думаю, -сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого  Винцегороде, "
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы ладите мне чаю?";



// string s = "qwerty"
//             012345 
// s[3]  //  r   


string Replace(string text, char OldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(text, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(text, 'С', 'с');
//Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // Метод вывода массива в терминале
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

void SelectionSort(int[] array) // Метод упорядочивания массива от минимального к максимальному
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; // temporary(временный)
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);