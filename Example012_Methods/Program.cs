// вид 1
void Method1()
{
    Console.WriteLine("Author: ...");
}
// Method1();


// вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("massage text");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1("text", 4);
// Method2_1(count: 5, msg: "new text");


// вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

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
string res = Method4(10, "Mm");
// Console.WriteLine(res);

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string replace(string text, char oldvalue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldvalue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// string newText = replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = replace(newText, 'с', 'С');
// Console.WriteLine(newText);



int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

void ReversSelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
ReversSelectionSort(arr);
PrintArray(arr);