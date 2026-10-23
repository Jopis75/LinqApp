using LinqApp;


// Exempeldata
List<Student> students = new List<Student>
{
    new() { Id = 1, Namn = "Anna", Alder = 19, Klass = "A", Poang = 85 },
    new() { Id = 2, Namn = "Bertil", Alder = 22, Klass = "B", Poang = 72 },
    new() { Id = 3, Namn = "Cecilia", Alder = 20, Klass = "A", Poang = 91 },
    new() { Id = 4, Namn = "David", Alder = 24, Klass = "C", Poang = 64 },
    new() { Id = 5, Namn = "Eva", Alder = 19, Klass = "B", Poang = 85 },
    new() { Id = 6, Namn = "Felix", Alder = 21, Klass = "A", Poang = 77 },
    new() { Id = 7, Namn = "Gustav", Alder = 23, Klass = "C", Poang = 58 },
    new() { Id = 8, Namn = "Hanna", Alder = 20, Klass = "B", Poang = 95 }
};

Console.WriteLine("LINQ-ÖVNINGAR MED STUDENTER\n");
Console.WriteLine();

ExerciseWhere(students);
Console.WriteLine();

ExerciseSelect(students);
Console.WriteLine();

ExerciseOrderBy(students);
Console.WriteLine();

ExerciseCount(students);
Console.WriteLine();

ExerciseTake(students);
Console.WriteLine();

ExerciseDistinct(students);
Console.WriteLine();

ExerciseAnyAndAll(students);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadKey();



static void ExerciseWhere(List<Student> students)
{
    List<Student> result;

    // Hämta alla studenter som är äldre än 20.
    result = [.. students.Where(s => s.Alder > 20)];
    WriteResult("Hämta alla studenter som är äldre än 20.", result);

    Console.WriteLine();

    // Hämta alla studenter som har mer än 80 poäng.
    result = [.. students.Where(s => s.Poang > 80)];
    WriteResult("Hämta alla studenter som har mer än 80 poäng.", result);
}

static void ExerciseSelect(List<Student> students)
{
    // Visa bara namnen på alla studenter.
    var names = students.Select(s => s.Namn).ToList();
    Console.WriteLine("Visa bara namnen på alla studenter.");
    Console.WriteLine();
    foreach (var name in names)
    {
        Console.WriteLine($"Namn: {name}");
    }

    Console.WriteLine();

    // Visa namn och poäng i en ny anonym typ.
    var items = students.Select(s => new { s.Namn, s.Poang });
    Console.WriteLine("Visa namn och poäng i en ny anonym typ.");
    Console.WriteLine();
    foreach (var item in items)
    {
        Console.WriteLine($"Namn: {item.Namn}");
        Console.WriteLine($"Poäng: {item.Poang}");
        Console.WriteLine();
    }
}

static void ExerciseOrderBy(List<Student> students)
{
    List<Student> result;

    // Sortera studenter efter ålder.
    result = [.. students.OrderBy(s => s.Alder)];
    WriteResult("Sortera studenter efter ålder.", result);

    Console.WriteLine();

    // Sortera studenter efter poäng, högst först.
    result = [.. students.OrderByDescending(s => s.Poang)];
    WriteResult("Sortera studenter efter poäng, högst först.", result);
}

static void ExerciseCount(List<Student> students)
{
    int count;

    // Räkna hur många studenter som finns.
    count = students.Count;
    Console.WriteLine("Räkna hur många studenter som finns.");
    Console.WriteLine();
    Console.WriteLine($"{count} studenter.");

    Console.WriteLine();

    // Räkna hur många som går i klass A.
    count = students.Count(s => s.Klass.Equals("A"));
    Console.WriteLine("Räkna hur många som går i klass A.");
    Console.WriteLine();
    Console.WriteLine($"{count} studenter.");
}

static void ExerciseTake(List<Student> students)
{
    // Ta ut de tre första studenterna.
    List<Student> result = [.. students.Take(3)];
    WriteResult("Ta ut de tre första studenterna.", result);

    Console.WriteLine();

    // Ta ut de två bästa poängen efter sortering.
    var scores = students.OrderByDescending(s => s.Poang).Select(s => s.Poang).ToList();
    Console.WriteLine("Ta ut de två bästa poängen efter sortering.");
    Console.WriteLine();
    foreach (var score in scores)
    {
        Console.WriteLine($"Poäng: {score}");
    }
}

static void ExerciseDistinct(List<Student> students)
{
    // Visa alla unika klassnamn.
    var classNames = students.Select(s => s.Namn).Distinct();
    Console.WriteLine("Visa alla unika klassnamn.");
    Console.WriteLine();
    foreach (var className in classNames)
    {
        Console.WriteLine($"Klass: {className}");
    }

    Console.WriteLine();

    // Visa alla unika åldrar.
    var ages = students.Select(s => s.Alder).Distinct();
    Console.WriteLine("Visa alla unika åldrar.");
    Console.WriteLine();
    foreach (var age in ages)
    {
        Console.WriteLine($"Ålder: {age}");
    }
}

static void ExerciseAnyAndAll(List<Student> students)
{
    bool result;

    // Finns det någon student med 100 poäng?
    result = students.Any(s => s.Poang == 100);
    Console.WriteLine("Finns det någon student med 100 poäng?");
    Console.WriteLine();
    Console.WriteLine($"{result}");

    Console.WriteLine();

    // Har alla studenter minst 50 poäng?
    result = students.All(s => s.Poang >= 50);
    Console.WriteLine("Har alla studenter minst 50 poäng?");
    Console.WriteLine();
    Console.WriteLine($"{result}");
}

static void ExerciseFirstOrDefaultAndLastAndSingle(List<Student> students)
{
    // Hämta första studenten i klass B.

    // Hämta sista studenten i listan.

    // Hämta studenten med ett visst Id.
}

static void WriteResult(string text, List<Student> students)
{
    Console.WriteLine(text);
    Console.WriteLine();

    foreach (var student in students)
    {
        student.Write();
        Console.WriteLine();
    }
}