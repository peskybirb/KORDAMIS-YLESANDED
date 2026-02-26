

namespace _1._tänava_nimed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kasutades meetodied ja sõne töötlemis vahendedid sisendi kontrollli joaks kirjuta programm mis 
            //küsib kasutajalt tema kodukandi tänava nimesid , küsib talle millin etähestiku täht talle ei meeldi
            //programm otsib järjendist kõik tänava nimed milles ebameeldv täht esineb ning eemaldab need järjendist ning kuvab
            //järjendi välja . programm loendab ka kokku eemaldatud nimede arvu ning tagastab sõnumi koos loendiga mitu sõna
            //eemaldati.

            //very crooked progrma 

            //not so good dubug code
            //string tänavanimi = Sisendjakontroll();
            //Console.WriteLine(tänavanimi);

            List<string> tänavanimed = new List<string>();
            Console.WriteLine("kitjuta oma kodukandi tänava nimed kui rohkem ei ole  kirjuta  ei-ole");
            string sisestus = "";

            do
            {
                Console.WriteLine("siseta tänavanimed");
                sisestus = Sisendjakontroll();
                if (sisestus != "Ei-ole")
                {
                    tänavanimed.Add(sisestus);
                }

            } while (sisestus != "Ei-ole");


            Console.WriteLine("Kirjuta täht mis sulle ei meeldi");
            string ebameeldivtäht = Sisendjakontroll();
            List <string> uusJärjend = JärjendiFiltreerimine(tänavanimed,ebameeldivtäht);
            KuvaAndmed(uusJärjend);

        }

        private static void KuvaAndmed(List<string> kuvatavadAndmed)
        {
            if (kuvatavadAndmed.Count > 0)
            {
             for (int i = 0;i < kuvatavadAndmed.Count;i++)
                {
                    Console.WriteLine((i+1)+". " + kuvatavadAndmed[i]);
                }
                return;


            }
            Console.WriteLine("Järjend on tühi");
            return;
        }

        private static List<string> JärjendiFiltreerimine(List<string> filtreeritavadAndmed, string Filter)
        {
            int loendur = 0;   
            List <string> töödeldudAndmed = new List<string>();

            foreach(var anne in filtreeritavadAndmed)
            {
                if (!anne.ToLower().Contains(Filter.Trim()))
                {
                    töödeldudAndmed.Add(anne);
                }
                else 
                {
                    loendur++;
                }
            }
            Console.WriteLine($"eemaldati {loendur} elementi");
            return töödeldudAndmed;


        }

        public static string Sisendjakontroll()
        {
            string sisestus = "";
            string töödeldudSisestus = "";
            do
            {
                Console.WriteLine("Kirjuta siia: ");
                sisestus = Console.ReadLine();
           

            if (sisestus.Length > 1) 
            {
                töödeldudSisestus = (sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower());
            }
            else
            {
                Console.WriteLine("tänava nimi ei saa olla lühem kui 2 tähte.");
                sisestus = "";
            }
            } while (string.IsNullOrEmpty(sisestus));
            return töödeldudSisestus;






        } public static string Sisendjakontroll(string addition)
        {
            string sisestus = "";
            string töödeldudSisestus = "";
            do
            {
                Console.WriteLine("Kirjuta siia: ");
                sisestus = Console.ReadLine()+addition;
           

            if (sisestus.Length > 1) 
            {
                töödeldudSisestus = (sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower());
            }
            else
            {
                Console.WriteLine("tänava nimi ei saa olla lühem kui 2 tähte.");
                sisestus = "";
            }
            } while (string.IsNullOrEmpty(sisestus));
            return töödeldudSisestus;
        }
    }
}
