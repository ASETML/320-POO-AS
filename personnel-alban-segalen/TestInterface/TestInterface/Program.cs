namespace TestInterface
{
    interface Iplane
    {
        void Taxi();
        void TakeOff();
        void Fly();
        void Land();
    }

    public class Plane
    {
        public void Taxi()
        {
            Console.WriteLine("");
        }

        public void TakeOff()
        {
            
        }

        public void Fly()
        {

        }

        public void Land()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Plane plane = new Plane();
            plane.Taxi();
        }
    }
}