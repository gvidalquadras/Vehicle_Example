using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class WithPlateVehicle : Vehicle
    {
        private string plate;

        public WithPlateVehicle(string typeOfVehicle, string plate) : base(typeOfVehicle)
        { this.plate = plate; }

        public string GetPlate()
        { return this.plate; }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }
    }
}
