namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Car newcar = new Car();

            newcar.Make = "Toyota";
            newcar.Model = "Camry";
            newcar.Year = 2023;

            Console.WriteLine($"Car Make: {newcar.Make}");
            Console.WriteLine($"Car Model: {newcar.Model}");
            Console.WriteLine($"Car Year: {newcar.Year}");

        }
    }
}
