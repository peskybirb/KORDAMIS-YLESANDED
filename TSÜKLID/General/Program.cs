namespace General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #n1. "Tervitus"
            // kirjuta programm mis,
            // - küsib tsükliga kasutajalt tema eesnime
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema keskmist nime
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema perekonnanime
            // - - küsitakse uuesti tühja sisendi korral
            // - tema vanust
            // - - küsitakse uuesti tühja sisendi korral
            // - ning väljastab talle tervituslause, kasutades kõiki muutujaid
            /*
            string Eesnimi = string.Empty;            
            string Keskminenimi = string.Empty;          
            string PerekonnaNimi = string.Empty;            
            int Vanus = 0;

            while (Eesnimi == string.Empty)
            {
                Console.WriteLine("Palun sisesta oma eesnimi");
                Eesnimi = Console.ReadLine();
            } 
            while (!(Keskminenimi != string.Empty))
            {
                Console.WriteLine("Palun sisesta oma keskminenimi");
                Keskminenimi = Console.ReadLine();
            }            
            while (PerekonnaNimi == string.Empty)
            {
                Console.WriteLine("Palun sisesta oma perekonnanimi");
                PerekonnaNimi = Console.ReadLine();
            }
            while(Vanus < 1)
            {
                // tühi vanus ei saa olla 
                Console.WriteLine("Palun sisesta oma vanus");
                Vanus = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Tere päevast {Eesnimi} {PerekonnaNimi} või kutsun sind {Keskminenimi} oled ilusti kasvanud, oled juba {Vanus} astat vana");
            */

            // #n2. "Minu lemmiksnäkk"
            // kirjuta programm mis
            // küsib kasutajalt mis on ta lemmiksnäkk
            // programm kontrollib tsükliga kas järjendis on snäkk olemas
            // kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
            // kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"
            /*
            List<string> list = new List<string>()
            {
                "KitKat",
                "õun",
                "pocky",
                "Twix",
                "bounty",
                "banaan",
                "Mars",
                "kõrpsud",
                "juust",
                "saiake"
            };

            string kasutajaleMeeldib = string.Empty;

            bool isPresent = false;

            while (isPresent != true)
            {
                // küsime kasutajalt
                Console.WriteLine("Sisesta oma lemmik snäkk");
                kasutajaleMeeldib = Console.ReadLine();

                //kontrollime kas listis on snäkk
                foreach (var snäkk in list)
                {
                    if (snäkk == kasutajaleMeeldib)
                    {
                        isPresent = true;
                    }
                }
                if (isPresent == true)
                {
                    Console.WriteLine($"jaa, tean seda ,{kasutajaleMeeldib} on hea");
                }
                else
                {
                    Console.WriteLine("Kahjuks ei tea seda snäkki :<");
                }
            }
            */

            // #n3. "Metsataimede välimääraja"
            // kirjuta programm mis
            // küsib kasutajalt kas ta otsib mingit seent või marja (tsüklis)
            // kui seent, siis programm esitab seeneloendis olevad seened
            // ja küsib millise seene kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis seene infot ja kuvab selle
            // kui marja, siis programm esitab marjaloendis olevad marja
            // ja küsib millise marja kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis marja infot ja kuvab selle
            // siis küsitakse kas kasutaja tahab mõne marja kohta veel infot, ning tsükkel jätkub
            // ⭐iseseisvalt lisa juurde puude tuvastamine ⭐

            /*

        ALGUS:
            Console.Clear();
            bool another = true;
            string mida = string.Empty;
            List<string> Valikud = new List<string>() { "seent", "marja","puud"};
            List<string> seened = new List<string>

            {"puravik" ,
             "kukeseen",
             "kärbseseen"
            };

            List<string> seeneInfo = new List<string>

            {"puravik on pealt proon maitseb normilt" ,
             "kukeseen kollane maitseb veelgi paremini kui puravik",
             "kärbseseen parim seen listis punane valgete täppidega ja vägagi maitsev , olemas on ka roheline ja valge aga parmn neist siiski maitse poolest on valge"
            };

            List<string> marjad = new List<string>

            {"maasikas" ,
             "mustikas",
             "astelpaju"
            };

            List<string> marjaInfo = new List<string>

            {"Maasikas on punane magus mari " ,
             "mustikas on tume sisine magus ümmargune mari",
             "astelpaju on kollane maitseb nagu apelsiin"
            };

            List<string> puud = new List<string>

            {"kask" ,
             "mänd",
             "kuusk"
            };

            List<string> puuInfo = new List<string>

            {"kask on hele puu " ,
             "mänd on pikk mda",
             "kuusk on okkaline ai ai"
            };
            while (another == true)
            {


                do
                {
                    Console.WriteLine("kas otsid seent , marja või puud ?");
                    mida = Console.ReadLine();
                }
                //while (!new List<string>() {"seent","marja"}.Contains(mida));
                while (!Valikud.Contains(mida));

                if (mida == "seent")
                {
                    List<int> seeneValikud = new List<int>() { 1, 2, 3 };
                    int seenearv = 0;
                    do
                    {
                        Console.WriteLine("palun vali seen mille infot soovid , valikus on" + seened.Count + " tükki");
                        for (int i = 0; i < seened.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + seened.ElementAt(i));
                        }
                        seenearv = int.Parse(Console.ReadLine());
                    }
                    while (!seeneValikud.Contains(seenearv));

                    Console.WriteLine(seeneInfo.ElementAt(seenearv - 1));
                }
                else if (mida == "marja")
                {
                    List<int> MarjaValikud = new List<int>() { 1, 2, 3 };
                    int marjaarv = 0;
                    do
                    {
                        Console.WriteLine("palun vali seen mille infot soovid , valikus on" + seened.Count + " tükki");
                        for (int i = 0; i < marjad.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + marjad.ElementAt(i));
                        }
                        marjaarv = int.Parse(Console.ReadLine());
                    }
                    while (!MarjaValikud.Contains(marjaarv));

                    Console.WriteLine(marjaInfo.ElementAt(marjaarv - 1));
                }

                else
                {
                    List<int> puuValikud = new List<int>() { 1, 2, 3 };
                    int puuarv = 0;
                    do
                    {
                        Console.WriteLine("palun vali seen mille infot soovid , valikus on" + puud.Count + " tükki");
                        for (int i = 0; i < puud.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + puud.ElementAt(i));
                        }
                        puuarv = int.Parse(Console.ReadLine());
                    }
                    while (!puuValikud.Contains(puuarv));

                    Console.WriteLine(puuInfo.ElementAt(puuarv - 1));

                }
                string valikk = string.Empty;
                Console.WriteLine("kas soovid veel infot ? jah/ei");
                valikk = Console.ReadLine();
                if (valikk == "jah")
                {
                    goto ALGUS;
                }
                else
                {
                    Environment.Exit(0);
                }

                /*
                string kasutajaOtsus = "";
                do
                {

                }
                while ((kasutajaOtsus != "jah" && kasutajaOtsus != "ei"));
                if (kasutajaOtsus == "jah")
                {
                    another = true;
                }
                else
                {
                    another = false; 
                }
                

            }
        */
            // #n4. "Stonksid"

            // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
            // küsib kasutajalt temapoolse investeeritava summa
            // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
            // valitud firma kohta otsustab programm kordaja.
            // kui selleks on Tesla, siis on kordaja fikseeritud -1.15
            // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus
            // 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
            // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
            // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta
            // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
            // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
            // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
            // kuvatakse kasutajale tema portfelli lõppväärtus.  dowhile

            // Finish me at home !

            // extra bc why not

            // äge oleks ka kui oleks kaasa käiv menüü mis trackib sisestatud andmeid ja toob need puhtalt kaasa näidates
            // seda kasutajale

            List<string> Firmad = new List<string>() { "Tesla", "TransferWise", "MicroSlop" };

            do
            {
                
                // kui palju soovib inesteerida.
                int päev = 0;
                int e = 0;
                double VaheSumma = 0;
                double lõppSumma = 0;
                double investSum = 0;

                Console.WriteLine("Kui palju soovid investeerida ?");
                investSum = double.Parse(Console.ReadLine());

                // kuhu soovib investeerida.

                Console.WriteLine("Kuhu soovite investeerida ?");
                string valik1 = string.Empty;

                // näitab kõiki firmasid millesse on võimalik investeerida. 

                for (int i = 0; i < Firmad.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + Firmad.ElementAt(i));
                }
                valik1 = Console.ReadLine();

                // KUi kauaks soovib investeerida ? 

                Console.WriteLine("Mitmeks päevaks soovid investeerida ?");
                päev = (int.Parse(Console.ReadLine()) - 1);

                // kui valikuk on tesla.
                if(valik1 == "1")
                {
                    

                    for (int k = päev; päev >= 0 ;päev--)
                    {
                        
                        VaheSumma = investSum * -1.15;
                        

                        if (VaheSumma > 0)
                        {
                            // Prooviks "for" "if" sisse tuua äkki töötab siis  
                            // välja kirjutad päeva kohta andmed



                            Console.WriteLine($"päev " + (e + 1) + ", firma: " + Firmad[0] + " hetke seis: " + VaheSumma);
                            e++;
                            

                        }
                        else
                        {
                            Console.WriteLine($"Konto väärtus on: " + VaheSumma);
                            Console.WriteLine("Sa oled pankrotis womp womp.");
                            break;
                        }


                    }


                }  

                // kui valikuks on TransferWise
                else if (valik1 == "TransferWise")
                {




                }

                // kui valikuks on microSlop
                else
                {





                }


                if (lõppSumma <= 0)
                {
                    Console.WriteLine("Oled pankrotis");
                }
                else
                {
                    Console.WriteLine($"Sinu lõpp summa on: " + VaheSumma);
                }


            }

            while (true);
        }
    }
}
