using System.Runtime.Serialization;

namespace MATHINPUT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        põhimenüü:
            Console.Clear();
            Console.WriteLine("EZ access menu:");
            Console.WriteLine("1.sünniaasta programm");
            Console.WriteLine("2.Tervitus sulle");
            Console.WriteLine("3.Kommide jagamise programm");
            Console.WriteLine("4.õunasaagi programm");
            Console.WriteLine("5.Pere keskmine pikkus");
            Console.WriteLine("6.Mänguajaprogramm");
            Console.WriteLine("7.sulge programm");
            string Choice = Console.ReadLine();

            switch (Choice) {


                //1. kirjuta programm, mis
                //omab täisarvu muutujat vanuse jaoks
                //küsib kasutajalt tema vanust. int.Parse() üritab muuta andmeid tekstist arvuks
                //omab täisarvu muutujat aastaarvu jaoks
                //küsib kasutajalt praegust kalendriaastat. int.Parse() üritab muuta andmeid tekstist arvuks
                //omab muutujat sünniaasta jaoks, siia sisse omimstatakse tehte tulemus, kus aastaarvust lahutatakse vanus

                //          ÜLESANNE 1    -----------------------------

                case ("1"):

            Console.Clear();
            int Vanus = 0;
            Console.WriteLine("Tere,Mis on teie vanus?");
            Vanus = int.Parse(Console.ReadLine());
            int Kalendriaasta = 0;
            Console.WriteLine("Mis on hetkel praegune kalendriaasta (täisarv)");
            int synniaasta = 0;
            Kalendriaasta = int.Parse(Console.ReadLine());
            synniaasta = Kalendriaasta - Vanus; ;
            Console.WriteLine($"Te olete {synniaasta} aastal sündinud !!!");

                    Thread.Sleep(3000);
                    Console.WriteLine("Vajauta enter et minna tagasi avalehele");
                    Console.ReadLine();
                    goto põhimenüü;

                    break;


            //2. kirjuta programm, mis
            //küsib kasutajalt tema nime
            //hoiab seda nime sõne-tüüpi muutujas
            //kuvab välja tervituse, liites juurde inimese nime

            //         ÜLESANNE 2         ----------------------------------
            case ("2"):

            Console.Clear();
            Console.WriteLine("Tere , mis on teie nimi?");
            string Nimi1 = "";
            Nimi1 = Console.ReadLine();
            Console.WriteLine($"Tere, {Nimi1}");

                    Thread.Sleep(3000);
                    Console.WriteLine("Vajauta enter et minna tagasi avalehele");
                    Console.ReadLine();
                    goto põhimenüü;

                    break;






                //3. kirjuta programm, mis
                //omab muutujat kommikaal
                //omab muutujat sõpradearv
                //küsib kasutajalt mitu grammi kommi tal on
                //muutujasse kommikaal pannakse kasutaja sisestatud arv
                //küsib kasutajalt mitme inimese jaoks ta kommi ostis
                //ootab kuni kasutaja sisestab arvu, mis omistatakse muutujasse sõpradearv
                //kuvatakse välja tehe kus kommikaal jagatakse sõpradearvuga

                //         ülesanne 3           ---------------------------------
                case ("3"):

            Console.Clear();
            int kommikaal = 0;
            int sopradearv = 0;
            Console.WriteLine("mitu grammi kommi sul on? (palun sisesta taisarv)");
            kommikaal = int.Parse(Console.ReadLine());
            Console.WriteLine("Mitmele inimesele sa kommi ostsid");
            sopradearv = int.Parse(Console.ReadLine());
            Console.WriteLine($"Iga sõber saab {kommikaal/sopradearv} grammi kommi");

                    Thread.Sleep(3000);
                    Console.WriteLine("Vajauta enter et minna tagasi avalehele");
                    Console.ReadLine();
                    goto põhimenüü;

                    break;






                //4. kirjuta programm, mis
                //omab muutujat õunapuusaak
                //omab muutujat sõbersai
                //küsib kasutajalt mitu õuna ta õunapuu talle andis
                //muutujasse õunapuusaak pannakse kasutaja sisestatud arv
                //küsib kasutajalt mitu õuna ta sõber tahtis
                //ootab kuni kasutaja sisestab arvu, mis omistatakse muutujasse sõbersai
                //kuvatakse välja tehe kus õunapuusaak muutujast lahutatakse maha sõbersai,
                //ning kuvatakse koos sõnumiga "sul on nii palju õunu alles"

                //  Ülesanne 4 -------------------------------------------
                //
                case ("4"):

            Console.Clear();
            int õunapuusaak = 0;
            int sõbersai = 0;
            Console.WriteLine("Mitu õuna said õunapuult ?");
            õunapuusaak = int.Parse(Console.ReadLine());
            Console.WriteLine("Kui palju õunu tahtis su sõber ?");
            sõbersai = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sul jäi alles {õunapuusaak - sõbersai} õun/õuna");

                    Thread.Sleep(3000);
                    Console.WriteLine("Vajauta enter et minna tagasi avalehele");
                    Console.ReadLine();
                    goto põhimenüü;

                    break;

                //-----------------  parem versioon  ---------------- ei oma Vooskeemi hetkel.
                /*
                int õunapuusaak = 0;
                int sõbersai = 0;
                Console.WriteLine("Mitu õuna said õunapuult ?");
                õunapuusaak = int.Parse(Console.ReadLine());
                Console.WriteLine("Kui palju õunu tahtis su sõber ?");
                sõbersai = int.Parse(Console.ReadLine());
                int vahe = õunapuusaak - sõbersai;

                if (vahe < 0)
                {
                    Console.WriteLine("Kuidas sa miinusesse jäid?");
                }
                else
                {
                    Console.WriteLine($"Sul jäi alles {vahe} õuna");
                }
                */

                //5. kirjuta programm, mis
                //omab neli täisarvu muutujat, üks ema, isa, kasutaja ja õe jaoks
                //küsib kasutajalt kasutaja pikkust
                //paneb kasutajalt saadud väärtuse õigesse muutujasse
                //küsib kasutajalt kasutaja ema pikkust
                //paneb kasutajalt saadud väärtuse õigesse muutujasse
                //küsib kasutajalt kasutaja isa pikkust
                //paneb kasutajalt saadud väärtuse õigesse muutujasse
                //küsib kasutajalt kasutaja õe pikkust
                //paneb kasutajalt saadud väärtuse õigesse muutujasse
                //programm tekitab uue muutuja, kus arvutatakse välja kasutaja perekonnaliikmete keskmine pikkus
                //kuva kasutajale tema perekonna keskmine pikkus

                // Ülesanne 5 -------------------------------------------------
                case ("5"):

             Console.Clear();
            int emapikkus = 0;
            int isapikkus = 0;
            int õepikkus = 0;
            int kasutajapikkus = 0;
            Console.WriteLine("Palun sisestage oma pikkus (cm)");
            kasutajapikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisestage oma õe pikkus (cm)");
            õepikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisestage oma ema pikkus (cm)");
            emapikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisestage oma isa pikkus (cm)");
            isapikkus = int.Parse(Console.ReadLine());
            int keskmine = (kasutajapikkus + emapikkus + isapikkus + õepikkus) / 4;
            Console.WriteLine($"Teie pere keskmine pikkus on {keskmine} sentimeetrit");

                    Thread.Sleep(3000);
                    Console.WriteLine("Vajauta enter et minna tagasi avalehele");
                    Console.ReadLine();
                    goto põhimenüü;

                    break;


                //6. kirjuta programm, mis
                //omab viite muutujat: esmaspäev, teisipäev, kolmapäev, neljapäev ja reede
                //küsib kasutajalt eraldi küsimusega iga päeva kohta "mitu minutit arvutimänge mängisid"
                //peale igat küsimust, sisestab vastavasse muutujasse kasutaja poolt saadud tulemuse
                //programm teeb muutuja "ajakulu" kuhu arvutatakse liites kokku kõik nädalapäeva muutujad
                //programm teeb muutuja päevakeskmine, mis hetkel on 0;
                //muutujasse päevakeskmine arvutatakse ajakulu muutujat kasutades keskmine tehtega (ajakulu / 5)
                //programm kuvab kasutajale oma nädalase koguajakulu
                //programm kuvab kasutajale päeva keskmise ajakulu
                //programm teeb muutuja "tundidesajakulu", mille sisse pannakse tehte (ajakulu/60) tulemus
                //programm kontrollib IF abil, kas  ajakulu on 35h või suurem
                //kui on suurem, kuva hoiatus "sinu mängimisele kulub peaaegu samasugune aeg nagu tavalisel inimesel töönädalas töötamisele"
                //kui on väiksem, ära tee midagi.

                case ("6"):

                    Console.Clear();
                    //ma ei tea miks aga mul on overwrite on ja ei saa muuta niiet teen selle programmi teises projektis ja koreepin siia

                    int esmaspäev = 0;
                    int teisipäev = 0;
                    int kolmapäev = 0;
                    int neljapäev = 0;
                    int reede = 0;

                    Console.WriteLine("Kui palju sa mängisid videomänge esmaspäeval (minutites)?");
                    esmaspäev = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kui palju sa mängisid videomänge teisipäeval (minutites)?");
                    teisipäev = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kui palju sa mängisid videomänge kolmapäeval (minutites)?");
                    kolmapäev = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kui palju sa mängisid videomänge neljapäeval (minutites)?");
                    neljapäev = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kui palju sa mängisid videomänge reedel (minutites)?");
                    reede = int.Parse(Console.ReadLine());

                    int ajakulu = esmaspäev + teisipäev + kolmapäev + neljapäev + reede;
                    int päevakeskmine = 0;
                    päevakeskmine = ajakulu / 5;

                    Console.WriteLine($"Sul kulus mängimisele see nädal {ajakulu} minutit");
                    Console.WriteLine($"Sul kulus mängimisele keskmiselt {päevakeskmine} minutit päevas");

                    int Tundidesajakulu = ajakulu / 60;

                    if (Tundidesajakulu >= 35 && Tundidesajakulu <= 167)
                    {
                        Console.WriteLine("sinu mängimisele kulub peaaegu samasugune aeg nagu tavalisel inimesel töönädalas töötamisele");
                    }
                    else if (Tundidesajakulu >= 168)   //täiustus mis ei eksisteeri vooskeemil.
                        {
                            Console.WriteLine("Kuidas sa said mängida rohkem tunde kui nädalas on kokku?");
                        }

                        Thread.Sleep(3000);
                    Console.WriteLine("Vajauta enter et minna tagasi avalehele");
                    Console.ReadLine();
                    goto põhimenüü;

                    break;

                case ("7"):

                    Environment.Exit(0);
                    break;

                    default:

                    Console.Clear();
                    Console.WriteLine("Sellist valikut ei ole,avalehele 3 sekundi pärast");
                    Thread.Sleep(3000);

                    goto põhimenüü;

                        break;

         }
        }
    }
}
