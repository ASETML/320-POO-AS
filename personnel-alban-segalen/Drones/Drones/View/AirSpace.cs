using Drones.Model;
namespace Drones
{
    // La classe AirSpace repr�sente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fen�tre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        public static readonly int WIDTH = 1200;        // Dimensions of the airspace
        public static readonly int HEIGHT = 600;

        // La flotte est l'ensemble des drones qui �voluent dans notre espace a�rien
        private List<Drone> fleet;
        private List<Building> buildings;
        

        BufferedGraphicsContext currentContext;
        public BufferedGraphics airspace;

        // Initialisation de l'espace a�rien avec un certain nombre de drones
        public AirSpace(/*List<Drone> fleet, List<Building> buildings*/)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            try
            {
            }

            catch (Exception ex)
            {
                throw new DroneLimitExceededException("too many");
            }

            this.buildings = buildings;

            Dispatch dispatcher = new Dispatch();
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);
            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
                airspace.Render();
            }
            //Draw buildings
            foreach (Building building in buildings)
            {
                building.Render(airspace);
                airspace.Render();
            }
        }
            // Calcul du nouvel �tat apr�s que 'interval' millisecondes se sont �coul�es
            private void Update(int interval)
            {
                foreach (Drone drone in fleet)
                {
                    drone.Update(interval);
                }

                foreach (Building building in buildings)
                {
                    if (building.GetType() == typeof(Factory))
                    {
                        Box box = new Box("brun");
                    }
                }
            }

            // M�thode appel�e � chaque frame
            private void NewFrame(object sender, EventArgs e)
            {
                this.Update(ticker.Interval);
                this.Render();
            }
        }
    }