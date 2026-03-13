using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class EventSystem
    {

        public static void NextEncounter(Player player, Random rng)
        {
            int nextEncounterInt = rng.Next(1, 6);
            switch (nextEncounterInt)
            {
                case 1:
                    Event1_Witch(player,rng);
                    break;
                case 2:
                    Event2_StrangeFigure(player,rng);
                    break;
                case 3:
                    Event3_Shop(player);
                    break;
                case 4:
                    Event4_WanderingSage(player,rng);
                    break;
                case 5:
                    Event5_AOverturnedCart(player);
                    break;
                default:
                    break;
            }
        }

        private static void Event3_Shop(Player player)
        {
            Console.Clear();
            Console.WriteLine("\nYou approach a shop, they sell Healing potions\nWould you like to buy some ?");
            string Ans2 = Console.ReadLine();
            if (Ans2 == "yes")
            {
                Console.WriteLine("\nHow many would you like to buy ?. 1 costs 2 coins");
                int Ans3 = int.Parse(Console.ReadLine());
                int vahesumma = (Ans3 * 2);
                if (vahesumma > player.Money)
                {
                    Console.WriteLine("\nnot enough coins"); 
                }
                else
                {
                    Console.WriteLine("\nyou have successfully bought " + Ans3 + " pokeballs");
                     player.Lives += Ans3;
                    player.Money -= vahesumma;
                }
            }
            else
            {    
            }
        }
        private static void Event5_AOverturnedCart(Player player)
        {
            Console.Clear();
            Console.WriteLine("You see something shiny and take a closer look \nYou found 10 coins \n\nPress enter to continue");
            Console.ReadLine();
           player.Money += 10;
        }
        private static void Event4_WanderingSage(Player player, Random rng)
        {
            Console.Clear();
            Console.WriteLine("\nSage wanders helplessly \nwill you help them out ?");
            string Ans4 = Console.ReadLine();
            if (Ans4 == "yes")
            {
                int seeJuhuarv = rng.Next(1, 5);
                Console.WriteLine("\nSage took " + seeJuhuarv + " coins and wished you luck");

                player.Money -= seeJuhuarv;
            }
            else
            {
                Console.WriteLine("\nThe sage stole 10 coins and flew away");
                player.Money -= 10;
            }
        }
        private static void Event2_StrangeFigure(Player player,Random rng)
        {
            Console.Clear();
            Console.WriteLine("\na A strange figure appears offering you a mystery bag ");
            string Ans1 = Console.ReadLine();
            if (Ans1 == "yes")
            {
                int seejuhuarv = rng.Next(-4, 4);
                if (seejuhuarv >= 0)
                {
                    Console.WriteLine("\nyou have recived extra " + seejuhuarv + " money");
                    player.Money += seejuhuarv;

                }
                else
                {
                    Console.WriteLine("\nThe figure stole " + (seejuhuarv * (-1)) + " money from you and fled");
                    player.Money -= seejuhuarv;

                }
            }

        }
        private static void Event1_Witch(Player player,Random rng)
        {
            Console.Clear();
            int seeJuhuarv = rng.Next(1, 10); //suvaline number vahemikus 1 - 10
            Console.WriteLine("\na witch appeared , guess my power to escape !!!");
            int kasutajaArv = int.Parse(Console.ReadLine()); //ootame kasutaja vastust

            if (kasutajaArv == seeJuhuarv)
            {
                Console.WriteLine("\nYou got away");
            }
            else
            {
                Console.WriteLine("\nyou lost hp");
                player.Lives -= 4;
            }
        

        }


    }

    
}
