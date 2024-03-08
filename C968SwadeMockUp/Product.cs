using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968SwadeMockUp
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            bool removed = false;
            foreach (Part part in AssociatedParts.ToList())
            {
                if (partID == part.PartID)
                {
                    AssociatedParts.Remove(part);
                    removed = true;
                }
            }
            return removed;
        }

        public Part lookupAssociatedPart(int partID)
        {
            Part searchPart = null;
            foreach (Part partObj in AssociatedParts.ToList())
            {
                if (partID == partObj.PartID)
                {
                    searchPart = partObj;
                }
            }
            return searchPart;
        }
    }
}
