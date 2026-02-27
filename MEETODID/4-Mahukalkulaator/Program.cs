using System.Net.Http.Headers;

namespace _4_Mahukalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta programm mis
            //küsib kasutajalt kas ta tahab arvutada oma kasti mahtu, või õlivaadi mahtu
            //sisendite küsimiseks on oma meetod, mis ei lase programmil edasi liikuda, kuni vastus ei ole tühi, ega üks võimalikest valikutest.
            //selle tegemiseks annate meetodile parameetrina valikud listis kaasa ja .Contains abil saate kontrollida kas ta on olemas või mitte
            //kui programm teab kumba ta arvutab toimuvad järgmised tegevused
            //  kasti puhul, küsitakse kas kast on kuubik või risttahukas.
            //    - kuubiku puhul küsitakse küljepikkus, antakse parameetrina meetodile KuubiRuumala() kaasa,
            //      ning kuubiruumala tagastab double tüüpi andmena muutujasse tehte tulemuse. valem otsi internetist.
            //---------------------------         HETKEL SIIN          ---------------------------------------------------------------- 
            //    - risttahuka puhul lühima ja pikima külje pikkust ning kõrgust. samamoodi arvutab parameetrite abil 
            //      meetod RisttahukaRuumala() tulemuse double andmena ja tagastab selle muutujasse.
            //  Tünni puhul, küsitakse kas ta tünn on kaanega või kaaneta.
            //    - Kui tal on kaas olemas, siis küsi selle paksust, kui ei ole, määra paksuseks ise 0
            //      Küsi kasutajalt ka tünni põhja läbimõõtu ja kõrgust ning arvuta SilindriRuumala()
            //      meetodiga kus parameetrid ka kaasas double tulemus mille tagastad muutujasse
            //      NB! kaane paksuse arvutad kõrgusest maha, sest kaas võtab õlitünni sees mingi ruumala enda poolt ära.
            //Kuva kasutajale tema ruumala tulemus peaprogrammis, mitte arvutatavates meetodites.
        

            Console.WriteLine("Kas sa saaovid arvutada Kasti või Tünni ruumala ?");
            string[] asjandused = new string[] {"Kast","Tünn"};
            int valikuArv = asjandused.Length;

            for (int i = 0; i < asjandused.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + asjandused[i]);
            }
            int kasutajaValik = Valik(new List<int> {1,2}); 
            string V2 = string.Empty;


            if((kasutajaValik-1) == 0)
            {

                //geniaalne idee 1 static menu if yk yk 

              Console.WriteLine("kas soovite arvutada 1.kuubiku või 2.risttahuka ruumala");
              V2 = Console.ReadLine();
              if (V2 == "1")
              {
                    Console.WriteLine("Mis on kuubi küljepikkus ?");
                    double Kuubikülg = double.Parse(Console.ReadLine());
                    double vastus = KuubiRuumala(Kuubikülg);
                    Console.WriteLine("vastuseks tuleb "+vastus);
              }
              else if (V2 == "2")
              {
                    //geniaalne idee 2 list milles on nee d3 asja või array


              }
              else
              {
                    Console.WriteLine("ei tea sellist");
              }

                


            }
            else if ((kasutajaValik-1) == 1)
            {
                Console.WriteLine("Kas Tünnil on kaan või mitte ?");

                



            }


        }



        public static double RistTahukaRuumala()
        {

            //geniaalne idee 3 arrays asjsad ja võtab seal maha asju vb töötab ei tea hardcode-ish
            return 0;
        }
 
        public static double KuubiRuumala(double külg)
        {
            double ruumala = Math.Pow(külg, 3);
            return Math.Round(ruumala, 2);
        }


        public static int Valik(List<int> asjandus)
        {
            int valik;
            do
            {
                Console.WriteLine("Sisesta valik: ");
                valik = int.Parse(Console.ReadLine());

            } while (!asjandus.Contains(valik));
            return valik;
        }


    }
}
