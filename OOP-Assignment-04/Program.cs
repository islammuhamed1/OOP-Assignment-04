using OOP_Assignment_04.Q1.Classes;
using OOP_Assignment_04.Q2.Classes;
using OOP_Assignment_04.Q3.Classes;

using System.Drawing;
using Rectangle = OOP_Assignment_04.Q1.Classes.Rectangle;

namespace OOP_Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 
            //Question 1:
            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            // Answer => b 

            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public

            // Answer => a

            //Question 3:
            //Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are read only

            // Answer => c

            //Question 4:
            //In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace

            // Answer => b

            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements

            // Answer  => d

            //Question 6:
            //Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private

            // Answer => a

            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed

            // Answer => b

            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            // Answer => b


            //Question 9:
            //In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static

            // Answer => d

            //Question 10:
            //How can a C# class implement multiple interfaces?
            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces

            // Answer => d

            #endregion
            #region Part 02
            #region q1
            //BasicAuthenticationService circle = new BasicAuthenticationService() { Radius = 50 };
            //circle.Radius = 10;
            //Rectangle rectangle = new Rectangle() { Height = 10, Width = 7 };
            //circle.Display();
            //rectangle.Display();
            #endregion
            #region q2
            //BasicAuthenticationServic user = new BasicAuthenticationServic();
            //string UserName = "UseName";
            //string Password = "Password";

            //if(user.UserAuthentication(UserName , Password))
            //{
            //    string Role = "Admin";
            //    if(user.UserAuthorize(UserName , Role))
            //    {
            //        Console.WriteLine(" Authenticated and Autherized") ;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Authenticated");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("No Authentication & Autherization") ;
            //}
            #endregion
            #region q3
            //EmailNotificationService email = new EmailNotificationService();
            //PushNotificationService push = new PushNotificationService();
            //SmsNotificationService sms = new SmsNotificationService();

            //email.Display("Islam", "Mohamed");
            //Console.WriteLine();
            //push.Display("RealMadrid", "Above");
            //Console.WriteLine();
            //sms.Display("Hala Madrid", "Ya Nada Mas");

            #endregion
            #endregion
        }
    }
}
