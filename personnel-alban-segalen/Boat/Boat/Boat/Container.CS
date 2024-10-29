using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Container : IContainer
    {
        // Propriétés du container
        public int Id { get; }
        public float Weight { get; }
        public bool IsRefrigerated { get; }
        public List<string> Merchandise { get; }
        public string Color { get; }

        public Container(int id, float weight, bool isRefrigerated, string color)
        {
            Id = id;
            Weight = weight;
            IsRefrigerated = isRefrigerated;
            Color = color;
        }

        // Méthodes pour le container
        public void ViewContent()
        {
            foreach (var item in Merchandise)
            {
                Console.WriteLine("Item list of container " + this.Id);
                Console.WriteLine(item);
            }
        }  // Voir le contenu du container
        public void AddMerchandise(string item)
        {
            Merchandise.Add(item);
        }  // Ajouter un élément dans le container
    }

    public class SensitiveContainer :Container
    {
        public SensitiveContainer(int id, float weight, bool isRefrigerated, string color) : base(id, weight, isRefrigerated, color) { }
    }
    public class RefrigeratedContainer : Container
    {
        public RefrigeratedContainer(int id, float weight, string color) : base(id, weight, true, color) 
        {

        }
    }

    public class TankContainer : Container
    {
        public TankContainer(int id, float weight, string color) : base(id, weight, true, color) 
        {

        }
    }

}