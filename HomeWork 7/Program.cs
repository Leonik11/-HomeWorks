// See https://aka.ms/new-console-template for more information


//example 1
Console.WriteLine("Enter the radius:");
var radius = Convert.ToInt64(Console.ReadLine());

var largeSquareSideLength = radius * 2;
var smallSquareDiagonalLength = 2 * radius;

double areaLargeSquare = Math.Pow(largeSquareSideLength, 2);
double areaSmallSquare = Math.Pow(smallSquareDiagonalLength, 2) / 2;

double differenceOfArea = areaLargeSquare - areaSmallSquare;

Console.WriteLine($"Difference between the areas of large and small squares: {differenceOfArea}");


//example 2
Console.WriteLine("Enter the login status (use '@' for logged in and any other character for not logged in, separated by commas):");
string[] input = Console.ReadLine().Split(',');

var hasJackpot = true; 
var firstChar = input[0][0]; 

foreach (string status in input)
{
    if (status[0] != firstChar)
    {
        hasJackpot = false; 
        break; 
    }
}

Console.WriteLine("Output: " + (hasJackpot ? "Yes" : "No"));


//example 3
Console.WriteLine("Enter the results (use 'Win', 'Draw', and 'Loss' separated by commas):");
string[] results = Console.ReadLine().Split(',');

int totalPoints = 0;

foreach (string result in results)
{
    string[] parts = result.Trim().Split('-');
    string outcome = parts[0].Trim();
    int points = int.Parse(parts[1].Trim());

    if (outcome == "Win")
    {
        totalPoints += 3 * points;
    }
    else if (outcome == "Draw")
    {
        totalPoints += points;
    }
}

Console.WriteLine("Total points scored by the team: " + totalPoints);


//example 4
Console.WriteLine("Enter the hours worked each day for 1 week (separated by commas):");
string[] hoursWorkedInput = Console.ReadLine().Split(',');

int totalIncome = 0;

for (int i = 0; i < hoursWorkedInput.Length; i++)
{
    int hoursWorked = int.Parse(hoursWorkedInput[i]);
    int hourlyRate = 10;
    int overtimeRate = 15;

    int dailyIncome;

    if (hoursWorked <= 8)
    {
        dailyIncome = hoursWorked * hourlyRate;
    }
    else
    {
        dailyIncome = (8 * hourlyRate) + ((hoursWorked - 8) * overtimeRate);
    }

    if (i % 7 == 5 || i % 7 == 6) 
    {
        dailyIncome *= 2; 
    }

    totalIncome += dailyIncome;
}

Console.WriteLine("Total income for the week: $" + totalIncome);


//example 5
Console.WriteLine("Enter George's progress each day (separated by commas):");
string[] progressInput = Console.ReadLine().Split(',');

var improvedDays = 0;
var previousProgress = Convert.ToInt64((progressInput[0])); 

for (int i = 1; i < progressInput.Length; i++)
{
    var progress = Convert.ToInt64(progressInput[i]);

    if (progress > previousProgress)
    {
        improvedDays++;
    }

    previousProgress = progress;
}

Console.WriteLine($"Number of days George improved: {improvedDays}");



//example 6
string[] array = {"Hello", "World", "Programming", "communication"};

Console.WriteLine("Enter the length N:");
var N = Convert.ToInt64((Console.ReadLine()));

var elements = array.Where(s => s.Length == N).ToList();

if (elements.Count > 0)
{
    Console.WriteLine("Output:");
    foreach (var element in elements)
    {
        Console.WriteLine(element);
    }
}
else
{
    Console.WriteLine("No elements found.");
}