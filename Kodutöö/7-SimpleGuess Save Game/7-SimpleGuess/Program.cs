using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7_SimpleGuess
{
    internal class Program
    {
        public static bool exit { get; set; } = true;
        public static string SaveRequest { get; set; } = string.Empty;
        static void Main(string[] args)
        {
            /*
             Lisa juurde raha muutuja ja kolm eventi mis muudavad raha seisu - MEETODITEGA
             */
            /*
            Lisa juurde veritsemine.
            - Selle jaoks on vaja booleani, mis mäletab kas sa veritsed või mitte
            - Ning peale igat eventi, on teine, täisarvu muutuja, mis mäletab palju ühest elust alles on, peale igat eventi 
            võetakse maha 10st punkt, ja kui summa on 0, siis võetakse maha 1 elu.
            - Lisa üks event mis tervendab veritsemise, lisa veritsemisomadus juurde nendele olukordadele kus kasutaja ka tavaliselt elusid kaotab
             */







            /* salvestus ja laadimine*/
            /*
             * kasutades erinevaid failioperatsioone, tee mängule juurde salvestus, mis jätab meelde palju mängijal on:
             * - raha
             * - elusid
             * - seljakoti sisu
             * - kas ta veritseb
             * - ning mitu hetke elupunkti tal alles on
             * 
             * teguviis:
             * 
             * salvestamine - 
             * kui mängija tahab väljuda, peab iga event tuvastama sisestusena sõna "exit", 
             * selle puhul mängu tsükli jooksev tingimus seatakse "false" väärtusele, ning küsitakse kas kasutaja soovib mängu salvestada,
             * kui ei, programm lihtsalt lõppeb
             * kui jah, kutsutakse esile salvestusmeetod:
             * 
             * meetod peaks tegutsema nii:
             * salvesta igaüks eraldi reale. 
             * igal real on kaks väärtust, ise otsustad kuidas neid eraldatakse,
             * esimene väärtus kirjeldab mida real hoitakse,
             * teine on selle hoitava väärtuse tegelik olek.
             * näiteks rida sisaldab "elud 2"
             * salvestusfunktsioon vajab kõiki viite muutujat parameetritena, või pakituna ühte tuplesse,
             * funktsioon sees kirjutab iga parameetri/tuple elemendi kohta uue rea uude, meetodi sees eksisteerivasse listi
             * list kirjutatakse failioperatsiooniga kinlda nimega failiks, näiteks "savegame.txt" vms.
             * 
             * laadimine - 
             * programmi alguses, kontrollib kas salvestatud kindla nimega fail eksisteerib.
             * kui on, küsitakse kasutajalt kas ta soovib mängu jätkata salvestatud infoga või mitte.
             * Kui ei, faili ei loeta, ja algab uus mäng
             * kui jah, kutsutakse esile laadimismeetod:
             * 
             * meetod peaks tegutsema nii:
             * tekitatakse viis muutujat, üks iga mängu parameetri jaoks, muutujad jäetakse tühjaks.
             * eraldab failist loetud info ridadeks
             * võetakse ette esimene rida, jaotatakse osadeks, ning loetakse rea esimene väärtus, ning 
             * olenevalt väärtusest, seatakse vastavasse muutujasse rea teise elemendi väärtus
             * käiakse läbi kõik read nii
             * ja meetod tagastab Tuple.
             * 
             * Meetodist väljaspool omistatakse tuplest vastavad väärtused erinevaisse muutujaisse.
             * ning mäng algab failist loetud andmetega.
             * 
             */

            string SaveTime = string.Empty;
            int moni = 10;
            int elud = 3;
            bool bleeding = false;
            List<string> seljaKott = new List<string>();
            Random juhuArv = new Random(); //tee random generaator
            string mängijaMängib = "jah"; // vastus küsimusele kas mängija mängib
            if (File.Exists("SaveGame.txt"))
            {
                Console.WriteLine("Kas sa soovid oma salvestuse laadida ? ");
                string Laadimine = AskUser();
                if (Laadimine == "SAVE-GAME")
                {
                    // user asked to save before even starting - save current defaults and exit
                    Tuple<int, int, bool, List<string>> SaveData = new Tuple<int, int, bool, List<string>>(moni, elud, bleeding, seljaKott);
                    CreateSave(SaveData);
                    Environment.Exit(0);
                }
                else if (Laadimine == "EXIT")
                {
                    Environment.Exit(0);
                }
                else if (Laadimine.ToLower() == "jah")
                {
                    Tuple<int, int, bool, List<string>> LoadedData = new Tuple<int, int, bool, List<string>>(moni, elud, bleeding, seljaKott);
                    LoadedData = LoadData();
                    moni = LoadedData.Item1;
                    elud = LoadedData.Item2;
                    bleeding = LoadedData.Item3;
                    seljaKott = LoadedData.Item4;
                }
            }

            do //tsükkel
            {
                do
                {

                    if (SaveTime == "SAVE-GAME")
                    {
                        //gonna go save
                        Tuple<int, int, bool, List<string>> SaveData = new Tuple<int, int, bool, List<string>>(moni,elud,bleeding,seljaKott);
                        CreateSave(SaveData);
                        Console.WriteLine("Save successful");
                        Environment.Exit(0); //exit out
                    }
                    else if (SaveTime == "EXIT")
                    {
                        //Exit
                        Environment.Exit(0);
                        mängijaMängib = "ei";
                    }
                    else
                    { 

                        Console.Clear();
                    int järgmineEvent = juhuArv.Next(1, 7);
                    switch (järgmineEvent)
                    {
                        case 1:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb elukas.");
                            Stats(moni, elud, seljaKott);
                            Tuple<Random, int, List<string>, int, string> data3 = new Tuple<Random, int, List<string>, int, string>(juhuArv, elud, seljaKott, moni, SaveTime);
                            data3 = KratiM6istatus(data3);
                            moni = data3.Item4;
                            elud = data3.Item2;
                            seljaKott = data3.Item3;
                            SaveTime = data3.Item5;
                            break;
                        case 2:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb nõid.");
                            Stats(moni, elud, seljaKott);
                            elud = Nõid(juhuArv, elud);
                            break;
                        case 3:
                            Console.WriteLine("Kõnnid metsas ja vastu tuleb seen.");
                            Stats(moni, elud, seljaKott);
                            elud = Seen(juhuArv, elud);
                            break;
                        case 4:
                            Console.WriteLine("Kõnnid tänaval ja näed maas midagi helkimas:");
                            Stats(moni, elud, seljaKott);
                            seljaKott = Nuga(seljaKott);
                            break;
                        case 5:
                            Console.WriteLine("Kõnnid mööda teed ja midagi tuleb ette.");
                            Stats(moni, elud, seljaKott);
                            List<int> data = new List<int> { moni, elud };
                            data = Mätas(data);
                            moni = data[0];
                            elud = data[1];
                            break;
                        case 6:
                            Console.WriteLine("Kõnnid poetänaval ja ette tuleb vanakraami pood, astud sisse ja näed:");
                            Stats(moni, elud, seljaKott);
                            Tuple<int, List<string>, string> data2 = new Tuple<int, List<string>, string>(moni, seljaKott, SaveTime);
                            data2 = Pood(data2);
                            moni = data2.Item1;
                            seljaKott = data2.Item2;
                            SaveTime = data2.Item3;
                            break;
                        default:
                            break;
                    }
                    // if any event set a global save/exit request, propagate it to main loop
                    if (!string.IsNullOrEmpty(SaveRequest))
                    {
                        SaveTime = SaveRequest;
                        SaveRequest = string.Empty;
                    }
                } //end on else
                    Console.WriteLine("\nVajuta ükskõik mis klahvi et jätkata (või kirjuta 'exit')");
                    string continueInput = AskUser();
                    if (continueInput == "SAVE-GAME" || continueInput == "EXIT")
                    {
                        SaveTime = continueInput;
                    }
                } while (elud > 0);

                if (elud <= 0)
                {
                    Console.WriteLine("--== Kas soovid uuesti mängida, sul on elusi 0 ==--"); //kas kasutaja soovib uuesti mängida
                    mängijaMängib = AskUser(); //saa vastus
                    if (mängijaMängib == "jah")
                    {
                        elud = 3;
                    }
                }

            } while (mängijaMängib == "jah"); //tsükkel teeb järgmise ringi kui kasutaja vastab jah, kõige muu puhul katkeb




        }




        public static Tuple<int,int,bool,List<string>> CreateSave(Tuple<int, int, bool, List<string>> stats)
        {
            string saveName = "SaveGame.txt";
            if (File.Exists(saveName))
            {
                Console.WriteLine("Salvestus on leitud \nKas soovid üle kirjutada ?");
                string userInpt = AskUser();
                if (userInpt == "jah")
                {
                    stats = new Tuple<int, int, bool, List<string>>(stats.Item1, stats.Item2, stats.Item3, stats.Item4);

                    File.Create(saveName).Close();
                    File.AppendAllText(saveName, stats.Item1.ToString() + "\n");
                    File.AppendAllText(saveName, stats.Item2.ToString() + "\n");
                    File.AppendAllText(saveName, stats.Item3.ToString() + "\n");
                    File.AppendAllText(saveName, string.Join(",", stats.Item4));
                    return stats;
                }
                else
                {
                    return stats;
                }
            }
            else
            {
                stats = new Tuple<int, int, bool, List<string>>(stats.Item1, stats.Item2, stats.Item3,stats.Item4);
                File.Create(saveName).Close();
                File.AppendAllText(saveName, stats.Item1.ToString() + "\n");
                File.AppendAllText(saveName, stats.Item2.ToString() + "\n");
                File.AppendAllText(saveName, stats.Item3.ToString() + "\n");
                File.AppendAllText(saveName, string.Join(",", stats.Item4));
                return stats;
            }

        }
        public static string AskUser()
        {
            string Answer = Console.ReadLine();
            if (Answer == null)
                return string.Empty;
            if (Answer.ToLower() == "exit")
            {
                Console.WriteLine("Kas soovid savlestada enne lahkumist ?");
                string saveAns = Console.ReadLine();
                if (saveAns != null && saveAns.ToLower() == "jah")
                {
                    SaveRequest = "SAVE-GAME";
                    return "SAVE-GAME";
                }
                else
                {
                    SaveRequest = "EXIT";
                    Program.exit = false;
                    return "EXIT";
                }
            }
            return Answer;
        }

        // keep overload for existing calls
        public static string AskUser(bool exit1)
        {
            return AskUser();
        }
        //Load data laeb data failist --- vaja ümberkirjutada natukene kuna võetud mul teisest mängust
        public static Tuple<int,int,bool,List<string>> LoadData()
        {
            Console.Clear();
            string saveName = "SaveGame.txt";
            if (File.Exists(saveName))
            {
                //add a way to load from the files into Tuple 

                var stat = File.ReadAllLines(saveName);

                int health = int.Parse(stat[0]);
                int money = int.Parse(stat[1]);
                bool status = bool.Parse(stat[2]);

                string[] splitItems = stat[3].Split(new char[] { ',' });
                List<string> inventory = new List<string>();

                foreach (string item in splitItems)
                {
                    inventory.Add(item.Trim());
                }


                Tuple<int, int, bool, List<string>> Stats = new Tuple<int, int,bool,List<string>>(health, money, status, inventory);
                Console.WriteLine("health: " + Stats.Item1);
                Thread.Sleep(300);
                Console.WriteLine("money: " + Stats.Item2);
                Thread.Sleep(300);
                Console.WriteLine("Status: " + Stats.Item3);
                Thread.Sleep(300);
                Console.WriteLine("Inventory: ");
                foreach (var item in Stats.Item4)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(150);
                }


                Console.WriteLine("Save successfully loaded");
                Thread.Sleep(1000);
                return Stats;
            }
            else
            {
                Console.WriteLine("save file was not found .\nCheck your file integrity");
                return null;

            }
        }

        private static Tuple<int, List<string>,string> Pood(Tuple<int, List<string>,string> data2)
        {
            List<string> seljaKott = data2.Item2;
            int rahakott = data2.Item1;
            List<string> riiul = new List<string>()
            {
                "katkine saabas",
                "mingi lambipirn",
                "DDR5 32GB 2x16 kit",
                "Juustukera",
                "Kotitäis lambasoolikaid"
            };
            List<int> hinnad = new List<int>()
            {
                1000,
                12,
                1600,
                3,
                -6,
            };
            for (int i = 0; i < riiul.Count; i++)
            {
                //kuva kasutajale asi, selle hind
                Console.WriteLine($"Riiulil paistab {riiul[i]} ning see maksab {hinnad[i]}.");
                Console.WriteLine("Kas sa tahad seda osta? (jah/ei)");
                string vastus = AskUser();
                if (vastus == "jah")
                {
                    if (hinnad[i] < rahakott)
                    {
                        seljaKott.Add(riiul[i]);
                        rahakott -= hinnad[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sul pole piisavalt raha selle jaoks, vaata midagi muud.");
                    }
                }
                else if (vastus == "SAVE-GAME")
                {
                    return new Tuple<int, List<string>,string>(rahakott, seljaKott,vastus);
                }
                else if (vastus == "EXIT")
                {
                    return new Tuple<int, List<string>, string>(rahakott, seljaKott,vastus);
                    
                }
                else
                {
                    Console.WriteLine("Vaatad järgmist asja \n");
                }
                // küsi vastust, kas tahab või ei
                // kui ja, siis lisa asi seljakotti, ja võta raha maha, tsükkel breakib, ja kasutaja lahkub poest
                // kui ei, näita järgmist asja

            }
            Console.WriteLine("Lahkusid poest");
            return new Tuple<int, List<string>,string>(rahakott, seljaKott,string.Empty);

        }

        private static void Stats(int moni, int elud, List<string> seljaKott)
        {
            Console.WriteLine("Sul on alles " + elud + " elu.");
            Console.WriteLine("Sul on rahakotis " + moni + " raha.");
            Console.WriteLine("Sul on seljakotis " + seljaKott.Count + " asja.");
            string sisu = "";
            foreach (string s in seljaKott)
            {
                sisu += s + ", ";
            }
            Console.WriteLine("Seljakotis on:" + sisu + "\n");

        }

        private static List<int> Mätas(List<int> datas)
        {
            int moni = datas[0];
            int elud = datas[1];
            Console.WriteLine("Kõnnid mööda teed, ja vastu tuleb huvitava kujuga põlvekõrgune mätas");
            Console.WriteLine("Mätas on keset teed ees, ei saa ei üle ega ümber sest oled laisk, mida teed?");
            Console.WriteLine("1 - ronin üle\n2 - kaevan lahti\n3 - pööran ringi ja lähen tagasi");
            Console.WriteLine("kirjuta vastava valiku number");
            string vastus = AskUser();
            if (vastus == "SAVE-GAME" || vastus == "EXIT")
            {
                return new List<int> { moni, elud };
            }
            switch (vastus)
            {
                case "1":
                    Console.WriteLine("Ronid mättast üle, ja jätkad oma teed");
                    break;
                case "2":
                    moni += 5;
                    Console.WriteLine("Kaevasid mätta lahti, ja leidsid väikese rahapaja, seal oli viis münti.");
                    break;
                default:
                    Console.WriteLine("Hakkasid kannapealt ringi pöörama, kui sellel hetkel kargas mätta\n" +
                        "tagant tuttav kratt, ja peksis sind natuke, kaotasid ühe elu.");
                    elud -= 1;
                    break;
            }

            return new List<int> { moni, elud };
        }

        private static List<string> Nuga(List<string> seljaKott)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string vastus = AskUser();
            if (vastus == "SAVE-GAME" || vastus == "EXIT")
            {
                return seljaKott;
            }
            if (vastus == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                seljaKott.Add("nuga");
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
            return seljaKott;
        }

        private static int Seen(Random juhuArv, int elud)
        {
            int seeneEffekt = juhuArv.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string vastus = AskUser();
            if (vastus == "SAVE-GAME" || vastus == "EXIT")
            {
                return elud;
            }
            if (vastus == "jah")
            {
                if (seeneEffekt >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde " + seeneEffekt + " elu.");
                    return elud + seeneEffekt;
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid " + (-seeneEffekt) + " elu.");
                    return elud + seeneEffekt;
                }
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");
                return elud;
            }
        }

        private static int Nõid(Random juhuArv, int elud)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string vastus = AskUser();
            if (vastus == "SAVE-GAME" || vastus == "EXIT")
            {
                return elud;
            }
            if (vastus.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
                return elud;
            }
            else if (vastus.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                return elud + 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE " + vastus);
                return elud - 1;
            }
        }

        private static Tuple<Random, int, List<string>, int,string> KratiM6istatus(Tuple<Random, int, List<string>, int,string> data)
        {
            Random juhuArv = data.Item1;
            int seeJuhuArv = juhuArv.Next(1, 10); //suvaline täisarv vahemikus 1-10
            int elud = data.Item2;
            List<string> seljaKott = data.Item3;
            int moni = data.Item4;
            string SaveTime = data.Item5;

            if (!seljaKott.Contains("nuga"))
            {
                Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
                Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                string s = AskUser();
                if (s == "SAVE-GAME" || s == "EXIT")
                {
                    SaveTime = SaveRequest;
                    return new Tuple<Random, int, List<string>, int,string>(juhuArv, elud, seljaKott, moni, SaveTime);
                }
                int kasutajaArv;
                if (!int.TryParse(s, out kasutajaArv))
                {
                    // invalid input - treat as wrong
                    Console.WriteLine("Vale sisend, loetakse valeks.");
                    elud -= 1;
                }
                else if (seeJuhuArv == kasutajaArv) // kontrolli sisestust tingimuslauses
                {
                    Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                }
                else
                {
                    Console.WriteLine("HJEHJEHJEH - õige vastus oli " + seeJuhuArv + "!!!! sa kaotasid!"); //kui on vale
                    elud -= 1;
                }
            }
            else
            {
                Console.WriteLine("Vastu tuleb kuri kratt, aga sul on nuga. Kratt ütleb:");
                Console.WriteLine("\"Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!\"");
                Console.WriteLine("Mida sa teed? Kas vastad (1) või ründad noaga (2)?");
                string vastus = AskUser();
                if (vastus == "SAVE-GAME" || vastus == "EXIT")
                {
                    SaveTime = SaveRequest;
                    return new Tuple<Random, int, List<string>, int,string>(juhuArv, elud, seljaKott, moni, SaveTime);
                }
                if (vastus == "1")
                {
                    Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                    string s = AskUser();
                    if (s == "SAVE-GAME" || s == "EXIT")
                    {
                        SaveTime = SaveRequest;
                        return new Tuple<Random, int, List<string>, int,string>(juhuArv, elud, seljaKott, moni, SaveTime);
                    }
                    int kasutajaArv;
                    if (!int.TryParse(s, out kasutajaArv))
                    {
                        Console.WriteLine("Vale sisend, loetakse valeks.");
                        elud -= 1;
                    }
                    else if (seeJuhuArv == kasutajaArv) // kontrolli sisestust tingimuslauses
                    {
                        Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                    }
                    else
                    {
                        Console.WriteLine("HJEHJEHJEH - õige vastus oli" + seeJuhuArv + "!!!! sa kaotasid!"); //kui on vale
                        elud -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Lõikasid krati lõhki, ta maost voolas välja 25 münti!\nAga nuga murdus...");
                    moni += 25;
                    seljaKott.Remove("nuga");
                }
            }
            return new Tuple<Random, int, List<string>, int,string>(juhuArv, elud, seljaKott, moni,SaveTime);
        }
    }
}
