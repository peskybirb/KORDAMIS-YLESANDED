namespace _5___MethodBaisic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> koodid = new List<int>() {4321, 6767, 6932, 4020, 8008, 9823 };
            List<double> kontod = new List<double> {199.89d, -44.87d, 34353.67d,0d,67d,1000000d};
            //panga automaat

            Console.WriteLine("Tere tulemast panka , palun sisesta oma pinkood");
            int pinkood = Koodisisestus(koodid);

            TervitaKasutajat(pinkood);
            EsitaKontojääk(pinkood,koodid,kontod);
            Console.WriteLine("mida sa teha soovid ? palun vali arvuga");
            string[] valikud = new string[] {"väljavõte - võta raha välja","Sissemaks - Pane raha sisse" };
            int valikuArv = valikud.Length;

            for(int i = 0; i < valikud.Length; i++)
            {
                Console.WriteLine((i+1)+ ". " + valikud[i]);
            }

            int kasutajaValik = Valik(new List<int>{1,2 });

            //väljamakse
            if((kasutajaValik-1) == 0)
            {
                Console.WriteLine("kui palju raha soovid välja võtta ?");
                double väljaSumma = double.Parse(Console.ReadLine());


                    while (väljaSumma < 0 || väljaSumma != null)
                    {
                        Console.WriteLine("Negatiivset arvu sisestada ei saa, sisesta uuesti");
                        väljaSumma = double.Parse((Console.ReadLine()));
                    }
                    kontod = Väljavõte(pinkood, koodid, kontod, väljaSumma);
                    

            }
            //Sissemakse
            else if ((kasutajaValik-1) == 1)
            {
                Console.WriteLine("kui palju raha soovid Sisse lisada ?");
                double SisseSumma = double.Parse(Console.ReadLine());
                while (SisseSumma < 0)
                {
                    Console.WriteLine("Negatiivset arvu sisestada ei saa, sisesta uuesti");
                    SisseSumma = double.Parse((Console.ReadLine()));
                }
                kontod = Väljavõte(pinkood, koodid, kontod, -SisseSumma);

            }

                EsitaKontojääk(pinkood, koodid, kontod);
        }

        public static List<double> Väljavõte(int filter, List<int> accounts, List<double> balances, double withdrawAmount)
        {
            int elementLocation = accounts.IndexOf(filter);
            balances[elementLocation] -= withdrawAmount;
            return balances;

        }

        /*
        public static List<double> SisseMaks(int filter, List<int> accounts, List<double> balances, double withdrawAmount)
        {
            int elementLocation = accounts.IndexOf(filter);
            balances[elementLocation] += withdrawAmount;
            return balances;

        }
        */


        public static void EsitaKontojääk(int filter, List<int> accounts, List<double> balances)
        {
            int elementLocation = accounts.IndexOf(filter);
            Console.WriteLine("Teie kontojääk on "+balances.ElementAt(elementLocation));
        }






        public static void TervitaKasutajat(int userPin)
        {
            Console.WriteLine("Tere "+userPin+" oled sisesnenud panga automaati!");
        }







        private static int Valik(List<int> valikud)
        {
            int valik;
            do
            {
                Console.WriteLine("Sisesta kood: ");
                valik = int.Parse(Console.ReadLine());

            } while (!valikud.Contains(valik));
            return valik;
        }        





        private static int Koodisisestus(List<int> andmebaasiInfo)
        {
            int pinkood;
            do
            {
                Console.WriteLine("Sisesta kood: ");
                pinkood = int.Parse(Console.ReadLine());

            } while (!andmebaasiInfo.Contains(pinkood));
            return pinkood;
        }
    }
}
