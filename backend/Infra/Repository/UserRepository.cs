﻿using Domain.Interfaces;
using Entidades.Entidades;
using Infra.Configs;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    internal class UserRepository : GenericRepository<ApplicationUser>, IUser
    {
        private readonly DbContextOptions<Context> _optionsBuilder;

        public UserRepository()
        {
            _optionsBuilder = new DbContextOptions<Context>();
        }


        public async Task<bool> AddUser(string email, string password, int age, string phone)
        {
            try
            {
                using (var data = new Context(_optionsBuilder))
                {
                    await data.applicationUser.AddAsync(
                        new ApplicationUser
                        {
                            Email = email,
                            PasswordHash = password,
                            Age = age,
                            Phone = phone
                        });
                    await data.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
            
        }
    }
}