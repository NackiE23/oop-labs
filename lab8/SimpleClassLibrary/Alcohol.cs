public class Alcohol : Liquid
{
    public double Strength { get; set; }

    public Alcohol(string name, double density, double surfaceTension, double strength)
        : base(name, density, surfaceTension)
    {
        Strength = strength;
    }

    // Copy constructor
    public Alcohol(Alcohol other) : base(other)
    {
        Strength = other.Strength;
    }

    public override void ChangeDensity(double newDensity)
    {
        base.ChangeDensity(newDensity);
        Console.WriteLine($"Alcohol density changed to: {newDensity}");
    }

    public void ChangeStrength(double newStrength)
    {
        Strength = newStrength;
        Console.WriteLine($"Alcohol strength changed to: {newStrength}");
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Strength: {Strength}");
    }
}
