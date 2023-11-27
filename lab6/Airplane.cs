class Airplane
{
    protected string DepartureCity { get; set; }
    protected string ArrivalCity { get; set; }
    protected Date DepartureDate { get; set; }
    protected Date ArrivalDate { get; set; }

    public Airplane(string departureCity, string arrivalCity, Date departureDate, Date arrivalDate)
    {
        DepartureCity = departureCity;
        ArrivalCity = arrivalCity;
        DepartureDate = departureDate;
        ArrivalDate = arrivalDate;
    }

    public int GetTotalTime()
    {
        TimeSpan duration = ArrivalDate - DepartureDate;

        return (int)duration.TotalMinutes;
    }

    public bool IsArrivingToday()
    {
        return Date.IsEqualDays(DepartureDate, ArrivalDate);
    }

    public static Airplane[] CreateAirplaneArray(int n)
    {
        Airplane[] airplanes = new Airplane[n];

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"\nВведення даних для літака #{i + 1}:");

            Console.Write("Місто відправлення: ");
            string departureCity = Console.ReadLine();

            Console.Write("Місто прибуття: ");
            string arrivalCity = Console.ReadLine();

            System.Console.WriteLine("Введіть дату відправлення:");

            Console.Write("Рік: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Місяць: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("День: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Години: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Хвилини: ");
            int minutes = int.Parse(Console.ReadLine());

            Date departureDate = new Date(year, month, day, hours, minutes);

            System.Console.WriteLine("Введіть дату прибуття:");

            Console.Write("Рік: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Місяць: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("День: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Години: ");
            hours = int.Parse(Console.ReadLine());

            Console.Write("Хвилини: ");
            minutes = int.Parse(Console.ReadLine());

            Date arrivalDate = new Date(year, month, day, hours, minutes);

            airplanes[i] = new Airplane(departureCity, arrivalCity, departureDate, arrivalDate);
        }

        return airplanes;
    }

    public static Airplane[] RandomCreateAirplaneArray(int n)
    {
        Airplane[] airplanes = new Airplane[n];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            string departureCity = $"City{i + 1}A";
            string arrivalCity = $"City{i + 1}B";

            Date departureDate = new Date(
                random.Next(2023, 2024),
                random.Next(1, 13),
                random.Next(1, 29),
                random.Next(0, 24),
                random.Next(0, 60)
            );

            Date arrivalDate = new Date(
                random.Next(2023, 2024),
                random.Next(1, 13),
                random.Next(1, 29),
                random.Next(0, 24),
                random.Next(0, 60)
            );
            
            airplanes[i] = new Airplane(departureCity, arrivalCity, departureDate, arrivalDate);
        }

        return airplanes;
    }

    public override string ToString()
    {
        return $"Місто відправлення: {DepartureCity}\n" +
               $"Місто прибуття: {ArrivalCity}\n" +
               $"Дата відправлення: {DepartureDate}\n" +
               $"Дата прибуття: {ArrivalDate}\n";
    }

    public static void PrintAirplaneDetails(Airplane airplane)
    {
        System.Console.WriteLine(airplane.ToString());
    }

    public static void PrintAllAirplanes(Airplane[] airplanes)
    {
        foreach (var airplane in airplanes)
        {
            Airplane.PrintAirplaneDetails(airplane);
        }
    }
}