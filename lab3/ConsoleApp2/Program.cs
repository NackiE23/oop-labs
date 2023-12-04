Console.Write("Enter the number of rows (n): ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of columns (m): ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GenerateRandomArray(rows, columns);
PrintArray("Initial Array:", array);

// Task 1: Count rows with no positive elements
int rowsWithoutPositiveElements = CountRowsWithoutPositiveElements(array);
Console.WriteLine($"Number of rows without positive elements: {rowsWithoutPositiveElements}");
PrintArray("Array after Task 1:", array);

// Task 2: Sort columns based on the sum of absolute values of positive elements
SortColumnsBySumOfAbsPositives(array);
PrintArray("Array after Task 2:", array);

static double[,] GenerateRandomArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * (53.36 + 15.62) - 15.62, 2);
        }
    }

    return array;
}

static void PrintArray(string message, double[,] array)
{
    Console.WriteLine($"{message}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],10:N2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static int CountRowsWithoutPositiveElements(double[,] array)
{
    int rowsWithoutPositiveElements = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool hasPositiveElement = false;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 0)
            {
                hasPositiveElement = true;
                break;
            }
        }

        if (!hasPositiveElement)
        {
            rowsWithoutPositiveElements++;
        }
    }

    return rowsWithoutPositiveElements;
}

static void SortColumnsBySumOfAbsPositives(double[,] array)
{
    int columns = array.GetLength(1);

    // Calculate the sum of absolute values of positive elements in each column
    double[] columnSums = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] > 0)
            {
                columnSums[j] += Math.Abs(array[i, j]);
            }
        }
    }

    // Sort columns based on the calculated sums
    for (int i = 0; i < columns - 1; i++)
    {
        for (int j = i + 1; j < columns; j++)
        {
            if (columnSums[j] > columnSums[i])
            {
                // Swap columns
                for (int k = 0; k < array.GetLength(0); k++)
                {
                    double temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }

                // Swap column sums
                double tempSum = columnSums[i];
                columnSums[i] = columnSums[j];
                columnSums[j] = tempSum;
            }
        }
    }
}
