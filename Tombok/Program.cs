using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Tombok
{
    internal class Program
    {
        static string[] szavak = { "akasztófa", "ruhásszekrény", "mosógép", "egérpad", "monitor", "kulcs",
        "asztal", "szék", "lámpa", "ablak", "ajtó", "függöny",
        "szőnyeg", "kanapé", "párna", "takaró", "könyvespolc", "fiók",
        "hűtőszekrény", "mikrohullámú", "porszívó", "vasaló", "kenyérpirító",
        "kávéfőző", "televízió", "billentyűzet", "egér", "laptop", "telefon",
        "töltő", "hangszóró", "fejhallgató", "nyomtató", "router",
        "ceruza", "toll", "radír", "füzet", "könyv", "táska",
        "hátizsák", "pénztárca", "szemüveg", "óra", "naptár",
        "autó", "kerékpár", "motorkerékpár", "repülőgép", "helikopter",
        "vonat", "villamos", "autóbusz", "hajó", "roller",
        "kutya", "macska", "elefánt", "zsiráf", "oroszlán",
        "tigris", "medve", "farkas", "róka", "nyúl",
        "mókus", "sün", "teknős", "krokodil", "pingvin",
        "alma", "körte", "banán", "narancs", "eper",
        "görögdinnye", "szőlő", "barack", "cseresznye", "ananász",
        "burgonya", "paradicsom", "uborka", "paprika", "sárgarépa",
        "karfiol", "brokkoli", "hagyma", "fokhagyma", "káposzta",
        "iskola", "kórház", "könyvtár", "étterem", "mozi",
        "játszótér", "repülőtér", "vasútállomás", "bevásárlóközpont", "uszoda" };
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
            //Console.WriteLine(kitalalando);
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
                    Console.WriteLine(talalatok);
                }
                else
                {
                    Console.WriteLine("Nincs benne a szóban");
                }
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Gratulálok!");
            Console.BackgroundColor = ConsoleColor.Black;


        }
    }
}
