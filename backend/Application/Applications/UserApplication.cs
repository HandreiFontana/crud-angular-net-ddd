using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Application.Applications
{
    public class UserApplication : IUserApplication
    {
        IUser _IUser;

        public UserApplication(IUser IUser)
        {
            _IUser = IUser;
        }

        public async Task<bool> AddUser(string email, string password, int age, string phone)
        {
            return await _IUser.AddUser(email, password, age, phone);
        }

        public async Task<bool> ExistUser(string email, string password)
        {
            return await _IUser.ExistUser(email, password);
        }
    }
}
