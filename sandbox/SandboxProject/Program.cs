using System;
using System.Collections;
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            Order order = new Order();
            Product product = new Product();
            product.productId(1);
            product.name("Shoes");
            product.price(20);
            product.quantityProduct(2);
            product.PriceCount();
            string result = product.detailProduct();
            products.Add(result);

            product = new Product();
            product.productId(2);
            product.name("Jacket");
            product.price(50.10);
            product.quantityProduct(5);
            product.PriceCount();
            result = product.detailProduct();
            products.Add(result);

            Customer customer = new Customer();
            customer.SetName("Pedro");
            customer._address.SetStreet("Tarata ST 401");
            customer._address.SetState("California");
            customer._address.SetState("San diego");
            customer._address.SetCountry("Usa");
            bool isUsa = customer.isUsa();
            string name = customer.NameReturn();
            string address = customer.FormatedAddress();

            order.GetOrderTotal(name, isUsa, products, address);

            products = new List<string>();
            order = new Order();
            product = new Product();
            product.productId(3);
            product.name("Watch");
            product.price(20);
            product.quantityProduct(2);
            product.PriceCount();
            result = product.detailProduct();
            products.Add(result);

            product = new Product();
            product.productId(4);
            product.name("Racket");
            product.price(50.10);
            product.quantityProduct(5);
            product.PriceCount();
            result = product.detailProduct();
            products.Add(result);

            customer = new Customer();
            customer.SetName("Juan");
            customer._address.SetStreet("Ocotlan 16");
            customer._address.SetState("BC");
            customer._address.SetCity("Tijuana");
            customer._address.SetCountry("Mexico");
            isUsa = customer.isUsa();
            name = customer.NameReturn();
            address = customer.FormatedAddress();

            order.GetOrderTotal(name, isUsa, products, address);

        }
    }
}