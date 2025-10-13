using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.services
{
    internal class UserService<T>
    {
        private readonly List<T> _users = new List<T>();

        // Search methods using Predicate<T> for flexibility ========================================================================
        public T GetById(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            return _users.Find(predicate);
        }

        public T GetByUsername(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _users.Find(predicate);
        }

        public List<T> GetAll()
        {
            return new List<T>(_users);
        }


        // CRUD Operations ==========================================================================================================
        public void Add(T user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _users.Add(user);
        }

        public bool Delete(T user)
        {
            if (user == null)
                return false;

            return _users.Remove(user);
        }


        // Update method replaces the old user with the new user ====================================================================
        public bool Update(T oldUser, T newUser)
        {
            if (oldUser == null || newUser == null)
                return false;

            int index = _users.IndexOf(oldUser);

            if (index == -1)
                return false;

            _users[index] = newUser;
            return true;
        }

        // Utility Methods ==========================================================================================================
        public uint Count()
        {
            return (uint)_users.Count;
        }

        public void Clear()
        {
            _users.Clear();
        }

        public bool Contains(T user)
        {
            if (user == null)
                return false;
            return _users.Contains(user);
        }

        public void PrintAll()
        {
            foreach (var user in _users)
            {
                Console.WriteLine(user);
            }
        }

        public bool IdCheck(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _users.Exists(predicate);
        }

    }
}
