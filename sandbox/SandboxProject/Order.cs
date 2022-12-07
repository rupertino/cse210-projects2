using System;
using System.Collections.Generic;

namespace SandboxProject
{
    public  class Order
    {
        public Product _products;
        public Customer _customer;

        public Order()
        {      
            _products = new Product();
            _customer = new Customer();
        } 
        
        public void CoutnOrder(string nombre, bool isUsa, List<string> products, string address)
        {
            int usa = 5;
            int international = 35;

            double pricetotal = 0;

            string send = $"Direccion: {address}***** Name:{nombre} ";

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


            Console.WriteLine("Send ***************" + send);
            Console.WriteLine("total ***************" + pricetotal);



        }
    }
}
