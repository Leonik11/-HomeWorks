// See https://aka.ms/new-console-template for more information

//example 1
Console.WriteLine("Enter the size of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] inputArray = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
    inputArray[i] = i + 1;
}


int[] evenArray = new int[arraySize];
int evenCount = 0;

int[] oddArray = new int[arraySize];
int oddCount = 0;

for (int i = 0; i < arraySize; i++)
{
    if (inputArray[i] % 2 == 0)
    {
        evenArray[evenCount] = inputArray[i];
        evenCount++;
    }
    else
    {
        oddArray[oddCount] = inputArray[i];
        oddCount++;
    }
}

Console.WriteLine("Array 1: ");
for (int i = 0; i < evenCount; i++)
{
    Console.WriteLine($"{evenArray[i]} ");
}


Console.WriteLine("Array 2: ");
for (int i = 0; i < oddCount; i++)
{
    Console.WriteLine($"{oddArray[i]} ");
}

Console.WriteLine();


//example 2
 var contacts = new Dictionary<string, string>();

Console.WriteLine("Contacts Menu:");
Console.WriteLine("1. Add a contact");
Console.WriteLine("2. Delete a contact");
Console.WriteLine("3. Update a contact");
Console.WriteLine("4. Display all contacts");
Console.WriteLine("Enter your choice (Please use only number): ");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Write("Enter the name: ");
        var name = Console.ReadLine();
    
        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists!");
        }
        else
        {
            Console.Write("Enter the phone number: ");
            var phoneNumber = Console.ReadLine();

            contacts.Add(name, phoneNumber);
            Console.WriteLine("Contact added successfully!");
        }
        break;
    case "2":
        Console.Write("Enter the name to delete: ");
        var deleteName = Console.ReadLine();

        if (contacts.ContainsKey(deleteName))
        {
            contacts.Remove(deleteName);
            Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
        break;
    case "3":
        Console.Write("Enter the name to update: ");
        var updateName = Console.ReadLine();

        if (contacts.ContainsKey(updateName))
        {
            Console.Write("Enter the new phone number: ");
            var newPhoneNumber = Console.ReadLine();

            contacts[updateName] = newPhoneNumber;
            Console.WriteLine("Contact updated successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
        break;
    case "4":
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.");
        }
        else
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }
        break;
    default:
        Console.WriteLine("Invalid choice. Please enter a valid option.");
        break;
}

//example 3


Console.WriteLine("Enter array's size (Please use only number): ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Enter {arrayLength} elements:");
var listOfNumbers = new List<int>();

for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        listOfNumbers.Add(number);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--; 
    }
}

Console.WriteLine("Entered elements:");
foreach (var item in listOfNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("- - - - ");

var filteredResult2 = from number in listOfNumbers where !number.ToString().Contains('i') group number by number into n
                      select new
                      {
                          Element = n.Key,
                          Count = n.Count(),
                          Sum = n.Key * n.Count()
                      };

foreach (var item in filteredResult2)
{
    Console.WriteLine($"{item.Element} appears {item.Count} times sum {item.Sum}");
}

//example 4

Console.WriteLine("Enter the number of top participants to display: ");
int x = Convert.ToInt32(Console.ReadLine());

var scores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var topScore = (
    from score in scores
    orderby score descending
    select score
).Take(x);

Console.WriteLine($"Top {x} participants: ");

foreach (var score in topScore)
{
    Console.WriteLine($"{score} ");
}
