Money money1 = new Money(13, 88);
Money money2 = new Money(14, 12);
Money money3 = money1 + money2;

System.Console.WriteLine($"money1 = {money1}\nmoney2 = {money2}\nmoney3 = {money3}\n");

System.Console.WriteLine($"money3 > money2: {money1 > money2}");
System.Console.WriteLine($"money1 == money2: {money1 == money2}");
System.Console.WriteLine($"money1 - money2: {money1 - money2}");
System.Console.WriteLine($"money2 * money3: {money2 * money3}");
System.Console.WriteLine();

Money[] moneyArray = Money.ReadMoneyArrayFromConsole(5);
System.Console.WriteLine(string.Join(", ", moneyArray));
System.Console.WriteLine();

Money minMoney, maxMoney;
Money.FindMinMax(moneyArray, out minMoney, out maxMoney);
System.Console.WriteLine($"Min: {minMoney}\nMax: {maxMoney}\n");

System.Console.WriteLine($"Money before modification: {money3}");
Money.ModifyMoney(ref money3, 10, 10);
System.Console.WriteLine($"Money after modification: {money3}");