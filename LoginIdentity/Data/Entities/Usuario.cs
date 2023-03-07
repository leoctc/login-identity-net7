using Microsoft.AspNetCore.Identity;

namespace LoginIdentity.Data.Entities
{
    public class Usuario : IdentityUser
    {
        private string Login { get; set; }

        private string Senha { get; set; }
    }
}
