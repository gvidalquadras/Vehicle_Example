namespace Practice1
{
    class PoliceCar : WithPlateVehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling; 
        private bool isChasing;
        private string? plateOffender;
        private SpeedRadar? speedRadar;
        private PoliceStation? policeStation { get; set; }

        public PoliceCar(string plate, SpeedRadar? speedRadar = null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isChasing = false;
            this.speedRadar = speedRadar;
        }

        public void UseRadar(WithPlateVehicle vehicle)
        {
            if (isPatrolling && speedRadar != null)
            {
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                if (meassurement == "Catched above legal speed." )
                {
                    string? plateOffender = vehicle.GetPlate();
                    SendAlarm(plateOffender);
                    Console.WriteLine(WriteMessage("Alarm sent to police Station."));
                    StartChasing(plateOffender);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public bool IsChasing()
        {
            return isChasing;
        }

        private void SendAlarm(string plateOffender)
        {
            if (policeStation != null)
            {
                policeStation.ShareAlarm(plateOffender);
            }

        }

        public void StartChasing(string plate)
        {
            isChasing = true;
            plateOffender = plate;
            Console.WriteLine(WriteMessage($"Started chasing car with plate {plate}."));
        }

        public void StopChasing()
        {
            isChasing = false;
            plateOffender = null;
            Console.WriteLine(WriteMessage($"Stopped the chase."));
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if(speedRadar != null) {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            
        }

        public void SetPoliceStation(PoliceStation policeStation)
        { this.policeStation = policeStation; }

     
}
}