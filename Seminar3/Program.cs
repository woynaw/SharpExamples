/*
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
int result = FindQuart(x,y);
Console.WriteLine($"{result}"); 
*/
/*
        double FindDistance(double x1, double y1, double x2, double y2)
        {

            return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
        }


        Console.WriteLine("Введите x1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y1");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите x2");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y2");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{FindDistance(x1, y1, x2, y2)}");*/

/*
public class Point2D
{
    public double X { get; }
    public double Y { get; }
    public double Distance { get; }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
        Distance = X * X;
    }
}


public static class GeomertyMath
{
    public static double Distance(Point2D p1, Point2D p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                         + (p1.Y - p2.Y) * (p1.Y - p2.Y));
    }


}
internal class Program
{
    private static void Main(string[] args)
    {
        var p1 = new Point2D(3, 6);
        var p2 = new Point2D(2, 1);
        Console.WriteLine($"{GeomertyMath.Distance(p1, p2)}");
        Console.WriteLine($"{p1.Distance}");
    }
}
*/