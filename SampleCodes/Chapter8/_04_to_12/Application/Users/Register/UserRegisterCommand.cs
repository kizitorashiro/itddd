﻿namespace _04_to_12.Application.Users.Register
{
    public class UserRegisterCommand
    {
        public UserRegisterCommand(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
