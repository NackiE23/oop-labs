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

double x, y, z;

EnterValue(out x, "x");
EnterValue(out y, "y");
EnterValue(out z, "z");

System.Console.WriteLine($"x = {x}, y = {y}, z = {z}");

double res = Math.Round((Math.Pow((3 + Math.Tan(x) - (y / 2)), 1.0 / 3)) / (Math.Pow(x, 2) + Math.Pow(z, 3) + 4), 3);
System.Console.WriteLine($"Res: {res}");
