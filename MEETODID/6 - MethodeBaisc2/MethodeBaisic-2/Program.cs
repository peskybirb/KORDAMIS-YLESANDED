using System.ComponentModel.Design;

namespace MethodeBaisic_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //on meetod mis kuvab kasutajale ühe sõnumi
            KuvaSõnum();
            // on meetod, mis taheb teada, kui palav õues on ? (temperattur)
            KuiPalavOn(-3);
            //on meetod mis arvutab järjendi kõikide elementide keskmise , hoiab muutujas meeles ja kuvab eraldi real välja Pea
            //programmis mitte meetodis , meetod ainut tagastab väärtuse.
            double scores = ArvutaKeskmine(new List<double> {1.7,5,2,5,2,6,5.9,3,7.1,5,8.6 });
            Console.WriteLine("keskmine score on "+Math.Round(scores, 2));
            */



            //õnneennustaja
            //vaja on: kasutajanime , sünniaastat , lemmik vääriskivi ja lemmilooma liik

            //Nimi
            Console.WriteLine("Tere õhtust, eksinud rändaja, kas sa soovid oma tulevikku vaadata ?\nKui ja siis kirjuta oma nimi");
            string eksinudNimi = Console.ReadLine();

            //Aasta
            Console.WriteLine("Mis aastal oled siia ilma eksinud ?");
            string eksinudAasta = Console.ReadLine();

            //Kivi
            Console.WriteLine("Mis on sinu lemmik vääriskivi ?");
            string eksinudKivi = Console.ReadLine();

            //lemmikloom
            Console.WriteLine("Mis on sinu lemmik lemmikloom ?");
            string eksinudLoom = Console.ReadLine();

            int tähed = eksinudNimi.Length;
            int viimaneAastaArv = int.Parse(eksinudAasta.Substring((eksinudAasta.Length - 1), 1));
            RahaÕnn(tähed,viimaneAastaArv);
            string Iseloom = LapseÕnn(eksinudLoom);

            if (Iseloom == "ei-tea" )
            {
                Console.WriteLine("OI ÕUDUST SEDA VENDA EI TOHI LAHTI LASTA");
            }
            else
            {    
                Console.WriteLine("kallis "+eksinudNimi+" sinu laps saab olema "+Iseloom+" ."); 
            }
            KaitseÕnn(eksinudKivi);
        }



        /// <summary>
        /// Kaitseõnn kuvab kasutajale  olenevealt tema lemmikkivist tema õnne
        /// </summary>
        /// <param name="Kivi">kasutaja pool kirjutatud kivi</param>
        public static void KaitseÕnn(string Kivi)
        {
            List<string> vargus = new List<string>() {"teemant", "graniit", "topaas" };
            List<string> vigastus = new List<string>() {"smaragd", "rubiin", "jaspis" };
            List<string> hullumus = new List<string>() {"tiigersillm", "paekivi", "kvarts" };

            if(vargus.Contains(Kivi))
            {
                Console.WriteLine("Sinu kivi - "+Kivi+" - kaitseb sind hästi varguse eest");
            }
            else if (vigastus.Contains(Kivi))
            {
                Console.WriteLine("Sinu kivi - "+Kivi+" - kaitseb sind hästi vigastuse eest");
            }
            else if (hullumus.Contains(Kivi))
            {
                Console.WriteLine("Sinu kivi - "+Kivi+" - kaitseb sind hästi hulluse eest");
            }
            else
            {
                Console.WriteLine("Viska minema pole midagi väärt");
            }

        }



        /// <summary>
        /// Olenevelt kasutaja pool sisestatud lemmiku looma liigi põhjal valib milline tema järgmine laps iseloomult on
        /// </summary>
        /// <param name="loom">kasutaja pool sisestatud loomaliigi nimetus</param>
        /// <returns></returns>
        public static string LapseÕnn(string loom)
        {
            if (loom == "jänes")
            {
                return "krapsakas";
            }
            else if (loom == "kass")
            {
                return "armas";
            }
            else if (loom == "rebane")
            {
                return "kaval";
            }
            else if (loom == "öökull")
            {
                return "tark";
            }
            else if (loom == "sääsk")
            {
                return "tüütu";
            }
            else if (loom == "koer")
            {
                return "lojaalne";
            }
            else
            {
                return "ei tea";
            }
        }



        /// <summary>
        /// nime pikkuse ja aasta arvu keskmisest ennustab isiku õnne
        /// </summary>
        /// <param name="nimeTäheArv">kasutja poolt sisestatud nime pikkus</param>
        /// <param name="aastaArv">kasutaja pool sisestatud aasta viimane arv</param>
        public static void RahaÕnn(int nimeTäheArv,int aastaArv)
        {
            int õnneKeskmine = (nimeTäheArv + aastaArv) / 2;
            //väiksem kui 0 suurem kui 10
            if (õnneKeskmine < 0 || õnneKeskmine > 10)
            {
                Console.WriteLine("OIOioiioiOIoiOioIoiOio sinu õnn on põhimõttleiselt olematu tunnen kaasa");
            }
            else
            {
                switch(nimeTäheArv)
                {
                    case 1:
                        Console.WriteLine("kes sin nii nimetas ? halb õnn");
                            break;
                    case 2:
                        Console.WriteLine("halb õnn soovitan nme muuta");
                            break;
                    case 3:
                        Console.WriteLine("väga tore hea õnn");
                            break;
                    case 4:
                        Console.WriteLine("sul on keskmine õnn asja dlähevad sul edasi nrmaalselt");
                            break;
                    case 5:
                        Console.WriteLine("sul on mega õnn ja saad hakkama mllega iganes");
                            break;
                    case 6:
                        Console.WriteLine("sul on hea õnn tuleb palju raha");
                            break;
                    case 7:
                        Console.WriteLine("õnn on alla keskmise soovitan uut tööd otsida");
                            break;
                    case 8:
                        Console.WriteLine("norm õnn ig");
                            break;
                    case 9:
                        Console.WriteLine("väga halb õnn ole valmis");
                            break;
                    default:
                            break;

                }
            }
        }




        /// <summary>
        /// arvutab meetodisse parameetrina kaasa antud nimekirjas olevate arvude keskmise
        /// </summary>
        /// <param name="Andmed">meetodi töö jaoks vajalikud sisendid</param>
        /// <returns>komakohaga andmed keskmises arvutuses</returns>
        public static double ArvutaKeskmine(List<double> Andmed)
        {
            double Keskmine = 0;
            for(int i = 0; i < Andmed.Count;i++)
            {
             Keskmine += Andmed[i];
            }
            Keskmine /= Andmed.Count;
            KuiPalavOn(Keskmine);
            return Keskmine;
        }



        /// <summary>
        /// Olenevalt antud temperatuurist vastab kasutajale
        /// </summary>
        /// <param name="Temp">meetodi töö jaoks vajalikud sisendid</param>
        public static void KuiPalavOn(double Temp)
        {
            if (Temp <= 0 && Temp >= -50)
            {
                Console.WriteLine("CRO ITS COLDDD");
            }
            else if (Temp > 0 && Temp <= 15)
            {
                Console.WriteLine("Lil chilli still vro");
            }
            else if (Temp > 15 && Temp <= 25)
            {
                Console.WriteLine("Suht soe");
            }
            else if (Temp > 25 && Temp <= 35)
            {
                Console.WriteLine("WOOOO NICEE");
            }
            else 
            {
                Console.WriteLine("me dead bro");
            }
        }



        /// <summary>
        /// ütleb kasutajale sõnumi
        /// </summary>
        public static void KuvaSõnum()
        {
            Console.WriteLine("HEYAAA WHATS UP VRO");
        }


    }
}
