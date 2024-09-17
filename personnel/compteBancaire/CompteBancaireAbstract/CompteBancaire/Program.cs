namespace CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CompteBancaire c2 = new CompteCourant(1, 1234, "Alban", "CHF");
            CompteBancaire c3 = new CompteEpargne(0.02, 1234, "Alban", "CHF");
        }
    }
}