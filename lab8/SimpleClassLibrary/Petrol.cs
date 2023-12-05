public class Petrol : Liquid
{
    public int OctaneNumber { get; set; }

    public Petrol(string name, double density, double surfaceTension, int octaneNumber)
        : base(name, density, surfaceTension)
    {
        OctaneNumber = octaneNumber;
    }

    // Copy constructor
    public Petrol(Petrol other) : base(other)
    {
        OctaneNumber = other.OctaneNumber;
    }

    public override void ChangeDensity(double newDensity)
    {
        base.ChangeDensity(newDensity);
        Console.WriteLine($"Petrol density changed to: {newDensity}");
    }

    public void ChangeOctaneNumber(int newOctaneNumber)
    {
        OctaneNumber = newOctaneNumber;
        Console.WriteLine($"Petrol octane number changed to: {newOctaneNumber}");
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Octane Number: {OctaneNumber}");
    }
}