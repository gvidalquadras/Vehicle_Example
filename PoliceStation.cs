using System;
using System.Runtime.ConstrainedExecution;

namespace Practice1
{

    class PoliceStation: IMessageWritter
    {
        public List<PoliceCar> PoliceCarRegister { get; private set; }
        private string alarmPlate;
        private City city;
        private string StationID { get; }
        public PoliceStation( City city, string stationID)
        {
            PoliceCarRegister = new List<PoliceCar>();
            alarmPlate = "";
            this.city = city;
            StationID = stationID;
        }

        public void ShareAlarm(string plateOffender)
        {
            foreach (var car in PoliceCarRegister)
            {
                if (car.IsPatrolling())
                {
                    car.StartChasing(plateOffender);
                }
            }
            Console.WriteLine(WriteMessage($"Alarm sent regarding offender with plate {plateOffender}."));
        }

        public void AddPoliceCar(PoliceCar policeCar)
        {
            if (!PoliceCarRegister.Contains(policeCar))
            {
                PoliceCarRegister.Add(policeCar);
                policeCar.SetPoliceStation(this);
            };
            Console.WriteLine(WriteMessage($"{policeCar} has joined the station."));

        }

        public void RemovePoliceCar(PoliceCar policeCar)
        {
            if (PoliceCarRegister.Contains(policeCar))
            {
                PoliceCarRegister.Remove(policeCar);

            };
            Console.WriteLine(WriteMessage($"{policeCar} has been removed from the station."));
        }

        public override string ToString()
        {
            return $"Police Station {StationID}";
        }
        //Implement interface with PoliceStation message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

    }
}

