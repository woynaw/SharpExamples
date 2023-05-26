void Method()
{
    Console.WriteLine("Автор ...00");
}
//Method();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Text", count: 4);


int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Method2($"{year}");

/*string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += c;
        i++;
    }
    return result;
} */

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += c;
    }
    return result;
}

string res = Method4(10, "wqe");
Method2(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}


string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int len = text.Length;
    for (int i = 0; i < len; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 8, 2, 5, 8, 4, 9 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
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

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);