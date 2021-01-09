using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysecondFormsApp1
{
     class Users
    {
        public readonly static List<User> users;

        static Users()
        {
            users = new List<User>
            {
                new User("Faig", "Mamadov", 10, "qwert@gmail.com", "12345")};
            new User("Matin", "Manafov", 10, "qwerti@gmail.com", "1234");
            new User("admin", "admin");








        }


        public static bool HasUser(string password, string email)
        {
            bool userExists = false;
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                foreach (User u in users)
                {
                    if (u != null)
                    {

                        if (u.Email == email && u.Password == password)
                        {
                            userExists = true;
                        }
                    }
                }
            }
            return userExists;
        }

        public static User GetUser(string email, string password)
        {
            User user = null;

            if (HasUser(password, email))
            {
                foreach (User _user in users)
                {


                    if (user.Email == email && user.Password == password)
                    {
                        user = _user;
                        break;

                    }


                }
            }
            return user;
        }

        public static void AddUser(User user)
        {
            if (user != null)
            {
                if (!users.Contains(user))
                {
                    users.Add(user);
                }
            }


        }

        public static bool HasUser(User user)
        {
            bool userExists = false;
            if (user != null)
            {
                userExists = users.Contains(user) ? true : false;
            }
            return userExists;
        }

        public static List<User> GetUsers(string email, string password)
        {

            return users;
        }





    }
}
