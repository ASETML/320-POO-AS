namespace CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CompteBancaire c1 = new CompteBancaire(1234, "Alban", "CHF");
            CompteCourant c2 = new CompteCourant(1, 1234, "Alban", "CHF");
            CompteEpargne c3 = new CompteEpargne(0.02, 1234, "Alban", "CHF");
        }
    }
}