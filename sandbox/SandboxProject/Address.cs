using System;


namespace SandboxProject
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        private string _countryUsa = "usa";

        public bool isUsa() 
        {
            bool isUsa = false;

            if (_country.ToLower() == _countryUsa.ToLower())
                isUsa = true;
            
            return isUsa;
        }

        public void Street(string street) { _street = street; }

        public void City(string city) {  _city = city;  }

        public void State(string state) { _state = state;  }

        public void Country(string country) { _country = country; }

        public string FormaterAddress() 
        {

            string address = $"Street: {_street}" +
                $" City: {_city} " +
                $"Satate: {_state} " +
                $"Counry: {_country}"; 

            return address;

        }
    }
}