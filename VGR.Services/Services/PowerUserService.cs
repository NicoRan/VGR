using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VGR.Data.Context;
using VGR.Models;
using VGR.Services.Contracts;

namespace VGR.Services.Services
{
    public class PowerUserService : IPowerUserService
    {
        private readonly VGRDbContext _dbContext;

        public PowerUserService(VGRDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PowerUser> FindUserAsync(string email)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }

        public async Task<PowerUser> CreateUserAsync(string email)
        {
            var user = await FindUserAsync(email);
            if (user == null)
            {
                var newUser = new PowerUser { Email = email };
                await _dbContext.Users.AddAsync(newUser);
                await _dbContext.SaveChangesAsync();
                return newUser;
            }
            return user;
        }
    }
}
