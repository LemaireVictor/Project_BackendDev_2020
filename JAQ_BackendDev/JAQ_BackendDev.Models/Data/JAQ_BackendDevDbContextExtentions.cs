using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JAQ_BackendDev.Models.Data
{
    public class JAQ_BackendDevDbContextExtentions
    {
        public async static Task SeedRoles(RoleManager<IdentityRole> RoleMgr)
        {
            IdentityResult roleResult;
            string[] roleNames = {"Admin", "Creator", "User"};
            foreach (var roleName in roleNames)
            {
                var roleExists = await RoleMgr.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    roleResult = await RoleMgr.CreateAsync(new IdentityRole(roleName));
                }
            }
        }

        public static async Task SeedUsers(UserManager<AppUser> userMgr)
        {
            // add Admin
            if (await userMgr.FindByEmailAsync("Docent@MCT.be") == null)
            {
                var user = new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "Docent@MCT",
                    Firstname = "admin",
                    Email = "Docent@MCT.be"
                };

                var userResult = await userMgr.CreateAsync(user, "Docent@1");
                var roleResult = await userMgr.AddToRoleAsync(user, "Admin");

                if (!userResult.Succeeded || !roleResult.Succeeded)
                {
                    throw new InvalidOperationException("Failed to build admin and add roles");
                }
            }

            // add User
            if (await userMgr.FindByEmailAsync("Victor@user.be") == null)
            {
                var user = new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "Victor@user",
                    Firstname = "Victor",
                    Email = "Victor@user.be"
                };

                var userResult = await userMgr.CreateAsync(user, "Victor@1");
                var roleResult = await userMgr.AddToRoleAsync(user, "User");

                if (!userResult.Succeeded || !roleResult.Succeeded)
                {
                    throw new InvalidOperationException("Failed to build admin and add roles");
                }

            }
            if (await userMgr.FindByEmailAsync("Victor@creator.be") == null)
            {
                var user = new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "Victor@creator",
                    Firstname = "Victor",
                    Email = "Victor@creator.be"
                };

                var userResult = await userMgr.CreateAsync(user, "Victor@1");
                var roleResult = await userMgr.AddToRoleAsync(user, "Creator");

                if (!userResult.Succeeded || !roleResult.Succeeded)
                {
                    throw new InvalidOperationException("Failed to build admin and add roles");
                }

            }
        }


    }
}
