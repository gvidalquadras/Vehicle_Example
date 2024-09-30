using System;

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

        private void ShareAlarm()
        {

        }

        private void AddPoliceCar(PoliceCar policeCar)
        {
            PoliceCarRegister.Add(policeCar);

        }

        private void RemovePoliceCar(PoliceCar policeCar)
        {
            PoliceCarRegister.Remove(policeCar);

        }

    }
}

