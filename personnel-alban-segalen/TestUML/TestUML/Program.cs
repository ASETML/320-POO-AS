namespace TestUML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger1 = new Passenger("Paul");
            Passenger passenger2 = new Passenger("Jean");

            Car car = new Car(5, ConsoleColor.White, "Fabia");
            car.PickPassenger(passenger1);
            car.PickPassenger(passenger2);
            car.Start();

            car.Stop();
            car.DropPassenger(passenger1);
            car.Start();
        }
    }
}