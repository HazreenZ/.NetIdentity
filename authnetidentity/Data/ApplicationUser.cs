using Microsoft.AspNetCore.Identity;

namespace authnetidentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DateofBirth  { get; set; } 
    }

}
