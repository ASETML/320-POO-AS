using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUML
{
    public class Car
    {
        public int speed;
        private ConsoleColor _color;
        private string _model;
        private List<Passenger> _passengerList = new List<Passenger>();

        public Car(int speed, ConsoleColor color, string model)
        {
            this.speed = speed;
            _color = color;
            _model = model;
        }

        public void Start()
        {
            Console.WriteLine("Car starting");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopping");
        }

        public void PickPassenger(Passenger passenger)
        {
            _passengerList.Add(passenger);
        }

        public void DropPassenger(Passenger passenger)
        {
            _passengerList.Remove(passenger);
        }
    }
}
