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

bool Kratnost(int num1, int num2)
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