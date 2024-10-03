using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    abstract class NoPlateVehicle: Vehicle
    {
        public NoPlateVehicle(string typeOfVehicle): base(typeOfVehicle) { }

        public override string ToString() {
            return $"{GetTypeOfVehicle()}";

        }
    }
}
