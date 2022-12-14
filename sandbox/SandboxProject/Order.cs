using System;
using System.Collections.Generic;

namespace SandboxProject
{
    public  class Order
    {
        
        // Contain a list of products and a customer.
        
        // Method to return a string for the packing label. Shoud contain name, product id of each product in the order.
        // Method to return a string for the shipping label. Shoul contain name and address of the customer.
        public List<string> _productsOfCustomer; 
        public Product _product;
        public Customer _customer;

        public Order()
        {      
            _product = new Product();
            _customer = new Customer();
        } 
        
        // 1.Method to calculate the total cost of the order. The total price is
        // 2.calculate as the sum of the prices of each product + one time shipping cost.
        // 3. If the customer is in usa shipping is $5 otherwise is $35.
        public void GetOrderTotal(string nombre, bool isUsa, List<string> products, string address)
        {
            int usa = 5;
            int international = 35;

            double pricetotal = 0;

            string send = $"Address: {address}***** Name: {nombre} ";

            foreach (string product in products)
            {
                double price = 0;
                string[] array = product.Split(",");

                string package = $"Id: {array[0]} Name Product: {array[1]}";
                Console.WriteLine("Product ***************" + package);
                price = Convert.ToDouble(array[2]);
                pricetotal = pricetotal + price;

            }
            if (isUsa)
                pricetotal = usa + pricetotal;            
            else
                pricetotal = international + pricetotal;


            Console.WriteLine("Send to ***************" + send);
            Console.WriteLine("Total ***************" + "$"+pricetotal);
            Console.WriteLine("");

        }
    }
}
