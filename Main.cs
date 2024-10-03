namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", speedRadar);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            City city = new City("Madrid");
            PoliceStation station = new PoliceStation("001", city);
            

            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine(city.WriteMessage("Created"));
            Console.WriteLine(station.WriteMessage("Created"));

            station.AddPoliceCar(policeCar1);
            station.AddPoliceCar(policeCar2);

            city.GrantTaxiLicence(taxi1);
            city.GrantTaxiLicence(taxi2);

            taxi1.StartRide();
            taxi2.StartRide();

            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi1);
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi2);


        }
    }
}
    

