using System.IO;

namespace SandboxProject
{
    public class Customer
    {      
        private string _name;
        public Address _address;

        public Customer()
        {
            _address = new Address();
        }

        // hace falta agregarle los getters y seter a name
        // Hace falta agregar un metodo que use el metodo de Address para saber si vive en Usa o no.

        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string newName)
        {
            _name = newName;
        }
    
        
        public string FormatedAddress() => _address.FormatedAddress();

        public string NameReturn() => _name;

        // Method to validate if is customer country is Usa. Calling the method from Adress Calss.
        public bool isUsa() => _address.isUsa();
        
    }
}