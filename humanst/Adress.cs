using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Adress
    {
        private string _country;
        private string _city;
        private string _street;
        private int _house;

        public Adress()
        {
            this._country = "Ukraine";
            this._city = "Kherson";
            this._street = "1 Slobodka";
            this._house = 2;
        }

        public Adress(string country, string city, string street, int house)
        {
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
        }

        public string toString()
        {
            return
                "Country: " + this._country + "\n" +
                "City: " + this._city + "\n" +
                "Street: " + this._street + "\n" +
                "House: " + this._house.ToString();
        }
        public Adress inputadress()
        {
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Street: ");
            string street = Console.ReadLine();
            Console.WriteLine("House: ");
            int house = int.Parse(Console.ReadLine());
            Adress adress = new Adress(country, city, street, house);
            return adress;
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
    }
    
}