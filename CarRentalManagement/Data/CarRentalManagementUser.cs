using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRentalManagementUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
