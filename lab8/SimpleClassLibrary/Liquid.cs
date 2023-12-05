public class Liquid
{
    public string Name { get; set; }
    public double Density { get; set; }
    public double SurfaceTension { get; set; }

    public Liquid()
    {
        // Default constructor
    }

    public Liquid(string name, double density, double surfaceTension)
    {
        Name = name;
        Density = density;
        SurfaceTension = surfaceTension;
    }

    // Copy constructor
    public Liquid(Liquid other)
    {
        Name = other.Name;
        Density = other.Density;
        SurfaceTension = other.SurfaceTension;
    }

    public virtual void ChangeDensity(double newDensity)
    {
        Density = newDensity;
    }

    public virtual void ChangeSurfaceTension(double newSurfaceTension)
    {
        SurfaceTension = newSurfaceTension;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Density: {Density}, Surface Tension: {SurfaceTension}");
    }
}