Date departureDate = new Date(2023, 11, 27, 8, 0);
Date arrivalDate = new Date(2023, 11, 27, 8, 30);

Airplane flight = new Airplane("CityA", "CityB", departureDate, arrivalDate);

System.Console.WriteLine($"Total travel time: {flight.GetTotalTime()} minutes");

if (flight.IsArrivingToday())
{
    System.Console.WriteLine("The flight is arriving today.");
}
else
{
    System.Console.WriteLine("The flight is arriving on another day.");
}
System.Console.WriteLine();

Airplane[] airplanes = Airplane.RandomCreateAirplaneArray(3);
Airplane.PrintAllAirplanes(airplanes);