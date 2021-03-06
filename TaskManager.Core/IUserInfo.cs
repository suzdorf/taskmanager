﻿using TaskManager.Core.Enums;

namespace TaskManager.Core
{
    public interface IUserInfo 
    {
        string Email { get; }
        string FirstName { get; }
        string LastName { get; }
        string Username { get; }
        Role Role { get; }
    }
}