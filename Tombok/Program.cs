namespace Tombok
{
    internal class Program
    {
        static string[] szavak = { "akasztófa", "ruhásszekrény", "mosógép", "egérpad", "monitor", "kulcs" };
        static Random random = new Random();
        static string Kivalasztas()
        {
            int index = random.Next(0, szavak.Length);
            return szavak[index];
        }
        static void Main(string[] args)
        {
            string kitalalando = Kivalasztas();
            Console.WriteLine(kitalalando);
        }
    }
}
