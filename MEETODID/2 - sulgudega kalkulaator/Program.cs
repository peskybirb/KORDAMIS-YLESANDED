using System.Security.Cryptography.X509Certificates;

namespace _2___sulgudega_kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta koos sisendi kontrolliga ja kasutaja sisesndi normaliseerimisega
            //programm küsib kasutajalt kolme tehet , Esimene ja kolmas peaksid olema sulgude vahel , kasutaja saab
            //määrata igale tehtele märgi programm kuvab vastuse vastavalt tehete järjekorrale.
            
            //väga kiirelt kirjutatud kood mida proovisin järgi kirjutada aga asi läks kiirelt metsa ja järg kadus niiet
            //see nata broken + me no understand whats even going on.


            //arusaadav
            Console.WriteLine("Sulgudega kalkulaator");
            string[] tehteRida = new string[7];
            Console.WriteLine("(arv tehe arv) tehe (arv tehe arv)");
            for (int i = 0; i < tehteRida.Length; i++)
            {
  
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Palun sisesta arv. {i + 1} arv");
                }
                else
                {
                    Console.WriteLine($"Palun sisesta arv. {i + 1} tehe");
                }
                tehteRida[i] = Console.ReadLine();
            }

            //??????
            double tehe = ÜksTehe([ÜksTehe([tehteRida[0],tehteRida[1],tehteRida[2]]).ToString(),

               tehteRida[3],

               ÜksTehe([tehteRida[4],tehteRida[5],tehteRida[6]]).ToString()]);

        }
        
        // ??
        //mida see meetod tegema ültse peaks 
        public static double ÜksTehe(string[] tehteRida)
        {
  
            //miks switch kontrollib tehterea teist elementi?
            switch (tehteRida[1])
            {
                //mhmmm
                case "+":
                    Liitmine(double.Parse(a), double.Parse(b));
                    
                    break;
                case "-":
                    Lahutamine(double.Parse(a), double.Parse(b));
                    break;
                case "*":
                    Korrutamine(double.Parse(a), double.Parse(b));
                    break;
                case "/":
                    Korrutamine(double.Parse(a), double.Parse(b));
                    break;

                default:
                    return 0;
                    break;
            }
        }
        
        // sellest siin all saab arvu veel
        public static double Liitmine(double arv1, double arv2) 
        {
         return arv1 + arv2;
        }
        
        public static double Lahutamine(double arv1, double arv2) 
        {
         return arv1 - arv2;
        }

        public static double Korrutamine(double arv1, double arv2)
        {
            return arv1 * arv2;
        }
        public static double Jagamine(double arv1, double arv2)
        {
            return arv1 / arv2;
        }


}
}
