// ВИД 1
void Method1()
{
    Console.WriteLine("Автор ....");
}
//Method1();




// ВИД 2 (Ничего не возвращают, но принимают какие-то данные)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Methods21(msg: "Текст", count: 4);


// ВИД 3 (Что-то возвращают, но ничего не принимают)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


// ВИД 4 (Что-то принимают, что-то возвращают)
//string Method4(int count, string text)
//{
//int i = 0;
// string result = String.Empty; 
// String.Empty - пустая строка.


// while (i < count)
// {
//     result = result + text;
//     i++;
// }
// return result;
//}

//string res = Method4(10, "Many");
//Console.WriteLine(res);

// Циклы и не только while
// for(int i=0; i<10; i++)
//{
//    Console.WriteLine(i);
//}



string Method4(int count, string text)
{

    string result = String.Empty;
    // String.Empty - пустая строка.

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Many");
//Console.WriteLine(res);

// Цикл в цикле
// for(int i = 0; i<10;i++)
//{
//    for(int j = 0; j<10;j++)
//    {
//       System.Console.WriteLine(i*j);
//    }
//    Console.WriteLine();
//}


// ВЫВОД ТАБЛИЦЫ УМНОЖЕНИЯ

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}"); //Интерполяция строк
    }
    Console.WriteLine();
}