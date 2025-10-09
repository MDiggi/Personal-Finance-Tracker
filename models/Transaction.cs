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
        private DateTime? date;
        private string? description;
        private decimal? amount;
        private Category? category;
        private TransactionType? flag;


        //Constructors
        // Parameterized constructor
        public Transaction(uint id, DateTime date, string description, decimal amount, Category category, TransactionType flag)
        {
            this.id =               id;
            this.date =             date;
            this.description =      description;
            this.amount =           amount;
            this.category =         category;
            this.flag =             flag;
        }

        // Default constructor
        public Transaction()
        {
            this.id =                0;
            this.date =              DateTime.MinValue;
            this.description =       string.Empty;
            this.amount =            0;
            this.category =          new Category();
            this.flag =              TransactionType.None;
        }

        // Getters
        public uint GetId()            { return (uint)id; }
        public DateTime GetDate()      { return date; }
        public string GetDescription() { return description; }
        public decimal GetAmount()     { return amount; }
        public Category GetCategory()  { return category; }

        // Setters
        public void SetId(uint id)                        { this.id = id; }
        public void SetDate(DateTime date)                { this.date = date; }
        public void SetDescription(string description)    { this.description = description; }
        public void SetAmount(decimal amount)             { this.amount = amount; }
        public void SetCategory(Category category)        { this.category = category; }
    }
}
