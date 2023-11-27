public struct Money
{
    public int WholePart { get; set; }
    public short FractionalPart { get; set; }
    private static readonly Random random = new Random();

    public Money(int wholePart, short fractionalPart)
    {
        WholePart = wholePart;
        FractionalPart = fractionalPart;
    }

    public Money(int wholePart)
    {
        WholePart = wholePart;
    }

    public override string ToString()
    {
        return $"{WholePart},{FractionalPart}";
    }

    public static Money operator +(Money money1, Money money2)
    {
        int sumWhole = money1.WholePart + money2.WholePart;
        int sumFractional = money1.FractionalPart + money2.FractionalPart;

        if (sumFractional >= 100)
        {
            sumWhole += sumFractional / 100;
            sumFractional %= 100;
        }

        return new Money(sumWhole, (short)sumFractional);
    }

    public static Money operator -(Money money1, Money money2)
    {
        int diffWhole = money1.WholePart - money2.WholePart;
        int diffFractional = money1.FractionalPart - money2.FractionalPart;

        if (diffFractional < 0)
        {
            diffWhole--;
            diffFractional += 100;
        }

        return new Money(diffWhole, (short)diffFractional);
    }

    public static Money operator *(Money money1, Money money2)
    {
        int totalCents = money1.WholePart * 100 + money1.FractionalPart;
        totalCents *= money2.WholePart;
        totalCents += (money2.FractionalPart * money1.WholePart);

        return new Money(totalCents / 100, (short)(totalCents % 100));
    }

    public static Money operator /(Money money1, Money money2)
    {
        int totalCents1 = money1.WholePart * 100 + money1.FractionalPart;
        int totalCents2 = money2.WholePart * 100 + money2.FractionalPart;

        if (totalCents2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        int quotient = totalCents1 / totalCents2;
        int remainder = totalCents1 % totalCents2;

        return new Money(quotient, (short)(remainder * 100 / totalCents2));
    }

    public static Money operator *(Money money, int multiplier)
    {
        int totalCents = money.WholePart * 100 + money.FractionalPart;
        totalCents *= multiplier;

        return new Money(totalCents / 100, (short)(totalCents % 100));
    }

    public static Money operator /(Money money, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        int totalCents = money.WholePart * 100 + money.FractionalPart;
        int quotient = totalCents / divisor;
        int remainder = totalCents % divisor;

        return new Money(quotient, (short)(remainder * 100 / divisor));
    }

    public static bool operator ==(Money money1, Money money2)
    {
        return money1.WholePart == money2.WholePart && money1.FractionalPart == money2.FractionalPart;
    }

    public static bool operator !=(Money money1, Money money2)
    {
        return !(money1 == money2);
    }

    public static bool operator >(Money money1, Money money2)
    {
        return (money1.WholePart > money2.WholePart) || 
               (money1.WholePart == money2.WholePart && money1.FractionalPart > money2.FractionalPart);
    }

    public static bool operator <(Money money1, Money money2)
    {
        return (money1.WholePart < money2.WholePart) || 
               (money1.WholePart == money2.WholePart && money1.FractionalPart < money2.FractionalPart);
    }

    public static bool operator >=(Money money1, Money money2)
    {
        return (money1 > money2) || (money1 == money2);
    }

    public static bool operator <=(Money money1, Money money2)
    {
        return (money1 < money2) || (money1 == money2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Money other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WholePart, FractionalPart);
    }

    public static Money[] ReadMoneyArrayFromConsole(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("The number of instances must be greater than 0.");
        }

        Money[] moneyArray = new Money[n];

        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.WriteLine($"Enter data for Money instance {i + 1}:");

                Console.Write("Enter whole part: ");
                int wholePart = int.Parse(Console.ReadLine());

                Console.Write("Enter fractional part: ");
                short fractionalPart = short.Parse(Console.ReadLine());

                moneyArray[i] = new Money(wholePart, fractionalPart);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine($"Generate random money");
                moneyArray[i] = new Money(random.Next(100), (short)random.Next(100));
            }
        }

        return moneyArray;
    }

    public static void ModifyMoney(ref Money money, int newWholePart, short newFractionalPart)
    {
        money.WholePart = newWholePart;
        money.FractionalPart = newFractionalPart;
    }

    public static void FindMinMax(Money[] array, out Money min, out Money max)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array is null or empty.");
        }

        min = max = array[0];

        foreach (var item in array)
        {
            if (item < min)
            {
                min = item;
            }

            if (item > max)
            {
                max = item;
            }
        }
    }
}
