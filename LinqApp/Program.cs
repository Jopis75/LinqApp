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

Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadKey();



static void ExerciseWhere(List<Student> students)
{
    List<Student> studentsFound;

    // Hämta alla studenter som är äldre än 20.
    studentsFound = [.. students.Where(s => s.Alder > 20)];
    WriteResult($"Hittade {studentsFound.Count} student(er) som är äldre än 20.", studentsFound);

    // Hämta alla studenter som har mer än 80 poäng.
    studentsFound = [.. students.Where(s => s.Poang > 80)];
    WriteResult($"Hittade {studentsFound.Count} student(er) som har mer än 80 poäng.", studentsFound);
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