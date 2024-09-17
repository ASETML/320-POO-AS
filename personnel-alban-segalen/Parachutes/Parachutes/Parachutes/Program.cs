namespace Parachutes
{
    enum SKYDIVERSTATE { inPlane, inAirWithoutParachute, inAirWithParachute, onGround };
    internal class Program
    {
        static private List<Skydiver> CreateParas(int count)
        {
            List<Skydiver> paras = new List<Skydiver>();

            if (count > 0)
            {
                for (int numP = 0; numP < count; numP++)
                {
                    paras.Add(new Skydiver());
                }
            }
            return paras;
        }

        static void Main(string[] args)
        {
            //Dimension de la console
            //Console.BufferHeight = Config.SCREEN_HEIGHT;
            //Console.BufferWidth = Config.SCREEN_WIDTH;
            //Console.WindowHeight = Config.SCREEN_HEIGHT;
            //Console.WindowWidth = Config.SCREEN_WIDTH;
            
            //Avion
            Plane avion = new Plane(1, 2, CreateParas(5));

            //Game loop
            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    var keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0); 
                            break;                  
                    }
                }
                //Move plane
                avion.Move();

                //Drop paras
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    var keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Spacebar:
                            avion.Drop();
                            break;
                    }
                }
                
                avion.ShowParas();
                Thread.Sleep(200);
            }
            
        }
    }
}