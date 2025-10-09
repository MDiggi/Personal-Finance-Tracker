using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.models
{
    internal class Category
    {
        private uint? id;
        private string name;
        private string  description;


        //Constructors

        // Parameterized constructor
        public Category(uint id, string name, string description)
        {
            this.id =                 id;
            this.name =               name;
            this.description =        description;
        }

        // Default constructor
        public Category()
        {
            this.id =                        0;
            this.name =                      "Categoria Nova";
            this.description =               string.Empty;
        }


        // Getters
        public uint GetId()                                  { return (uint)id; }
        public string GetName()                              { return name; }
        public string GetDescription()                       { return description; }
        
        // Setters
        public void SetId(uint id)                           { this.id = id; }
        public void SetName(string name)                     { this.name = name; }
        public void SetDescription(string description)       { this.description = description; }
    }

}
