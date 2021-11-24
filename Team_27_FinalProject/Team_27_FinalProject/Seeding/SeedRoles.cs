﻿using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Team_27_FinalProject.Seeding
{
    public class SeedRoles
    {
        public static async Task AddAllRoles(RoleManager<IdentityRole> roleManager)
        {
            //Add the needed roles - admin and customer are provided
            //as examples
            //if the admin role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Admin") == false)
            {
                //this code uses the role manager object to create the admin role
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            //if the customer role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Customer") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }
            //if the customer role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Host") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Host"));
            }
        }
    }

}