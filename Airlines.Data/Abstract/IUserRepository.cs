﻿using Airlines.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airlines.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        User GetById(int UserId);
        void AddUser(User entity);
        User GetByName(string UserName);
        User GetByPassword(string UserPassword);
        void UpdateUser(User entity);
        void DeleteUser(int UserId);
    }
}
