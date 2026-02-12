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
                    Console.WriteLine("Kahjuks ei tea seda snäkki");
                }
            }


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

            // #n4. "Stonksid"
            // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
            // küsib kasutajalt temapoolse investeeritava summa
            // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
            // valitud firma kohta otsustab programm kordaja.
            // kui selleks on Tesla, siis on kordaja fikseeritud -1.15
            // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
            // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
            // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta
            // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
            // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
            // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
            // kuvatakse kasutajale tema portfelli lõppväärtus.
        }
    }
}
