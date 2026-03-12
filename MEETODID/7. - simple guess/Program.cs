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
            //add bleeding with bool that remember if u are or are not bleeding adds a even that removes bleeding

            //kodune ülesanne raha muutuja ja 3 eventi mis muudavad raha seisu 
            bool bleeding = false;
            int pokeBalls = 3;
            double money = 10;
            List<string> inventory = new List<string>();
            Tuple<double, int, bool, List<string>> variables = new Tuple<double, int, bool, List<string>> (money, pokeBalls, bleeding, inventory );
            Random juhuArv = new Random(); // random generaator
            string mängijaMängib = "yes";  // kas mängija veel mängib ?
            


            do
            {

                do
                {

                    int järgmineEvent = juhuArv.Next(1,6);
                    switch (järgmineEvent)
                    {
                        case 1:
                            variables = WildBidoof(juhuArv,variables);
                            Thread.Sleep(2000);
                                break;
                        case 2:
                            variables = Charizard(juhuArv,variables);
                            Thread.Sleep(2000);
                                break;
                        case 3:
                            variables = Shop(variables);
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            variables = Tepig(juhuArv,variables);
                            Thread.Sleep(2000);
                            break;
                        case 5:
                            variables = Hatterene(variables);
                            Thread.Sleep(500);
                            break;

                    }



                } while (pokeBalls > 0 && money > 0);

                if (pokeBalls <= 0)
                {
                    Console.Clear();
                    Stats(variables);
                    Console.WriteLine("---= do you wanna play again ? =---"); //küsib kas soovid veel mängida
                    mängijaMängib = Console.ReadLine();                       //kasutaj avastus
                    if(mängijaMängib == "yes")
                    {
                        pokeBalls = 3;
                        money = 10;
                    }
                }
                else if (money <= 0)
                {
                    Console.Clear();
                    Stats(variables);
                    Console.WriteLine("You ran out of money so all pokemon lost interest and fled !");
                    Console.WriteLine("---= do you wanna play again ? =---"); //küsib kas soovid veel mängida
                    mängijaMängib = Console.ReadLine();                       //kasutaj avastus
                    if (mängijaMängib == "yes")
                    {
                        pokeBalls = 3;
                        money = 10;
                    }
                }


            } while (mängijaMängib == "yes"); //kui kasutaja on nõus veel mängima ei muutu jah 

        }

         

        public static Tuple<double, int, bool, List<string>> Hatterene(Tuple<double, int, bool, List<string>> variables)
        {
            Console.Clear();
            Stats(variables);
            Console.WriteLine("\nHattere notices you in the forest\n and donates 5 coins from pity\n \n Press enter to say \"Thank you\"");
            Console.ReadLine();
            double uusRaha = variables.Item1 + 5;
            variables = new Tuple<double, int, bool, List<string>> (uusRaha, variables.Item2, variables.Item3, variables.Item4);
            return variables; 
        }

        public static Tuple<double, int, bool, List<string>> Tepig(Random juhuarv, Tuple<double, int, bool, List<string>> variables)
        {
            Console.Clear();
            Stats(variables);
            Console.WriteLine("\nTepig runs to you with a sad face \nwill you help them out ?");
            string Ans4 = Console.ReadLine();
            if(Ans4 == "yes")
            {
                int seeJuhuarv = juhuarv.Next(1, 5);
                Console.WriteLine("\nTepig happily took your "+seeJuhuarv+" and fled");

                double uusMoney = variables.Item2 + seeJuhuarv;
                variables = new Tuple<double, int, bool, List<string>> (uusMoney, variables.Item2, variables.Item3, variables.Item4);
                return variables; 
            }
            else
            {
                Console.WriteLine("\nTepig kicks you and steals 10 coins");
                double uusMoney = variables.Item2 - 10;
                variables = new Tuple<double, int, bool, List<string>> (uusMoney, variables.Item2, variables.Item3, variables.Item4);
                return variables;
                
            }
  
        }

        public static Tuple<double, int, bool, List<string>> Shop(Tuple<double, int, bool, List<string>> variables)
        {
            Console.Clear();
            Stats(variables);
            Console.WriteLine("\nYou approach a shop, they sell pokeballs\nWould you like to buy some ?");
            string Ans2 = Console.ReadLine();
            if (Ans2 == "yes")
            {
                Console.WriteLine("\nHow many would you like to buy ?. 1 costs 2 coins");
                int Ans3 = int.Parse(Console.ReadLine());
                int vahesumma = (Ans3 * 2);
                if (vahesumma > variables.Item1)
                {
                    Console.WriteLine("\nno enough coins");
                    return variables;
                }
                else
                {
                    Console.WriteLine("\nyou have successfully bought " + Ans3 + " pokeballs");
                    int uusPokeballs = variables.Item2 + Ans3;
                    double uusRaha = variables.Item1 - vahesumma;
                    variables = new Tuple<double, int, bool, List<string>> (uusRaha, uusPokeballs, variables.Item3, variables.Item4);

                    return variables;
                }

            }
            else
            {
                return variables;
            }


            
        }



        public static Tuple<double, int, bool, List<string>> WildBidoof(Random juhuArv, Tuple<double, int, bool, List<string>> variables)
        {
            Console.Clear();
            Stats(variables);
            int seeJuhuarv = juhuArv.Next(1, 10); //suvaline number vahemikus 1 - 10
            Console.WriteLine("\na wild Bidoof has spawned, guess how many power it has to capture it !!!\nguess: ");
            int kasutajaArv = int.Parse(Console.ReadLine()); //ootame kasutaja vastust

            if(kasutajaArv == seeJuhuarv)
            {
                Console.WriteLine("\nyou caught the wild bedoof :3");
                variables.Item4.Add("Bidoof");
                return variables;

            }
            else
            {
                Console.WriteLine("\nA wild Bidoof got away");
                int uusPokeball = variables.Item2 - 1;
                variables = new Tuple<double, int, bool, List<string>>(variables.Item1, uusPokeball, variables.Item3, variables.Item4);
                return variables;
            }
        }

        public static Tuple<double, int, bool, List<string>> Charizard(Random juhuarv, Tuple<double, int, bool, List<string>> variables)
        {
            Console.Clear();
            Stats(variables);
            Console.WriteLine("\na Charizard appears with a mystery bag\ndo you wanna open it ? ");
            string Ans1 = Console.ReadLine();
            if (Ans1 == "yes")
            {
                int seejuhuarv = juhuarv.Next(-4, 4);
                if (seejuhuarv >= 0)
                {
                    Console.WriteLine("\nyou have recived extra "+seejuhuarv+" pokeballs");
                    int uusPokeballs = variables.Item2 + seejuhuarv;
                    variables = new Tuple<double, int, bool, List<string>>(variables.Item1, uusPokeballs, variables.Item3, variables.Item4);
                    return variables;
                }
                else
                {
                    Console.WriteLine("\nCharizard stole "+(seejuhuarv * (-1))+" pokeballs from you and fled");
                    int uusPokeballs = variables.Item2 - seejuhuarv;
                    variables = new Tuple<double, int, bool, List<string>>(variables.Item1, uusPokeballs, variables.Item3, variables.Item4);
                    return variables;
                }
            }
            
            else
            {
                return variables;
            }
        }
        public static void Stats(Tuple<double, int, bool, List<string>> variables)
        {
            Console.WriteLine("pokeballs left : " + variables.Item2);
            Console.WriteLine("money left : " + variables.Item1 + " coins");
            if (variables.Item3 == false)
            {
                Console.WriteLine("Bleeding: no");
            }
            else
            {
                Console.WriteLine("Bleeding: yes");
            }
                Console.WriteLine("Inventory: " + variables.Item4.Count + " pokemons");
        }

        public static void SaveGame(Tuple<double, int, bool, List<string>> variables)
        {
            string save = "SaveGame.txt";
            if (File.Exists(save))
            {
                Console.WriteLine("Do you wanna overwrite the save ?");
                string overWrite = Console.ReadLine();

                if(overWrite == "yes")
                {



                }
                File.Create(save).Close;
                File.AppendAllLines(save,variables.Item1.ToString());


                

            }
            

        }
       
        

    }
}
