double[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().NextDouble() * new Random().Next(min, max + 1);
            array[row, column] = Math.Round(array[row, column], 2);
        }

    }
    return array;
}

void PrintMAtrix(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrix(4, 4, -10, 10);
PrintMAtrix(matrix);