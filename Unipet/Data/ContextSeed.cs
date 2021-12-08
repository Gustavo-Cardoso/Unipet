using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using Unipet.Models;

namespace Unipet.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Perfis.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Perfis.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Perfis.Parceiro.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Perfis.Tutor.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // Seed Default User
            var defaultUser = new Usuario
            {
                UserName = "Unipet",
                Email = "unipet@gmail.com",
                Nome = "Administrador Unipet",
                DataNascimento = DateTime.Parse("10/11/1983"),
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "@Etec123");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Perfis.Tutor.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Perfis.Parceiro.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Perfis.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Perfis.SuperAdmin.ToString());
                }
            }
        }
    }
}
