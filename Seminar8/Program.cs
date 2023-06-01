/*int[,] RowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Invalid Input");
        return array;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
        return array;
    }
}

void Print2DArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Random2DArray(int[,] arg, int min, int max)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int[,] array = new int[5, 5];
Random2DArray(array, 0, 9);
Print2DArray(array);
Console.WriteLine();
array = RowsToColumns(array);
Print2DArray(array);

*/

void Random2DArray(int[,] arg, int min, int max)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

/*int[] Min_(int[,] arg)
{
    int min = arg[0, 0];
    int[] cords = new int[2];
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i, j] < min)
            {
                min = arg[i, j];
                cords[0] = i;
                cords[1] = j;
            }
        }
    }

    return cords;
} 

void EditArray(int[,] arg, int[] cords)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (i == cords[0] || j == cords[1]) arg[i, j] = 0;
        }
    }
} */

void EditArray(int[,] arg, int row1, int row2)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        int temp = arg[row1 - 1, i];
        arg[row1 - 1, i] = arg[row2 - 1, i];
        arg[row2 - 1, i] = temp;
    }
}

int[,] array = new int[5, 5];
Random2DArray(array, 1, 9);
Print2DArray(array);
Console.WriteLine();
EditArray(array, 2, 4);
Print2DArray(array);

