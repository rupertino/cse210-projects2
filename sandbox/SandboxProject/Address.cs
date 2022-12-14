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

        public string GetStreet()
        {
            return _street;
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetState()
        {
            return _state;
        }
        public string GetCountry()
        {
            return _country;
        }
        public string GetCountryUsa()
        {
            return _countryUsa;
        }

        public void SetStreet(string newStreet)
        {
            _street = newStreet;
        }
        public void SetCity(string newCity)
        {
            _city = newCity;
        }
        public void SetState(string newState)
        {
            _street = newState;
        }
        public void SetCountry(string newCountry)
        {
            _country = newCountry;
        }

        public bool isUsa() 
        {
            bool isUsa = false;

            if (GetCountry().ToLower() == _countryUsa.ToLower())
                isUsa = true;
            
            return isUsa;
        }

        // Agregar setter y getters y llamar las variables a traves de los getters. Con eso queda completo el requerimiento.

        public void Street(string street) { _street = street; }

        public void City(string city) {  _city = city;  }

        public void State(string state) { _state = state;  }

        public void Country(string country) { _country = country; }

        public string FormatedAddress() 
        {

            string address = $"Street: {_street}," +
                $" City: {_city}, " +
                $"Satate: {_state}, " +
                $"Country: {_country},"; 

            return address;

        }
    }
}