using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class CartManager
    {
        //naming convention
        public void Add(Products products) 
        {
            Console.WriteLine(products.NAME+" added to the cart");
            //we need to send a parameter to this method
        }
        public void Add2(string ProductName, string About, double Price)
        {

            Console.WriteLine(ProductName + " added to the cart" +" with price of "+Price+ "£" );
        }
    }
}
