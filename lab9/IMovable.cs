public interface IMovable
{
    double GetDistance(int speed);
}

public abstract class Vehicle : IMovable
{
    public abstract double GetDistance(int speed);
}

public class Car : Vehicle
{
    public override double GetDistance(int speed)
    {
        return speed * 1.5;
    }
}

public class Plane : Vehicle
{
    public override double GetDistance(int speed)
    {
        return speed * 3;
    }
}

public class Train : Vehicle
{
    public override double GetDistance(int speed)
    {
        return speed * 2;
    }
}
