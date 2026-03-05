using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace _7.___simple_guess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kodune ülesanne raha muutuja ja 3 eventi mis muudavad raha seisu 
            int pokeBalls = 3;
            double money = 10;
            List<string> items = new List<string>();
            Random juhuArv = new Random(); // random generaator
            string mängijaMängib = "yes";  // kas mängija veel mängib ?

            do
            {
                Console.WriteLine("pokeballs left : "+pokeBalls);

                do
                {
                    int järgmineEvent = juhuArv.Next(1,3);
                    switch (järgmineEvent)
                    {
                        case 1:
                            pokeBalls = WildBidoof(juhuArv, pokeBalls);
                            Thread.Sleep(3000);
                                break;
                        case 2:
                            pokeBalls = Charizard(juhuArv, pokeBalls);
                            Thread.Sleep(3000);
                                break;
                        case 3:
                            pokeBalls = Shop(pokeBalls,money,items);
                            Thread.Sleep(3000);
                            break;
                    }



                } while (pokeBalls > 0);

                pokeBalls = Charizard(juhuArv, pokeBalls);
                Thread.Sleep(3000);

                if (pokeBalls <= 0)
                {
                    Console.WriteLine("---= do you wanna play again ? =---"); //küsib kas soovid veel mängida
                    mängijaMängib = Console.ReadLine(); //kasutaj avastus
                    if(mängijaMängib == "yes")
                    {
                        pokeBalls = 3;
                    }
                }

            } while (mängijaMängib == "yes"); //kui kasutaja on nõus veel mängima ei muutu jah 

        }

        private static int Shop(int pokeBalls, double money, List<string> items)
        {
            
        }

        public static int WildBidoof(Random juhuArv,int pokeBalls)
        {
            Console.Clear();
            Console.WriteLine("pokeballs left : " + pokeBalls);
            int seeJuhuarv = juhuArv.Next(1, 10); //suvaline number vahemikus 1 - 10
            Console.WriteLine("a wild Bidoof has spawned, guess how many power it has to capture it !!!");
            Console.WriteLine("guess: ");
            int kasutajaArv = int.Parse(Console.ReadLine()); //ootame kasutaja vastust

            if(kasutajaArv == seeJuhuarv)
            {
                Console.WriteLine("you caught the wild bedoof :3");
                return pokeBalls;
            }
            else
            {
                Console.WriteLine("A wild Bidoof got away");
                return (pokeBalls - 1);
            }
        }

        public static int Charizard(Random juhuarv, int pokeBalls)
        {
            Console.Clear();
            Console.WriteLine("pokeballs left : " + pokeBalls);
            Console.WriteLine("a Charizard appears with a mystery bag\ndo you wanna open it ? ");
            string Ans1 = Console.ReadLine();
            if (Ans1 == "yes")
            {
                int seejuhuarv = juhuarv.Next(-4, 4);
                if (seejuhuarv >= 0)
                {
                    Console.WriteLine("you have recived extra "+seejuhuarv+" pokeballs");
                    return pokeBalls + seejuhuarv;
                }
                else
                {
                    Console.WriteLine("Charizard stole "+(seejuhuarv * (-1))+" pokeballs from you and fled");
                    return pokeBalls - seejuhuarv;
                }
            }
            
            else
            {
                return pokeBalls;
            }
        }
        

    }
}
