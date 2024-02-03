// See https://aka.ms/new-console-template for more information



//example 1

class Company
{
    private readonly bool isLocal;

    public Company(bool isLocal)
    {
        this.isLocal = isLocal;
    }

    public double CalculateStateTaxes(double totalSalary)
    {
        if (isLocal)
        {
            return 0.18 * totalSalary;
        }
        else
        {
            return 0.05 * totalSalary;
        }
    }
}

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int[] WeeklyHours { get; set; }

    public Employee(string name, string surname, int age, string position, int[] weeklyHours)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        WeeklyHours = weeklyHours;
    }

    public double CalculateAverageSalary()
    {
        int totalHours = 0;
        foreach (int hours in WeeklyHours)
        {
            totalHours += hours;
        }

        double hourlyRate;
        switch (Position.ToLower())
        {
            case "manager":
                hourlyRate = 40;
                break;
            case "developer":
                hourlyRate = 30;
                break;
            case "tester":
                hourlyRate = 20;
                break;
            default:
                hourlyRate = 10;
                break;
        }

        double totalSalary = 0;

        for (int i = 0; i < WeeklyHours.Length; i++)
        {
            totalSalary += CalculateWeeklySalary(WeeklyHours[i], hourlyRate);
        }

        double averageSalary = totalSalary / WeeklyHours.Length;
        return averageSalary;
    }

    private double CalculateWeeklySalary(int hours, double hourlyRate)
    {
        double salary;
        if (hours <= 40)
        {
            salary = hours * hourlyRate;
        }
        else
        {
            salary = 40 * hourlyRate + (hours - 40) * (hourlyRate + 5);
        }

        return salary;
    }
}

//example 3
class Student
{
    protected string name;

    public string Name
    {
        get { return name; }
    }

    public Student(string name)
    {
        this.name = name;
    }

    public virtual void Study()
    {
        Console.WriteLine($"{name} is studying.");
    }

    public virtual void Read()
    {
        Console.WriteLine($"{name} is reading.");
    }

    public virtual void Write()
    {
        Console.WriteLine($"{name} is writing.");
    }

    public virtual void Relax()
    {
        Console.WriteLine($"{name} is relaxing.");
    }
}

class GoodStudent : Student
{
    public GoodStudent(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine($"{Name} is studying hard.");
    }
}

class LazyStudent : Student
{
    public LazyStudent(string name) : base(name)
    {
    }

    public override void Relax()
    {
        Console.WriteLine($"{Name} is relaxing instead of studying.");
    }
}

class ClassRoom
{
    private List<Student> students;

    public ClassRoom(List<Student> students)
    {
        this.students = students;
    }

    public void PrintStudentActivities()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Activities of {student.GetType().Name} {student.Name}:");
            student.Study();
            student.Read();
            student.Write();
            student.Relax();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // example 1
        Company localCompany = new Company(true);

        Employee employee1 = new Employee("John", "Doe", 30, "manager", new int[] { 8, 8, 8, 8, 8, 0, 0 });
        Employee employee2 = new Employee("Jane", "Smith", 25, "developer", new int[] { 8, 8, 8, 8, 8, 0, 0 });

        double totalSalary = employee1.CalculateAverageSalary() + employee2.CalculateAverageSalary();

        double stateTaxes = localCompany.CalculateStateTaxes(totalSalary);
        Console.WriteLine("Example 1:");
        Console.WriteLine($"Total salary: {totalSalary}");
        Console.WriteLine($"Total state taxes: ${stateTaxes}");

        Console.WriteLine("-------------------------------");


        GoodStudent goodStudent1 = new("Alice");
        GoodStudent goodStudent2 = new("Bob");
        LazyStudent lazyStudent1 = new("Charlie");
        LazyStudent lazyStudent2 = new("Diana");

        var students = new List<Student> { goodStudent1, goodStudent2, lazyStudent1, lazyStudent2 };

        ClassRoom classRoom = new ClassRoom(students);
        Console.WriteLine("Example 3:");
        classRoom.PrintStudentActivities();
    }
}