using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.models
{
    internal class User
    {
        private uint? id
        private string? username;
        private string? password;
        private string? email;
        private DateTime? createdAt;
        private List<Transaction> transactions;
        private List<Category> categories;
        private decimal? balance;

        //Constructors
        // Parameterized constructor
        public User(uint id, string username, string password, string email, DateTime createdAt, List<Transaction> transactions, List<Category> categories, decimal balance)
        {
            this.id =             id;
            this.username =       username;
            this.password =       password;
            this.email =          email;
            this.createdAt =      createdAt;
            this.transactions =   transactions;
            this.categories =     categories;
            this.balance =        balance;
        }

        // Normal User constructor
        public User(uint id, string username, string password, string email)
        {
            this.id =             id;
            this.username =       username;
            this.password =       password;
            this.email =          email;
            this.createdAt =      DateTime.Now;
            this.transactions =   new List<Transaction>();
            this.categories =     new List<Category>();
            this.balance =        0;
        }

        // Default constructor
        public User()
        {
            this.id = 0;
            this.username =       "User Test";
            this.password =       "password";
            this.email =          "insert@email.com";
            this.createdAt =      DateTime.MinValue;
            this.transactions =   new List<Transaction>();
            this.categories =     new List<Category>();
            this.balance =        0;

        }

        // Getters
        public uint GetId()                             { return (uint)id; }
        public string GetUsername()                     { return username; }
        public string GetPassword()                     { return password; }
        public string GetEmail()                        { return email; }
        public DateTime GetCreatedAt()                  { return (DateTime)createdAt; }
        public List<Transaction> GetTransactions()      { return transactions; }
        public List<Category> GetCategories()           { return categories; }
        public decimal GetBalance()                     { return (decimal)balance; }

        // Setters
        public void SetId(uint id)                                      { this.id = id; }
        public void SetUsername(string username)                        { this.username = username; }
        public void SetPassword(string password)                        { this.password = password; }
        public void SetEmail(string email)                              { this.email = email; }
        public void SetCreatedAt(DateTime createdAt)                    { this.createdAt = createdAt; }
        public void SetTransactions(List<Transaction> transactions)     { this.transactions = transactions; }
        public void SetCategories(List<Category> categories)            { this.categories = categories; }
        public void SetBalance(decimal balance)                         { this.balance = balance; }

        override
            public string ToString()
        {
            return $"User [id={id}, username={username}, password={password}, email={email}, createdAt={createdAt}, balance={balance}, transactions count={transactions.Count}, categories count={categories.Count}]";
        }
    }
}
