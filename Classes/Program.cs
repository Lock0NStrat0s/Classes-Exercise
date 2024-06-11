namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Class = new Car();
            Class.Make = "GMC";
            Class.Model = "Terrain";
            Class.Year = 2014;

            Console.WriteLine($"Make: {Class.Make}");
            Console.WriteLine($"Model: {Class.Model}");
            Console.WriteLine($"Year: {Class.Year}");
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
