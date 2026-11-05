using System.Threading.Channels;

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
        static char Bekeres()
        {
            Console.Write("Kérem adjon meg egy betűt! ");
            char betu = Console.ReadLine()[0];
            return betu;
        }
        static void Main(string[] args)
        {
            string kitalalando = Kivalasztas();
            Console.WriteLine(kitalalando);
            string talalatok = new string('_', kitalalando.Length);
            Console.WriteLine(talalatok);
            while (kitalalando != talalatok)
            {
                char tipp = Bekeres();
                if (kitalalando.Contains(tipp))
                {
                    string seged = "";
                    int index = 0;
                    foreach (char item_betu in talalatok)
                    {
                        if (tipp == kitalalando[index++])
                        {
                            seged += tipp;
                        }
                        else
                        {
                            seged += item_betu;
                        }
                    }
                    talalatok = seged;
                    Console.WriteLine(seged);
                }
            }

        }
    }
}
