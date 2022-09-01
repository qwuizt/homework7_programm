int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);

        }

    }
    return array;
}

void PrintMAtrix(int[,] array)
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

void AverageValue(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double averageSum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           averageSum = averageSum + array[j,i];
        }
        averageSum = averageSum / array.GetLength(0);
        averageSum = Math.Round(averageSum,2);
        Console.Write($"{averageSum} ");
    }
}
int[,] matrix = CreateMatrix(3,4,0,9);
PrintMAtrix(matrix);
AverageValue(matrix);