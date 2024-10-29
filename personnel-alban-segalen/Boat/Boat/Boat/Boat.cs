using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Boat : IBoat
    {
        // Propriétés du bateau
        public string Name { get; }
        public float MaxCargoWeight { get; }
        public int MaxSpeed { get; }

        private List<IContainer> _containers = new List<IContainer>();

        public Boat(string name, float maxCargoWeight, int maxSpeed)
        {
            Name = name;
            MaxCargoWeight = maxCargoWeight;
            MaxSpeed = maxSpeed;
        }

        // Méthodes pour le bateau
        public void Start()
        {

        }  // Démarrer le bateau
        public bool LoadContainer(IContainer container)
        {
            float currentWeight = 0;
            foreach (IContainer currentContainer in _containers)
            {
                currentWeight += currentContainer.Weight;
            }

            if (currentWeight + container.Weight <= MaxCargoWeight)
            {
                _containers.Add(container);
                return true;
            }
            else { return false; }
            
        }  // Charger un container
        public bool UnloadContainer(IContainer container)
        {
            if (_containers.Contains(container))
            {
                _containers.Remove(container);
                return true ;
            }
            else { return false; }
        }  // Décharger un container
    }
}