/*
int MaxDigit(int num)
{
    int dec = num / 10;
    int ed = num % 10;
    if (dec == ed) Console.WriteLine("Число является палиндромом");
    if (dec > ed) return dec;
    else return ed;
}

int num = new Random().Next(10, 100);
int result = MaxDigit(num);
Console.WriteLine($"{num} -> {result}");
*/

/* bool Kratnost(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второк число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1}, {num2} -> {Kratnost(num1, num2)}, остаток {num1 % num2}");
*/

//###################################
/*

bool Kratnost(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {Kratnost(num)}");

*/

bool Square(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num1}, {num2} -> {Square(num1, num2)}");