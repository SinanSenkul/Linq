List<int> randomNumbers = new List<int>();
Random random = new Random();

// Generate and add 10 random integers to the list
for (int i = 0; i < 10; i++)
{
    int randomNumber = random.Next(-100, 100);
    randomNumbers.Add(randomNumber);
}

var evenNumbers = randomNumbers.Where(x => x % 2 == 0);

var oddNumbers = randomNumbers.Where(x => x % 2 == 1);

var negNumbers = randomNumbers.Where(x => x < 0);

var posNumbers = randomNumbers.Where(x => x > 0);

var greaterThan15SmallerThan22Numbers = randomNumbers.Where(x => x > 15 && x < 22);

List<int> squares = randomNumbers.Select(x => x * x).ToList();

Console.WriteLine("rastgele sayılar:");
foreach (int number in randomNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("çift sayılar:");
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("tek sayılar:");
foreach (int number in oddNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("negatif sayılar:");
foreach (int number in negNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("pozitif sayılar:");
foreach (int number in posNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("15 ile 22 arasındaki sayılar:");
foreach (int number in greaterThan15SmallerThan22Numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("sayıların kareleri:");
foreach (int number in squares)
{
    Console.WriteLine(number);
}