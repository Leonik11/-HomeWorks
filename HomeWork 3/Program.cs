// See https://aka.ms/new-console-template for more information

//example 1
var number = Convert.ToInt32(Console.ReadLine());
var result = number % 5;

if (result == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


//example 2
var X = Convert.ToInt32(Console.ReadLine());
var Op = Console.ReadLine();
var Y = Convert.ToInt32(Console.ReadLine());
var c = 0;

switch (Op)
{
    case "+":
        c = X + Y;
        break;
    case "-":
        c = X - Y;
        break;
    case "*":
        c = X * Y;
        break;
    case "/":
        if (Y != 0)
        {
            c = X / Y;
        }
        else
        {
            Console.WriteLine("Not Allowed To Divide By Zero");
        }
        break;
    default:
        Console.WriteLine("Invalid Operator");
        break;
}
if (Y != 0)
{
    Console.WriteLine($"{X} {Op} {Y} = {c}");
}

//example 3
var xNumber = Convert.ToInt32(Console.ReadLine());
var yNumber = Convert.ToInt32(Console.ReadLine());
var tempNumber = yNumber;
yNumber = xNumber;
xNumber = tempNumber;
Console.WriteLine($"X = {xNumber} and Y = {yNumber}");


//example 4
var Number = Convert.ToInt32(Console.ReadLine());
int Answer;
for (int i = 0; i < 10; i++)
{
    Answer = Number * i;
    Console.WriteLine($"{Number} * {i} = {Answer}");
}


//example 5
var n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i * i);
    }
}


