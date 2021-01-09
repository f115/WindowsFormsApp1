﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysecondFormsApp1
{
    class User
    {
        private byte _age = default;

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public User(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public User(string name, string surname, byte age, string email, string password)
        {
         if(string.IsNullOrEmpty(name)||(string.IsNullOrEmpty(surname)||(string.IsNullOrEmpty(email)||(string.IsNullOrEmpty(password)))))
            throw new ArgumentNullException();
            if (!sbyte.TryParse(age.ToString(), out sbyte result))
                throw new FormatException();


                Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }

         

        public string Name { get; set; } = default;


        public string Surname { get; set; } = default;


        public byte Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }


            }

        }

        public string Email { get; set; } = default;

        public string Password { get; set; } = default;

        public string ProfileicturePath { get; set; } = default;

        public UserRole  UserRole { get; set; } = default;



    }
}

