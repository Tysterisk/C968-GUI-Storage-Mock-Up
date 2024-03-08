using System.ComponentModel;

namespace C968SwadeMockUp
{
    internal static class Program
    {
        [STAThread]

        // Make generic testing parts/products/associations
        public static void PopulateLists()
        {
            Part firstPart = new Outsourced(1, "1060 Super", 200.00m, 200, 2000, 20, "Nvidia");
            Part secondPart = new Outsourced(2, "4090 TI", 1200.00m, 860, 1000, 100, "Nvidia");
            Part thirdPart = new Outsourced(3, "2080 TI", 8.00m, 512, 860, 100, "Nvidia");
            Part fourthPart = new Outsourced(4, "Radeon 7800", 999.99m, 286, 400, 40, "AMD");
            Part fifthPart = new Inhouse(5, "Arc Bastion 860", 600.50m, 485, 800, 50, 32935);
            Part sixthPart = new Inhouse(6, "Infinicase", 480.99m, 485, 500, 50, 40458);
            Part seventhPart = new Inhouse(7, "Shingled Hub", 299.99m, 485, 800, 80, 39574);
            Part eigthPart = new Inhouse(8, "200mm Cooler", 300.49m, 485, 800, 100, 20093);

            Inventory.addPart(firstPart);
            Inventory.addPart(secondPart);
            Inventory.addPart(thirdPart);
            Inventory.addPart(fourthPart);
            Inventory.addPart(fifthPart);
            Inventory.addPart(sixthPart);
            Inventory.addPart(seventhPart);
            Inventory.addPart(eigthPart);

            Product firstProd = new Product(1, "Low End PC", 300, 50, 10, 100);
            Product secondProd = new Product(2, "Mid Range PC", 800, 150, 30, 300);
            Product thirdProd = new Product(3, "High End PC", 2000, 15, 5, 50);
            Product fourthProd = new Product(4, "Budget", 500, 54, 5, 300);

            Inventory.addProduct(firstProd);
            Inventory.addProduct(secondProd);
            Inventory.addProduct(thirdProd);
            Inventory.addProduct(fourthProd);

            firstProd.addAssociatedPart(firstPart);
            firstProd.addAssociatedPart(seventhPart);
            secondProd.addAssociatedPart(fifthPart);
            secondProd.addAssociatedPart(firstPart);
            secondProd.addAssociatedPart(eigthPart);
            thirdProd.addAssociatedPart(fifthPart);
            thirdProd.addAssociatedPart(secondPart);
            thirdProd.addAssociatedPart(sixthPart);
            thirdProd.addAssociatedPart(eigthPart);
            thirdProd.addAssociatedPart(seventhPart);
            fourthProd.addAssociatedPart(sixthPart);
        }

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            PopulateLists();
            Application.Run(new Form1());

        }
    }
}