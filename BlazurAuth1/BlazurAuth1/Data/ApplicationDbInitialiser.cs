using Microsoft.AspNetCore.Identity;

namespace BlazurAuth1.Data
{
    public static class ApplicationDbInitialiser
    {

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            AddRoleIfNotExists(roleManager, "Administrator");
            AddRoleIfNotExists(roleManager, "Moderator");
            AddRoleIfNotExists(roleManager, "TenantAdmin");
            AddRoleIfNotExists(roleManager, "User");
        }

        private static void AddRoleIfNotExists(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (roleManager.FindByNameAsync(roleName).Result == default)
            {
                roleManager.CreateAsync(new IdentityRole { Name = roleName }).Wait();
            }
        }
    }
}
