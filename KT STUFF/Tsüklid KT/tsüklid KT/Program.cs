using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace tsüklid_KT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ülesanne 1
            //DDONEZO

                        /*
            int Vanus = 0;
            do
            {
                //Console.Clear();
                Console.WriteLine("Mis on teie vanus ?");
                Vanus = int.Parse(Console.ReadLine());
            }
            while (Vanus < 1);
                        */

            
            //ülesanne 2 proov 2
            
            //"break" pole veel olnud meil konspektis aga see on esimene viis kuidas ma selle tööle sain.
                        /*
            int aasta = 0;
            var valik = true;
            while(valik == true)
            {

                Console.WriteLine("mis aasta on ?");
                aasta = int.Parse(Console.ReadLine());

                if(aasta >= 1000 && aasta <= 2025)
                {
                    valik = false;
                    //  break; <---- eelmine viis kuidas tööle sain.
                }
            }
                        */
                              
            //ülesanne 3
            //DONZO
                        /*
            
            List<string> list = new List<string>()
            {
                "Õun",
                "Pirn",
                "Apelsiin",
                "Banaan",
                "Ploom"
            };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i+1) +". " + list[i] );
            }
                        */
                              

            //ülesanne 4
            //DONEZO
                               /*
            int[] Masiiv = new int[] { 2, 7, 5, 3, 9 };
            int vastus = 1;
            foreach (int üksArv in Masiiv)
            {
                vastus *= üksArv; 
            }
            Console.WriteLine("kõigi arvude korrutis selles masiivis on: "+vastus);
                               */
        }
    }
}
