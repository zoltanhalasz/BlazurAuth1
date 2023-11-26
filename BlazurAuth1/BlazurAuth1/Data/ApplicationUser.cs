using Microsoft.AspNetCore.Identity;

namespace BlazurAuth1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
       public  DateOnly? DateOfBirth {  get; set; }

        public string ? SiteUrl { get; set; }
    }

}
