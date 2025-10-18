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
        private readonly List<T> users = new List<T>();

        /*
============================================================================================================

                //=====================================================================
                //IdCheck,UsernameCheck and EmailCheck Methods to check if a user exists based on ID or Username
                //These methods return true if a user matching the predicate exists, otherwise false.
                //Please do a little bit of research on Predicate<T> to understand how to implement these methods.
                //And then explain them to me so we are on the same page.
                //=====================================================================
                //In the case that you can't get to understand Predicate<T>
                //try and solve it in another way and explain it totally too, so I can understand it.
                //=====================================================================

                public bool IdCheck(Predicate<T> predicate)
                {
                }
                 public bool UsernameCheck(Predicate<T> predicate)
                {
                }
                public bool EmailCheck(Predicate<T> predicate)
                {
                }

============================================================================================================




        //=====================================================================
        //These pretty much return the user based on ID or Username
        //Please try to use Predicate<T> to implement these methods if you are sucessful in the above methods.
        //=====================================================================
        /*


        public T GetById()
        {
        }

        public T GetByUsername()
        {
        }

        

============================================================================================================



        //=====================================================================
        //These pretty much print the user based on ID or Username
        //Please try to use Predicate<T> to implement these methods if you are sucessful in the above methods.
        //=====================================================================
        /*


        public void PrintById(uint id)
        {
            var user = users.Find(u =>
            {
                var userIdProperty = u.GetType().GetProperty("id") ?? u.GetType().GetProperty("Id");
                if (userIdProperty != null)
                {
                    var value = userIdProperty.GetValue(u);
                    if (value is uint userId)
                    {
                        return userId == id;
                    }
                }
                return false;
            });
            if (user != null)
            {
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
            }
        }

        public void PrintUserByUsername(string username)
        {
            var user = users.Find(u =>
            {
                var usernameProperty = u.GetType().GetProperty("username") ?? u.GetType().GetProperty("Username");
                if (usernameProperty != null)
                {
                    var value = usernameProperty.GetValue(u);
                    if (value is string userUsername)
                    {
                        return userUsername.Equals(username, StringComparison.OrdinalIgnoreCase);
                    }
                }
                return false;
            });
            if (user != null)
            {
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine($"User with username '{username}' not found.");
            }
        }

============================================================================================================
        */

        public List<T> GetAll()
        {
            return new List<T>(users);
        }

        // CRUD Operations ==========================================================================================================
        public void Add(T user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            users.Add(user);
        }

        public bool Delete(T user)
        {
            if (user == null)
                return false;

            return users.Remove(user);
        }


        // Update method replaces the old user with the new user ====================================================================
        public bool Update(T oldUser, T newUser)
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

        public bool Contains(T user)
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

        public void PrintUser(User user)
        {
            if (user != null)
            {
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public string PrintUserCategories(User user)
        {
                return user==null ? "User not found." : user.PrintCategories();
        }
        
        public string PrintUserTransactions(User user)
        {
            return user == null ? "User not found." : user.PrintTransactions();

        }
    }
}
