public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }

    // Copy constructor
    public Fraction(Fraction other)
    {
        numerator = other.numerator;
        denominator = other.denominator;
    }

    public void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
    }

    public double ToDouble()
    {
        return (double)numerator / denominator;
    }

    public static Fraction operator +(Fraction fraction1, Fraction fraction2)
    {
        int commonDenominator = fraction1.denominator * fraction2.denominator;
        int newNumerator = fraction1.numerator * fraction2.denominator + fraction2.numerator * fraction1.denominator;

        return new Fraction(newNumerator, commonDenominator);
    }

    public static Fraction operator -(Fraction fraction1, Fraction fraction2)
    {
        int commonDenominator = fraction1.denominator * fraction2.denominator;
        int newNumerator = fraction1.numerator * fraction2.denominator - fraction2.numerator * fraction1.denominator;

        return new Fraction(newNumerator, commonDenominator);
    }

    public static Fraction operator *(Fraction fraction1, Fraction fraction2)
    {
        return new Fraction(fraction1.numerator * fraction2.numerator, fraction1.denominator * fraction2.denominator);
    }

    public static Fraction operator /(Fraction fraction1, Fraction fraction2)
    {
        if (fraction2.numerator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return new Fraction(fraction1.numerator * fraction2.denominator, fraction1.denominator * fraction2.numerator);
    }

    public static bool operator ==(Fraction fraction1, Fraction fraction2)
    {
        return fraction1.Equals(fraction2);
    }

    public static bool operator !=(Fraction fraction1, Fraction fraction2)
    {
        return !fraction1.Equals(fraction2);
    }

    public static bool operator >(Fraction fraction1, Fraction fraction2)
    {
        return fraction1.ToDouble() > fraction2.ToDouble();
    }

    public static bool operator <(Fraction fraction1, Fraction fraction2)
    {
        return fraction1.ToDouble() < fraction2.ToDouble();
    }

    public static bool operator >=(Fraction fraction1, Fraction fraction2)
    {
        return fraction1.ToDouble() >= fraction2.ToDouble();
    }

    public static bool operator <=(Fraction fraction1, Fraction fraction2)
    {
        return fraction1.ToDouble() <= fraction2.ToDouble();
    }

    public static Fraction operator +(Fraction fraction)
    {
        return new Fraction(fraction.numerator, fraction.denominator);
    }

    public static Fraction operator -(Fraction fraction)
    {
        return new Fraction(-fraction.numerator, fraction.denominator);
    }

    public static explicit operator double(Fraction fraction)
    {
        return (double)fraction.numerator / fraction.denominator;
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction other)
        {
            return numerator == other.numerator && denominator == other.denominator;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
