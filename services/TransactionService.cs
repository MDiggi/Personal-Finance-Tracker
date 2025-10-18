using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.services
{
    internal class TransactionService<T>
    {
        private readonly List<T> transations = new List<T>();

        // Search methods using Predicate<T> for flexibility ========================================================================
        public T GetById(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return transations.Find(predicate);
        }

        public T GetByUserId(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return transations.Find(predicate);

        }

        public T GetByCategoryId(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return transations.Find(predicate);
        }

        public List<T> GetAll()
        {
            return new List<T>(transations);
        }

        // CRUD Operations ==========================================================================================================
        public void Add(T transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            transations.Add(transaction);
        }

        public bool Delete(T transaction)
        {
            if (transaction == null)
                return false;
            return transations.Remove(transaction);
        }
        // Update method replaces the old transaction with the new transaction ====================================================
        public bool Update(T oldTransaction, T newTransaction)
        {
            if (oldTransaction == null || newTransaction == null)
                return false;

            int index = transations.IndexOf(oldTransaction);

            if (index < 0)
                return false;

            transations[index] = newTransaction;
            return true;
        }

        public void PrintAll()
        {
            foreach (var transaction in transations)
            {
                Console.WriteLine(transaction);
            }
        }

        public void PrintByUserId(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var filteredTransactions = transations.FindAll(predicate);

            foreach (var transaction in filteredTransactions)
            {
                Console.WriteLine(transaction);
            }
        }

        public uint Count()
        {
            return (uint)transations.Count;
        }
    }
}
