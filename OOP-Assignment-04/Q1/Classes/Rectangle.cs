using OOP_Assignment_04.Q1.Interfaces;

namespace OOP_Assignment_04.Q1.Classes
{
    class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public void Display()
        {
            Console.WriteLine($" Area = {Area} ");
        }
    }
}
