namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.SetX(100);
            drone.SetY(100);
            drone.SetName("Joe");
            fleet.Add(drone);
            try
            {
                if (fleet.Count > 10)
                {
                    throw new DroneLimitExceededException("Too Many Drones");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            List<Building> buildings = new List<Building>();
            Building b1 = new Building(60, 50, 25, 25, Color.DeepPink);
            Building b2 = new Building(70, 60, 35, 25, Color.Honeydew);
            buildings.Add(b1);
            buildings.Add(b2);


            // Démarrage
            try
            {
                Application.Run(new AirSpace(/*fleet, buildings*/));
            }

            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}