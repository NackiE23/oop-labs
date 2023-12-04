Liquid[] liquids = new Liquid[]
{
    new Alcohol("Ethanol", 0.789, 22.4, 40),
    new Petrol("Unleaded", 0.745, 25.5, 95),
    new Alcohol("Methanol", 0.791, 22.6, 50)
};

int choice;
do
{
    Console.WriteLine("1. Show Information");
    Console.WriteLine("2. Change Density");
    Console.WriteLine("3. Change Surface Tension (Liquid)");
    Console.WriteLine("4. Change Strength (Alcohol)");
    Console.WriteLine("5. Change Octane Number (Petrol)");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            foreach (var liquid in liquids)
            {
                liquid.ShowInfo();
            }
            break;
        case 2:
            Console.Write("Enter new density: ");
            double newDensity = double.Parse(Console.ReadLine()!);
            foreach (var liquid in liquids)
            {
                liquid.ChangeDensity(newDensity);
            }
            break;
        case 3:
            Console.Write("Enter new surface tension: ");
            double newSurfaceTension = double.Parse(Console.ReadLine()!);
            foreach (var liquid in liquids)
            {
                liquid.ChangeSurfaceTension(newSurfaceTension);
            }
            break;
        case 4:
            if (liquids[0] is Alcohol)
            {
                Console.Write("Enter new strength: ");
                double newStrength = double.Parse(Console.ReadLine()!);
                ((Alcohol)liquids[0]).ChangeStrength(newStrength);
            }
            else
            {
                Console.WriteLine("Invalid choice for this type of liquid.");
            }
            break;
        case 5:
            if (liquids[1] is Petrol)
            {
                Console.Write("Enter new octane number: ");
                int newOctaneNumber = int.Parse(Console.ReadLine()!);
                ((Petrol)liquids[1]).ChangeOctaneNumber(newOctaneNumber);
            }
            else
            {
                Console.WriteLine("Invalid choice for this type of liquid.");
            }
            break;
    }
} while (choice != 0);


Fraction fraction1 = new Fraction(3, 5);
Fraction fraction2 = new Fraction(1, 2);
Fraction fraction3 = new Fraction(fraction2);

// Demonstrate arithmetic operations
Fraction sum = fraction1 + fraction2;
Fraction difference = fraction1 - fraction2;
Fraction product = fraction1 * fraction2;
Fraction quotient = fraction1 / fraction2;

// Demonstrate comparison operations
bool isEqual = fraction1 == fraction3;
bool isNotEqual = fraction1 != fraction2;
bool isGreaterThan = fraction1 > fraction2;
bool isLessThan = fraction1 < fraction2;
bool isGreaterOrEqual = fraction1 >= fraction2;
bool isLessOrEqual = fraction1 <= fraction2;

// Demonstrate unary operations
Fraction negativeFraction = -fraction1;
Fraction positiveFraction = +fraction1;

// Demonstrate conversion to double
double decimalValue = (double)fraction1;

// Demonstrate simplification
Fraction unsimplifiedFraction = new Fraction(12, 18);

Console.WriteLine("Original Fraction: " + fraction1);
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Is Equal: " + isEqual);
Console.WriteLine("Is Not Equal: " + isNotEqual);
Console.WriteLine("Is Greater Than: " + isGreaterThan);
Console.WriteLine("Is Less Than: " + isLessThan);
Console.WriteLine("Is Greater Or Equal: " + isGreaterOrEqual);
Console.WriteLine("Is Less Or Equal: " + isLessOrEqual);
Console.WriteLine("Negative Fraction: " + negativeFraction);
Console.WriteLine("Positive Fraction: " + positiveFraction);
Console.WriteLine("Converted to Double: " + decimalValue);
Console.WriteLine("Unsimplified Fraction: " + unsimplifiedFraction);