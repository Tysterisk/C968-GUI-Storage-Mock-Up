using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968SwadeMockUp
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse() { }

        public Inhouse(int partID, string name, decimal price, int inStock, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price; 
            Max = max; 
            Min = min;
        }
        public Inhouse(int partID, string name, decimal price, int inStock, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }

        // Override class to return subclass type when called
        public override string[] CheckPartType() 
        {
            string[] returns = { this.MachineID.ToString(), "Inhouse" };
            return returns; 
        }
    }
}
