using Personal_Finance_Tracker.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.services
{
    internal class UserService<T>
    {
        private readonly List<User> users = new List<User>();

        public bool IdCheck(uint id)
        {
            foreach (var user in users)
            {
                if (user.GetId() == id)
                    return true;
            }
            return false;
        }

        public bool UsernameCheck(string username)
        {
            foreach (var user in users)
            {
                if (user.GetUsername() == username)
                    return true;
            }
            return false;
        }

        public bool EmailCheck(string email)
        {
            foreach (var user in users)
            {
                if (user.GetEmail() == email)
                    return true;
            }
            return false;
        }


        public User GetById( uint id )
        {
           foreach (var user in users)
           {
                if (user.GetId() == id)
                     return user;
           }
           return null;
        }

        public User GetByUsername(string username)
        {
            foreach (var user in users)
            {
                if (user.GetUsername() == username)
                    return user;
            }
            return null;
        }

        public List<User> GetAll()
        {
            return new List<User>(users);
        }

        // CRUD Operations ==========================================================================================================
        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            users.Add(user);
        }

        public bool Delete(User user)
        {
            if (user == null)
                return false;

            return users.Remove(user);
        }


        // Update method replaces the old user with the new user ====================================================================
        public bool Update(User oldUser, User newUser)
        {
            if (oldUser == null || newUser == null)
                return false;

            int index = users.IndexOf(oldUser);

            if (index == -1)
                return false;

            users[index] = newUser;
            return true;
        }

        // Utility Methods ==========================================================================================================
        public uint Count()
        {
            return (uint)users.Count;
        }

        public void Clear()
        {
            users.Clear();
        }

        public bool Contains(User user)
        {
            if (user == null)
                return false;
            return users.Contains(user);
        }

        public void PrintAll()
        {
            foreach (var user in users)
            {
                Console.WriteLine("===============================================================");
                Console.WriteLine(user);
                Console.WriteLine("===============================================================");
            }
        }
    }
}
