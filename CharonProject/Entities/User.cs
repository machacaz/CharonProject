namespace Charon.Entities
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public bool IsAPIUser { get; set; }
    }
}
