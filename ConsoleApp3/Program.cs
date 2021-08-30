using System;
//Methodlar
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Products products1 = new Products();
            products1.ID = 984151;
            products1.NAME = "Banana";
            products1.ABOUT = "Fine Quality Ecuador Bananas";
            products1.PRICE = 1.49;
            
            Products products2 = new Products();
            products2.ID = 841125;
            products2.NAME = "Orange";
            products2.ABOUT = "Fenike Orange Imported From Antalya/Turkey";
            products2.PRICE = 1.19;

            Products[] Fruits = new Products[] {products1 , products2};

            foreach (Products products in Fruits)
            {
                Console.WriteLine("Product ID = " + products.ID);
                Console.WriteLine("Product NAME = " + products.NAME);
                Console.WriteLine("Product DEFINITION = " + products.ABOUT);
                Console.WriteLine("Product PRICE = " + products.PRICE);
                Console.WriteLine("------------------------");
            }

                //instance-örnek verimi
                Console.WriteLine("---------Methods---------");
                CartManager cartManager = new CartManager();
                cartManager.Add(products2);
                cartManager.Add(products1);

            //gives us reuseability

            cartManager.Add2("Apple","Amsaya",0.99);
            cartManager.Add2("Appleee","Amsayaaaaa", 0.99);
            cartManager.Add2("Appleeeee","Amsayaaaaaa", 0.99);




        }
    }
}
