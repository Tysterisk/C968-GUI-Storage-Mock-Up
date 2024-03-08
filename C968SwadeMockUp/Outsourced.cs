using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968SwadeMockUp
{
    internal class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced() { }

        public Outsourced(int partID, string name, decimal price, int inStock, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }
        public Outsourced(int partID, string name, decimal price, int inStock, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }

        // Override class to return subclass type when called
        public override string[] CheckPartType() 
        {
            string[] returns = { this.CompanyName, "Outsourced" };
            return returns;
        }
    }
}
