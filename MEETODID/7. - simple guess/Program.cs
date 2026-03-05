using System.ComponentModel;
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
            List<string> Inventory = new List<string>(); 
            Random juhuArv = new Random(); // random generaator
            string mängijaMängib = "yes";  // kas mängija veel mängib ?

            do
            {
                Console.WriteLine("pokeballs left : "+pokeBalls);

                do
                {
                    int järgmineEvent = juhuArv.Next(1,6);
                    switch (järgmineEvent)
                    {
                        case 1:
                            pokeBalls = WildBidoof(juhuArv, pokeBalls,money,Inventory);
                            Thread.Sleep(2000);
                                break;
                        case 2:
                            pokeBalls = Charizard(juhuArv, pokeBalls,money);
                            Thread.Sleep(2000);
                                break;
                        case 3:
                            pokeBalls = Shop(pokeBalls,money);
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            money = Tepig(pokeBalls,money,juhuArv);
                            Thread.Sleep(2000);
                            break;
                        case 5:
                            money = Hatterene(pokeBalls, money);
                            Thread.Sleep(2000);
                            break;
                    }



                } while (pokeBalls > 0 && money > 0);

                if (pokeBalls <= 0)
                {
                    Console.Clear();
                    Stats(money, pokeBalls);
                    Console.WriteLine("---= do you wanna play again ? =---"); //küsib kas soovid veel mängida
                    mängijaMängib = Console.ReadLine(); //kasutaj avastus
                    if(mängijaMängib == "yes")
                    {
                        pokeBalls = 3;
                        money = 10;
                    }
                }
                else if (money <= 0)
                {
                    Console.Clear();
                    Stats(money, pokeBalls);
                    Console.WriteLine("---= do you wanna play again ? =---"); //küsib kas soovid veel mängida
                    mängijaMängib = Console.ReadLine(); //kasutaj avastus
                    if (mängijaMängib == "yes")
                    {
                        pokeBalls = 3;
                        money = 10;
                    }
                }


            } while (mängijaMängib == "yes"); //kui kasutaja on nõus veel mängima ei muutu jah 

        }

        public static double Hatterene(int pokeBalls, double money)
        {
            Console.Clear();
            Stats(money, pokeBalls);
            Console.WriteLine("Hattere notices you in the forest\n and donates 5 coins from pity\n \n Press enter to say \"Thank you\"");
            Console.ReadLine();
            return money + 5; 
        }

        public static double Tepig(int pokeBalls, double money, Random juhuarv)
        {
            Console.Clear();
            Stats(money, pokeBalls);
            Console.WriteLine("\nTepig runs to you with a sad face \nwill you help them out ?");
            string Ans4 = Console.ReadLine();
            if(Ans4 == "yes")
            {
                int seeJuhuarv = juhuarv.Next(1, 5);
                Console.WriteLine("\nTepig happily too your "+seeJuhuarv+" and fled");
                return money - seeJuhuarv; 
            }
            else
            {
                Console.WriteLine("\nTepig kicks you and steals 10 coins");
                return money - 10;
            }
  
        }

        public static int Shop(int pokeBalls, double money)
        {
            Console.Clear();
            Stats(money,pokeBalls);
            Console.WriteLine("\nYou approach a shop, they sell pokeballs\nWould you like to buy some ?");
            string Ans2 = Console.ReadLine();
            if(Ans2 == "yes")
            {
                Console.WriteLine("\nHow many would you like to buy ?. 1 costs 2 coins");
                int Ans3 = int.Parse(Console.ReadLine());
                int vahesumma = (Ans3*2);
                if (vahesumma > money)
                {
                    Console.WriteLine("\nno enough coins");
                    return pokeBalls;
                }
                else 
                {
                    Console.WriteLine("\nyou have successfully bought "+Ans3+" pokeballs");
                    
                    return pokeBalls + Ans3;
                }

            }
            return pokeBalls;



            
        }

        public static int WildBidoof(Random juhuArv,int pokeBalls,double money,List<string> Inventory)
        {
            Console.Clear();
            Stats(money, pokeBalls);
            int seeJuhuarv = juhuArv.Next(1, 10); //suvaline number vahemikus 1 - 10
            Console.WriteLine("\na wild Bidoof has spawned, guess how many power it has to capture it !!!\nguess: ");
            int kasutajaArv = int.Parse(Console.ReadLine()); //ootame kasutaja vastust

            if(kasutajaArv == seeJuhuarv)
            {
                Console.WriteLine("\nyou caught the wild bedoof :3");
                Inventory.Add("Bidoof");
                return pokeBalls;

            }
            else
            {
                Console.WriteLine("\nA wild Bidoof got away");
                return (pokeBalls - 1);
            }
        }

        public static int Charizard(Random juhuarv, int pokeBalls, double money)
        {
            Console.Clear();
            Stats(money,pokeBalls);
            Console.WriteLine("\na Charizard appears with a mystery bag\ndo you wanna open it ? ");
            string Ans1 = Console.ReadLine();
            if (Ans1 == "yes")
            {
                int seejuhuarv = juhuarv.Next(-4, 4);
                if (seejuhuarv >= 0)
                {
                    Console.WriteLine("\nyou have recived extra "+seejuhuarv+" pokeballs");
                    return pokeBalls + seejuhuarv;
                }
                else
                {
                    Console.WriteLine("\nCharizard stole "+(seejuhuarv * (-1))+" pokeballs from you and fled");
                    return pokeBalls - (seejuhuarv * (-1));
                }
            }
            
            else
            {
                return pokeBalls;
            }
        }
        public static void Stats(double money, int pokeBalls)
        {
            Console.WriteLine("pokeballs left : " + pokeBalls);
            Console.WriteLine("money left : " + money + " coins");
        }
        

    }
}
