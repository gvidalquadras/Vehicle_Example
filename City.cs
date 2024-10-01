using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class City
    {
        private PoliceStation PoliceStation { get; set; }
        private List<Taxi> TaxiLicences;


        public City (PoliceStation policeStation)
        {
            PoliceStation = policeStation;
            TaxiLicences = new List<Taxi>();

        }

        public void GrantTaxiLicence(Taxi taxi)
        {
            TaxiLicences.Add(taxi);

        }

        public void RemoveTaxiLicence(Taxi taxi)
        {
            TaxiLicences.Remove(taxi);

        }

    }
}
