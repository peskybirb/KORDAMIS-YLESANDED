namespace FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* For ülesanded*/

        ALGUS:
            Console.Clear();
            Console.WriteLine("menu thing");
            Console.WriteLine("exit.programm sulged");
            Console.WriteLine("1.FOR-1.1 numbrite küsimine");
            Console.WriteLine("2.FOR-1.2 RUUT");

            string valik1 = Console.ReadLine();

            switch (valik1) 
                {

                  // ---  DEFAULT ---
                default:
                    Console.WriteLine("Sellist ülesanne ei eksisteeri, liigun tagasi");
                    Thread.Sleep(2500);
                    goto ALGUS;
                    return;

                  // --- LAHKUMINE ---
                case("exit"):
                    Console.Clear();
                    Console.WriteLine("Progromm sulgeb");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    return;

                // 1. "prindi numbrid"
                // tee muutuja "kuipalju" milles on täisarv 0 
                // kuva kasutajale tekst millega küsid kasutajalt mitu numbrit ta tahab
                // omista käsurealt saadud arv muutujasse "kuipalju"
                // kirjuta for tsükkel, tsükli teise parameetrisse - kontrolli aseta i vastu muutuja "kuipalju"
                // tsükli tegevusena kuva kasutajale välja i, aga liida sellele üks juurde et lugemine algaks arvust 1
                // peale tsüklit kuva kasutajale sõnum "tsükkel lõppes"
                case "1":
                    Console.Clear();

            int kuiPalju = 0;
            Console.WriteLine("Mitu numbrit soovid saada ?");
            kuiPalju = int.Parse(Console.ReadLine());
            for (int i = 0; i < kuiPalju; i++)
            {
                Console.WriteLine(i + 1);

            }
            Console.WriteLine("Tsükkel lõppes.");

                    Thread.Sleep(2000);
                    Console.WriteLine("Vajuta enter et minna tagasi");
                    Console.ReadLine();
                    goto ALGUS;
                    return;

                // 2. "Ruut"
                // tee muutuja "ruudukülg" milles on täisarv 0         
                // kuva kasutajale tekst millega küsid kasutajalt kui suurt ruutu ta tahab
                // omista käsurealt saadud arv muutujasse "ruudukülg"
                // kirjuta for tsükkel, tsükli tingimuse kontrolli pane i kontrollimisse muutuja "ruudukülg"
                // tsükli sisse kirjuta sõne tüüpi muutuja, "seeRida", kuhu omistad tühja sõne.
                // tsükli sees on omakorda teine for tsükkel, ka selle tingimuse kontrolli pane i kontrollimisse muutuja "ruudukülg"'
                // nüüd sisemise tsükli sees, omista muutujale "seeRida" juurde liites sisse väärtus "HH" 
                // kui sisemine tsükkel on lõpetanud, siis kuva kasutajale see rida välja
                // kui ka esimene tsükkel on lõpetanud, siis kuva kasutajale tekst "tsüklid on lõpetanud"
                case "2":
                    Console.Clear();

            int ruuduKülg = 0;
            Console.WriteLine("Kui suur ruutu soovid ?");
            ruuduKülg = int.Parse(Console.ReadLine());
            for (int i = 0; i < ruuduKülg; i++)
            {
                string seeRida = "";

                for (int k = 0; k < ruuduKülg; k++)
                {
                    seeRida += "HH";
                }
                Console.WriteLine(seeRida);
            }
            Console.WriteLine("Tsükklid lõpetasid!");

                    Thread.Sleep(2000);
                    Console.WriteLine("Vajuta enter et minna tagasi");
                    Console.ReadLine();
                    goto ALGUS;
                    return;

        }
        }
    }
}
