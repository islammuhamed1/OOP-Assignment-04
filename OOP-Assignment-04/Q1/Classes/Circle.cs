using OOP_Assignment_04.Q1.Interfaces;

namespace OOP_Assignment_04.Q1.Classes
{
    class BasicAuthenticationService : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public void Display()
        {
            Console.WriteLine($"Radius = {Radius} & Area = {Area}");
        }
    }
}
