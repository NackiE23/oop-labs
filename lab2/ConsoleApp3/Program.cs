void EnterValue(out int variable, string varName)
{
    do 
    {
        System.Console.WriteLine($"Enter {varName} value: ");
        if (int.TryParse(Console.ReadLine(), out variable))
        {
            break;
        }
        Console.WriteLine("Please enter the correct value");
    }
    while (true);
}

int n, k;

EnterValue(out n, "n");
EnterValue(out k, "k");

System.Console.WriteLine($"n = {n}, k = {k}");

double sum1 = 0;
for (int i = 1; i <= k; i++)
{
    sum1 += Math.Pow(i, (double)n / i);
}

double sum2 = 0;
for (int i = 1; i <= n; i++)
{
    sum2 += Math.Pow(i, k);
}

double sum3 = 0;
for (int i = 1; i <= k; i++)
{
    sum3 += 1 / Math.Pow(n, i);
}

System.Console.WriteLine($"1^n + 2^(n/2) + ... + k^(n/k):     {sum1}");
System.Console.WriteLine($"1^k + 2^k + ... + n^k:             {sum2}");
System.Console.WriteLine($"1/n + 2/n^2 + 3/n^3 + ... + k/n^k: {sum3}");
