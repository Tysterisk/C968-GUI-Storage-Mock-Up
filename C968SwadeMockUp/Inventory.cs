using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968SwadeMockUp
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int prodID) 
        {
            bool removed = false;
            foreach (Product prod in Products.ToList())
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    removed = true;
                }
            }
            return removed;
        }

        public static Product lookupProduct(int prodID)
        {
            Product searchProd = null;
            foreach (Product prodObj in Products.ToList())
            {
                if (prodID == prodObj.ProductID)
                {
                    searchProd = prodObj;
                }
            }
            return searchProd;
        }

        public static void updateProduct (int prodID, Product product) 
        {
            foreach (Product prodObj in Products.ToList())
            {
                if (prodID == prodObj.ProductID)
                {
                    Products.Remove (prodObj);
                    Products.Add (product);
                }
            }
        }

        public static void addPart (Part part) 
        { 
            AllParts.Add(part);
        }

        public static bool removePart(int partID)
        {
            bool removed = false;
            foreach (Part part in AllParts.ToList())
            {
                if (partID == part.PartID)
                {
                    AllParts.Remove(part);
                    removed = true;
                }
            }
            return removed;
        }

        public static Part lookupPart(int partID)
        {
            Part searchPart = null;
            foreach (Part partObj in AllParts.ToList())
            {
                if (partID == partObj.PartID)
                {
                    searchPart = partObj;
                }
            }
            return searchPart;
        }

        // Updates part on call.  Also updates Associated Parts to contain the updated values.
        public static void updatePart(int partID, Part part)
        {
            foreach (Part partObj in AllParts.ToList())
            {
                if (partID == partObj.PartID)
                {
                    foreach (Product prod in Inventory.Products)
                    {
                        if (prod.AssociatedParts.Contains(partObj)) 
                        {
                            prod.removeAssociatedPart(partID);
                            prod.addAssociatedPart(part);
                        }
                    }
                    AllParts.Remove(partObj);
                    AllParts.Add(part);
                }
            }
        }

        // Get the next available Part ID to fill from bottom-up on auto-generated IDs
        public static int getNextPartID()
        {
            int[] usedIDs = new int[AllParts.Count];
            for (int i = 0; i < AllParts.Count; i++)
            {
                usedIDs[i] = AllParts[i].PartID;
            }
            try { 
                var results = Enumerable.Range(1, usedIDs.Max()).Except(usedIDs);
                if (results.Any())
                {
                    return results.First();
                }
                else { return usedIDs.Max() + 1; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 1; }
        }

        // Get the next available Product ID to fill from bottom-up on auto-generated IDs
        public static int getNextProductID()
        {
            int[] usedIDs = new int[Products.Count];
            for (int i = 0; i < Products.Count; i++)
            {
                usedIDs[i] = Products[i].ProductID;
            }
            try
            {
                var results = Enumerable.Range(1, usedIDs.Max()).Except(usedIDs);
                if (results.Any())
                {
                    return results.First();
                }
                else { return usedIDs.Max() + 1; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 1; }
        }
    }

}
