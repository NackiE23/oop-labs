public class Airplane
{
    protected string DepartureCity { get; set; }
    protected string ArrivalCity { get; set; }
    protected Date DepartureDate { get; set; }
    protected Date ArrivalDate { get; set; }
    protected double FlightDistanceKilometers { get; set; }
    protected double FlightDistanceMeters { get; set; }
    protected double FlightDistanceMiles { get; set; }

    public Airplane(string departureCity, string arrivalCity, Date departureDate, Date arrivalDate)
    {
        DepartureCity = departureCity;
        ArrivalCity = arrivalCity;
        DepartureDate = departureDate;
        ArrivalDate = arrivalDate;

        FlightDistanceKilometers = 0.0;
        FlightDistanceMeters = 0.0;
        FlightDistanceMiles = 0.0;

        InputFlightDistance();
    }

    private void InputFlightDistance()
    {
        Console.WriteLine("\nВведіть дальність польоту:");

        Console.Write("Значення: ");
        double distanceValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Виберіть одиниці вимірювання:");
        Console.WriteLine("1. Кілометри");
        Console.WriteLine("2. Метри");
        Console.WriteLine("3. Милі");

        Console.Write("Ваш вибір: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                FlightDistanceKilometers = distanceValue;
                FlightDistanceMeters = distanceValue * 1000.0;
                FlightDistanceMiles = distanceValue / 1.60934;
                break;
            case 2:
                FlightDistanceMeters = distanceValue;
                FlightDistanceKilometers = distanceValue / 1000.0;
                FlightDistanceMiles = distanceValue / 1609.34;
                break;
            case 3:
                FlightDistanceMiles = distanceValue;
                FlightDistanceKilometers = distanceValue * 1.60934;
                FlightDistanceMeters = distanceValue * 1609.34;
                break;
            default:
                Console.WriteLine("Невірний вибір. Дальність польоту не встановлено.");
                break;
        }
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
               $"Дата прибуття: {ArrivalDate}\n" +
               $"Дальність польоту (км): {FlightDistanceKilometers}\n" +
               $"Дальність польоту (м): {FlightDistanceMeters}\n" +
               $"Дальність польоту (миль): {FlightDistanceMiles}\n";
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