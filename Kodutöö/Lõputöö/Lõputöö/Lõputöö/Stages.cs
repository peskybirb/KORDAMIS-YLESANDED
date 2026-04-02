using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lõputöö
{
    public class Stages
    {
        public enum StageNames
        {
            GoodEnding, BadEnding1, BadEnding2, Beginning, FireStart, EscapeChp1, EscapeChp2, EscapeChp3, EscapeChp4, FinalEscape, SMenu, Save, Load
        }

        public static void StageSelect(Player player, Random rng)
        {


            switch(player.GameStage)
            {
                case nameof(StageNames.Beginning):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.FireStart):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.EscapeChp1):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.EscapeChp2):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.EscapeChp3):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.EscapeChp4):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.FinalEscape):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.GoodEnding):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.BadEnding1):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.BadEnding2):
                    Console.Clear();
                    player.Stats();


                    break;

                case nameof(StageNames.SMenu):
                    Console.Clear();
                    SMenu(player);

                    //Start Menu
                    break;

                case nameof(StageNames.Load):
                    Console.Clear();
                    

                    //Loading
                    break;

                case nameof(StageNames.Save):
                    Console.Clear();


                    //Saving
                    break;
            }
            

        }
        public static string Userinput(Player player)
        {
            //userinput so it can always exit 
            string userinp = Console.ReadLine();
            if (userinp == "exit")
            {
                player.GameStage = nameof(StageNames.SMenu);
                SMenu(player);
                return "EXIT";
            }
            else
            {
                return userinp.ToLower();
                
            }
        }
        public static void SMenu(Player player)
        {
            string UserInput = string.Empty;
            do
            {
                Console.WriteLine("""
                 ---------------
                | MAIN MENU:    |
                |               |
                | 1.New Game    |
                | 2.Load Game   |
                | 3.Exit        |
                 ---------------
                """);
                UserInput = Userinput(player);

                if (UserInput == "1")
                {
                    player.GameStage = nameof(StageNames.Beginning);
                }
                else if (UserInput == "2")
                {
                    player.GameStage = nameof(StageNames.Load);
                }
                else if (UserInput == "3")
                {
                    //meetod et saada välja mängust
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input !");
                    Thread.Sleep(500);
                }
            }
            while (UserInput == "1" || UserInput == "2" || UserInput == "3");
        }

        public static void Beginning(Player player)
        {
            





            
        }

    }
}
