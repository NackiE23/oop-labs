System.Console.WriteLine("Enter array size: ");
int size = int.Parse(Console.ReadLine()!);

double minimum = -2.9;
double maximum = 60.3;

double[] array =new double[size];

Random random = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 1);
}

System.Console.WriteLine("Array: " + string.Join(", ", array));

// Find Min/Max Values
int minIndex = 0, maxIndex = 0;
double minValue = array[0], maxValue = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];
        minIndex = i;
    }
    else if (array[i] > maxValue)
    {
        maxValue = array[i];
        maxIndex = i;
    }
}
System.Console.WriteLine($"minIndex = {minIndex}, maxIndex = {maxIndex}");

int start, end;
if (minIndex > maxIndex)
{
    start = maxIndex;
    end = minIndex;
}
else
{
    start = minIndex;
    end = maxIndex;
}
System.Console.WriteLine($"start = {start}, end = {end}");

int product = 1;
for (int i = start + 1; i < end; i++)
{
    product *= i;
}

System.Console.WriteLine($"Product: {product}");