using Drones.Model;
namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        private int _charge = 1000;                     // La charge actuelle de la batterie
        public string _name;                           // Un nom
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private EvacuationState _state;
        private Rectangle _bounds;


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie
        }

        public void SetX(int newX)
        {
            _x = newX;
        }

        public void SetY(int newY)
        {
            _y = newY;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public bool Evacuate(Rectangle area)
        {
            if (_bounds.IntersectsWith(area)) 
            {
                _state = EvacuationState.Evacuating;
            }

            if (_state == EvacuationState.Evacuated)
            {
                return true;
            }
            else
            {
                return false;
            }

            //Si il est plus pres des bords horizontaux, on le deplace sur l'axe X, sinon on le deplace sur l'axe Y
            switch (FindClosestEdge(this, area))
            {
                case "left":
                    this._x -= 1;
                case "right":
                    this._x += 1;
                case "top":
                    this._y -= 1;
                case "bottom":
                    this._y += 1;
            }
        }

        private string FindClosestEdge(Drone drone, Rectangle area)
        {
            int areaCenterWidth = area.Width / 2;
            int areaCenterHeight = area.Height / 2;

            if (drone._x < area.Left + areaCenterWidth) //moitie gauche
            {
                return "left";
            }

            else if (drone._x > area.Left + areaCenterWidth) //moitie droite
            {
                return "right";
            }

            if (drone._y < area.Bottom + areaCenterHeight) //moitie superieure
            {
                return "top";
            }

            else if (drone._y > area.Left + areaCenterHeight) //moitie inferieure
            { 
                return "bottom"; 
            }

            return "undefined";
        }

        public void FreeFlight()
        {
            _state = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            return _state;
        }
    }
}
