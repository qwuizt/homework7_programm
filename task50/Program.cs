Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());


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

void PrintElement(int[,] array, int row, int column)
{
    if (row < 0 || row > array.GetLength(0) - 1 || column < 0 || column > array.GetLength(1) - 1)
        Console.WriteLine("такого элемента в массиве нет");
    else Console.WriteLine(array[row, column]);
}
int[,] matrix = CreateMatrix(4, 4, 0, 10);
PrintMAtrix(matrix);
PrintElement(matrix, row, column);