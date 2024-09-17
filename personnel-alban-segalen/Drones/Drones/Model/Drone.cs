namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        Random alea = new Random();

        private int _charge = 1000;                     // La charge actuelle de la batterie
        public string _name;                           // Un nom
        private int _x ;                                // Position en X depuis la gauche de l'espace aérien
        public int _y;                                 // Position en Y depuis le haut de l'espace aérien


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

    }
}
