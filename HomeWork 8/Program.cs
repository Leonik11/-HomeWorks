// See https://aka.ms/new-console-template for more information


// example 1
Console.WriteLine("example 1");
Console.WriteLine(CountNumbersWithPowerInRange(49, 71, 2));
Console.WriteLine(CountNumbersWithPowerInRange(2, 27, 4));
Console.WriteLine("----------------------------------------");

static int CountNumbersWithPowerInRange(int a, int b, int n)
{
    int count = 0;

    for (int i = 1; i <= b; i++)
    {
        if (Math.Pow(i, n) >= a && Math.Pow(i, n) <= b)
        {
            count++;
        }
    }
    return count;
}

//example 2
Console.WriteLine("example 2");
Console.WriteLine(CountPairsOfSocks("AA"));    
Console.WriteLine(CountPairsOfSocks("AABBCC"));   
Console.WriteLine(CountPairsOfSocks("AABBC"));    
Console.WriteLine(CountPairsOfSocks("ABABC"));    
Console.WriteLine(CountPairsOfSocks("AAABB"));    
Console.WriteLine("----------------------------------------");

static int CountPairsOfSocks(string socks)
{
    Dictionary<char, int> sockCounts = new Dictionary<char, int>();

 
    foreach (char sock in socks)
    {
        if (!sockCounts.ContainsKey(sock))
        {
            sockCounts[sock] = 0;
        }
        sockCounts[sock]++;
    }

    int pairCount = 0;
    foreach (int count in sockCounts.Values)
    {
        pairCount += count / 2;
    }

    return pairCount;
}

//example 3
Console.WriteLine("example 3");
Console.WriteLine(GetCommonSuffix("multiplication", "subtraction")); 
Console.WriteLine(GetCommonSuffix("Some Random Text", "It is Some Random Text")); 
Console.WriteLine("----------------------------------------");

static string GetCommonSuffix(string str1, string str2)
{
    int len1 = str1.Length;
    int len2 = str2.Length;
    int len = Math.Min(len1, len2);
    int i = 1;

    while (i <= len && str1[len1 - i] == str2[len2 - i])
    {
        i++;
    }

    return str1.Substring(len1 - i + 1);
}


//example 4
Console.WriteLine("example 4");
var strings = new List<string> { "test", "random", "programing", "word" };
var ints = new List<int> { 5, 5 };
var booleans = new List<bool> { true, false, true, false, true, false, false};

PrintListOperation(strings);
PrintListOperation(ints);
PrintListOperation(booleans);
Console.WriteLine("----------------------------------------");
static void PrintListOperation<T>(List<T> list)
{
    if (typeof(T) == typeof(string))
    {
        foreach (T item in list)
        {
            Console.WriteLine(item.ToString().ToUpper());
        }
    }
    else if (IsNumeric(typeof(T)))
    {
        Console.WriteLine(SumListOperation(list.Cast<dynamic>().ToList()));
    }
    else if (typeof(T) == typeof(bool))
    {
        PrintBoolListOperation(list.Cast<dynamic>().ToList());
    }
    else
    {
        Console.WriteLine("Unsupported type.");
    }
}

static bool IsNumeric(Type type)
{
    return type == typeof(byte) ||
           type == typeof(sbyte) ||
           type == typeof(short) ||
           type == typeof(ushort) ||
           type == typeof(int) ||
           type == typeof(uint) ||
           type == typeof(long) ||
           type == typeof(ulong) ||
           type == typeof(float) ||
           type == typeof(double) ||
           type == typeof(decimal);
}

static int SumListOperation(List<dynamic> list)
{
    int sum = 0;
    foreach (var item in list)
    {
        sum += item;
    }
    return sum;
}

static void PrintBoolListOperation(List<dynamic> list)
{
    Console.WriteLine($"First: {list.First()}, Middle: {list[list.Count / 2]}, Last: {list.Last()}");
}
//example 5
Console.WriteLine("example 5");
PrintNumberCharacters(12345);
Console.WriteLine("----------------------------------------");

static void PrintNumberCharacters(int number)
{
    string numberString = number.ToString();

    for (int i = 0; i < numberString.Length; i++)
    {
        Console.Write(numberString[i]);

        if (i < numberString.Length - 1)
        {
            Console.Write(" - ");
        }
    }
    Console.WriteLine();
}

//example 6
Console.WriteLine("example 5");

int[] nums1 = { 1, 2, 3, 1 };
int[] nums2 = { 1, 2, 3, 4, };

Console.WriteLine(ContainsDuplicates(nums1)); 
Console.WriteLine(ContainsDuplicates(nums2));
Console.WriteLine("----------------------------------------");
static bool ContainsDuplicates(int[] nums)
{
    var seen = new HashSet<int>();

    foreach (int num in nums)
    {
        if (seen.Contains(num))
        {
            return true;
        }
        else
        {
            seen.Add(num);
        }
    }

    return false;
}