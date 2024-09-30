using System;
using System.Runtime.ConstrainedExecution;

namespace Practice1
{

    class PoliceStation
    {
        public List<PoliceCar> PoliceCarRegister { get; private set; }
        private string alarmPlate;
        public PoliceStation()
        {
            PoliceCarRegister = new List<PoliceCar>();
            alarmPlate = "";
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
        }

        public void AddPoliceCar(PoliceCar policeCar)
        {
            if (!PoliceCarRegister.Contains(policeCar))
            {
                PoliceCarRegister.Add(policeCar);
            };

        }

        public void RemovePoliceCar(PoliceCar policeCar)
        {
            if (PoliceCarRegister.Contains(policeCar))
            {
                PoliceCarRegister.Remove(policeCar);
            };
        }

        
    }
}

