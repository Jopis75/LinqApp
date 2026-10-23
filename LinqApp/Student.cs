namespace LinqApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Namn { get; set; } = "";
        public int Alder { get; set; }
        public string Klass { get; set; } = "";
        public int Poang { get; set; }

        public void Write()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Namn: {Namn}");
            Console.WriteLine($"Ålder: {Alder}");
            Console.WriteLine($"Klass: {Klass}");
            Console.WriteLine($"Poäng: {Poang}");
        }
    }
}
