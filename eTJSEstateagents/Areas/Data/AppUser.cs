using Microsoft.AspNetCore.Identity;

namespace eTJSEstateagents.Areas.Data
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
    }
}
