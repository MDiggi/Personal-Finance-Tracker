using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.models
{
    internal class Transaction
    {
        private uint? id;
        private uint? userId;
        private DateTime? date;
        private string? description;
        private decimal? amount;
        private Category? category;
        private TransactionType? flag;


        //Constructors
        // Parameterized constructor
        public Transaction(uint id,uint userId , DateTime date, string description, decimal amount, Category category, TransactionType flag)
        {
            this.id = id;
            this.userId = userId;
            this.date = date;
            this.description = description;
            this.amount = amount;
            this.category = category;
            this.flag = flag;
        }

        // Normal Transaction constructor
        public Transaction(uint userId, string description, decimal amount, string categoryName, string categoryDescription)
        {
            this.id = 0;
            this.userId = userId;
            this.description = description;
            this.date = DateTime.Now;
            this.description = description;
            this.amount = amount;

            this.category = new Category(0, categoryName, categoryDescription);
            this.flag = amount >= 0 ? TransactionType.Income : TransactionType.Expense;
        }

        // Default constructor
        public Transaction()
        {
            this.id = 0;
            this.userId = 0;
            this.date = DateTime.MinValue;
            this.description = string.Empty;
            this.amount = 0;
            this.category = new Category();
            this.flag = TransactionType.None;
        }

        // Getters
        public uint GetId() { return (uint)id; }
        public uint GetUserId() { return (uint)userId; }
        public DateTime GetDate() { return (DateTime)date; }
        public string GetDescription() { return description; }
        public decimal GetAmount() { return (decimal)amount; }
        public Category GetCategory() { return category; }

        // Setters
        public void SetId(uint id) { this.id = id; }
        public void SetUserId(uint userId) { this.userId = userId; }
        public void SetDate(DateTime date) { this.date = date; }
        public void SetDescription(string description) { this.description = description; }
        public void SetAmount(decimal amount) { this.amount = amount; }
        public void SetCategory(Category category) { this.category = category; }

        override
                    public string ToString()
        {
            return $"ID: {id}, UserID: {userId} , Date: {date}, Description: {description}, Amount: {amount}, Category: {category?.GetName()}, Type: {flag}";
        }
    }
}
