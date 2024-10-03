using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class City: IMessageWritter
    {
        private PoliceStation PoliceStation { get; set; }
        private List<Taxi> TaxiLicences;
        private string CityName { get; set; }


        public City (PoliceStation policeStation, string cityName)
        {
            PoliceStation = policeStation;
            TaxiLicences = new List<Taxi>();
            CityName = cityName;

        }

        public void GrantTaxiLicence(Taxi taxi)
        {
            TaxiLicences.Add(taxi);
            Console.WriteLine(WriteMessage($"{taxi} was granted a Taxi Licence."));
        }

        public void RemoveTaxiLicence(Taxi taxi)
        {
            TaxiLicences.Remove(taxi);
            Console.WriteLine(WriteMessage($"{taxi} had their Taxi Licence revoked."));

        }

        public override string ToString()
        {
            return $"City {CityName}";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

    }
}
