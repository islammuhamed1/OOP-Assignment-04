using OOP_Assignment_04.Q3.Interfaces;

namespace OOP_Assignment_04.Q3.Classes
{
    internal class EmailNotificationService : INotificationService
    {
        public void Display(string message, string recipent)
        {
            Console.WriteLine($"Email Notification to {recipent}");
            Console.WriteLine($"Message : {message}");
        }
    }
}
