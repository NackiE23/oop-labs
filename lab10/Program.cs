// Queue<object> myQueue = new Queue<object>();

// // Додаємо різні типи значень до черги
// myQueue.Enqueue("Hello");
// myQueue.Enqueue(3.14);
// myQueue.Enqueue(42);
// myQueue.Enqueue(123.456);

// while (myQueue.Count > 0)
// {
//     object value = myQueue.Dequeue();

//     if (value is string)
//     {
//         Console.WriteLine($"String value: {value}");
//     }
//     else if (value is double)
//     {
//         Console.WriteLine($"Double value: {value}");
//     }
//     else if (value is int)
//     {
//         Console.WriteLine($"Int value: {value}");
//     }
//     else
//     {
//         Console.WriteLine($"Unknown type: {value}");
//     }
// }

// System.Console.WriteLine();

Dictionary<string, Airplane> airplanes = new Dictionary<string, Airplane>();

// Додаємо об'єкти класу Airplane до словника
airplanes.Add("Flight1", new Airplane("CityA", "CityB", new Date(2023, 1, 1, 12, 0), new Date(2023, 1, 1, 15, 30)));
airplanes.Add("Flight2", new Airplane("CityC", "CityD", new Date(2023, 1, 1, 12, 0), new Date(2023, 1, 1, 15, 30)));
airplanes.Add("Flight3", new Airplane("CityE", "CityF", new Date(2023, 1, 1, 12, 0), new Date(2023, 1, 1, 15, 30)));

// Отримуємо і виводимо інформацію про об'єкт за ключем
Airplane flightInfo = airplanes["Flight2"];
Console.WriteLine("Flight Information for Flight2:");
Console.WriteLine($"{flightInfo}");
