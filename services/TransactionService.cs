using Personal_Finance_Tracker.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.services
{
    internal class TransactionService<T>
    {
        private readonly List<Transaction> transations = new List<Transaction>();

        public Transaction GetById(uint id)
        {
            foreach (var transaction in transations)
            {
                if (transaction.GetId() == id)
                {
                    return transaction;
                }
            }
            return null;
        }

        public List<Transaction> GetByUserId(uint userID)
        {
            List<Transaction> userTransactions = new List<Transaction>();
            foreach (var transaction in transations)
            {
                if (transaction.GetUserId() == userID)
                {
                    userTransactions.Add(transaction);
                }
            }
            return userTransactions;
        }

        public List<Transaction> GetByCategoryId(uint categoryId)
        {
            List<Transaction> categoryTransactions = new List<Transaction>();
            foreach (var transaction in transations)
            {
                if (transaction.GetCategory().GetId() == categoryId)
                {
                    categoryTransactions.Add(transaction);
                }
            }
            return categoryTransactions;
        }

        public List<Transaction> GetAll()
        {
            return new List<Transaction>(transations);
        }

        public void Add(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            transations.Add(transaction);
        }

        public bool Delete(Transaction transaction)
        {
            if (transaction == null)
                return false;
            return transations.Remove(transaction);
        }

        public bool Update(Transaction oldTransaction, Transaction newTransaction)
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

        public uint Count()
        {
            return (uint)transations.Count;
        }
    }
}
