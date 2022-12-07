using System.IO;

namespace SandboxProject
{
    public  class Customer
    {      
        private string _name;
        public Address _address;

        public Customer()
        {
            _address = new Address();
        }

        public void Name(string name) { _name = name; }

        public void Street(string street) { _address.Street(street); }

        public void City(string city) { _address.City(city); }

        public void State(string state) { _address.State(state);  }

        public void Country(string country) { _address.Country(country);}

        public string FormaterAddress() => _address.FormaterAddress();

        public string NameReturn() => _name;

        public bool isUsa() => _address.isUsa();
        
    }
}