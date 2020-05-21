namespace Actio.Common.Commands
{
    public class AuthenticatedUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
