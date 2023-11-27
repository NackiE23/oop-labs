void EnterValue(out double variable, string varName)
{
    do 
    {
        System.Console.WriteLine($"Enter {varName} value: ");
        if (double.TryParse(Console.ReadLine(), out variable))
        {
            break;
        }
        Console.WriteLine("Please enter the correct value");
    }
    while (true);
}

double a, b, c;

EnterValue(out a, "a");
EnterValue(out b, "b");
EnterValue(out c, "c");

System.Console.WriteLine($"a = {a}, b = {b}, c = {c}");

double discriminant = b * b - 4 * a * c;

System.Console.WriteLine($"Дискримінант: {discriminant}");

if (discriminant > 0)
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"Розв'язки: x1 = {x1}, x2 = {x2}");
}
else if (discriminant == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Розв'язок: x = {x}");
}
else
{
    Console.WriteLine("Розв'язків немає.");
}