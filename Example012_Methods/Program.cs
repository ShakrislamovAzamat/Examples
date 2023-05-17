// Вид 1

void Method1()
{
    Console.WriteLine("Author ...");
}
//Method1(); //Вызов метода
//Method1; //Неправильный вызов метода


//Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Text message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text message", 4);
//Method21(msg: "Text message", count: 4); //именованные аргументы, можно указывать в произвольном порядке



// Вид 3

int Method3()
{
    return DateTime.Now.Year; //для методов, которые возвращают значение, обязательно указать оператор return
}
int year = Method3();
//Console.WriteLine(year);






//Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     //string result = ""; // один из способов указания пустой строки
//     string result = String.Empty; // более правильно пустую строку можно указывать так

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }


string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z ");
//Console.WriteLine(res);

// Цикл в цикле

// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}"); //Console.WriteLine(i*j)
//     }
//     Console.WriteLine(); //Переход на новую строку
// }



// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас полслали вместо нашего"
            + "милого Винценгероде, вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);


// Алгоритм сортировки массива методом выбора (мини-макс и т.д.)

int[] arr = { 1, 5, 6, 4, 2, 8, 7, 9, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }

        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);