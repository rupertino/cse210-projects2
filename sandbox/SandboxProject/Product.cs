using System;

namespace SandboxProject
{
    public class Product
    {
        private int _productId;
        private string _name;
        private double _price;
        private int _quantityProduct;
        private double _total;

        // hay que agregar los getter y setters y utilizar los getters para llamar las variables.
        public void productId(int productId) { _productId = productId; }
        public void name(string name) { _name = name; }
        public void price(double price) { _price = price; }
        public void quantityProduct(int quantityProduct) { _quantityProduct = quantityProduct; }

        // Method to compute the price multiplied for the quantity of products.
        public string  detailProduct() 
        {
            string data = _productId.ToString() + "," + _name + "," + _price + "," + _quantityProduct + "," + _total;
            return data;
        }

        public void PriceCount()
        {
            _total = _price * _quantityProduct;             
        }
        
    }    
}