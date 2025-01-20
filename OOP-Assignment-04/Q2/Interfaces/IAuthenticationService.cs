namespace OOP_Assignment_04.Q2.Interfaces
{
    internal interface IAuthenticationService
    {
        public bool UserAuthentication(string UserName, string Password);
        public bool UserAuthorize(string UserName, string Role);
    }
}