using OOP_Assignment_04.Q2.Interfaces;
namespace OOP_Assignment_04.Q2.Classes
{
    internal class BasicAuthenticationServic : IAuthenticationService
    {
        public bool UserAuthentication(string UserName, string Password)
        {
            if (UserName == "UserName" && Password == "Password")
            {
                return true;
            }
            return false;

        }

        public bool UserAuthorize(string UserName, string Role)
        {
            if (UserName == "UserName" && Role == "Admin")
            {
                return true;
            }
            return false;

        }
    }
}
