using System;
using System.Collections;
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
            GoodEnding, BadEnding1, BadEnding2, Beginning, FireStart, EscapeChp1, EscapeChp2, EscapeChp3, EscapeChp4, FinalEscape, SMenu, Save, Load, Exit
        }

        public static void Save(Player player)

        {
            string saveName = "SaveGame.txt";
            if (File.Exists(saveName))
            {
                Console.WriteLine("Save data was found \ndo you want to overwrite it ?");
                string userInpt = Console.ReadLine();
                if (userInpt == "yes")
                {
                    File.Create(saveName).Close();
                    File.AppendAllText(saveName, player.HP.ToString() + "\n");
                    File.AppendAllText(saveName, player.Money.ToString() + "\n");
                    File.AppendAllText(saveName, player.StatEffectName.ToString() + "\n");
                    File.AppendAllText(saveName, player.GameStage.ToString() + "\n");
                    File.AppendAllText(saveName, string.Join(",", player.Inventory));

                    Console.WriteLine("save successful !");
                    Thread.Sleep(1000);

                    Environment.Exit(0);

                }
                else if (userInpt == "no")
                {
                    Environment.Exit(0);
                }
                else                 {
                    Console.WriteLine("invalid input !");
                    Save(player);
                }



            }
            else
            {
                
                File.Create(saveName).Close();
                File.AppendAllText(saveName, player.HP.ToString() + "\n");
                File.AppendAllText(saveName, player.Money.ToString() + "\n");
                File.AppendAllText(saveName, player.StatEffectName.ToString() + "\n");
                File.AppendAllText(saveName, player.GameStage.ToString() + "\n");
                File.AppendAllText(saveName, string.Join(",", player.Inventory));

                Console.WriteLine("save successful !");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

        public static void StageSelect(Player player, Random rng)
        {


            switch (player.GameStage)
            {
                case nameof(StageNames.Beginning):
                    Console.Clear();
                    player.Stats();
                    Beginning(player);

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
                    Load(player);

                    //Loading
                    break;

                case nameof(StageNames.Save):
                    Console.Clear();
                    Save(player);

                    //Saving
                    break;

                case nameof(StageNames.Exit):
                    Console.Clear();


                    //Exiting
                    break;
                default:
                    Console.WriteLine("gg bro game might be bit broke\nhope that the save was not so long ago");
                    break;
            }


        }

        public static void Load(Player player)
        {
            string saveName = "SaveGame.txt";
            if (File.Exists(saveName))
            {
                string[] saveData = File.ReadAllLines(saveName);

                int hp = int.Parse(saveData[0]);
                double money = double.Parse(saveData[1]);
                string statEffectName = saveData[2];
                string gameStage = saveData[3];
                List<string> inventory = saveData[4].Split(',').ToList();

                player.HP = hp;
                player.Money = money;
                player.StatEffectName = statEffectName;
                if(statEffectName == string.Empty)
                {
                    player.StatusEffect = false;
                }
                else
                {
                    player.StatusEffect = true;
                }

                player.GameStage = gameStage;
                player.Inventory = inventory;

                Console.WriteLine($"HP: {hp}");
                Thread.Sleep(300);
                Console.WriteLine($"Money: {money}");
                Thread.Sleep(300);
                if (statEffectName == string.Empty)
                {
                    Console.WriteLine($"Staus Effect: none");
                }
                else
                {
                    Console.WriteLine($"Status Effect: {statEffectName}");
                }
                Thread.Sleep(300);
                Console.WriteLine($"GameStage: {gameStage}");
                Thread.Sleep(300);
                foreach (string item in inventory)
                {
                    Console.WriteLine($"Item: {item}");
                    Thread.Sleep(150);
                }


                //load into the player` 
                Console.WriteLine("Load successful !");
                Thread.Sleep(1000);
                
            }
            else
            {
                Console.WriteLine("No save data found !");
                player.GameStage = nameof(StageNames.SMenu);
                Thread.Sleep(1000);
                
            }
        }

        public static string Userinput(Player player)
        {
            //userinput so it can always exit 
            string userinp = Console.ReadLine();
            if (userinp == "exit")
            {

                do
                {
                    Console.WriteLine("Would you like the save before exiting ?");
                    userinp = Console.ReadLine();
                    if (userinp == "yes")
                    {
                        Save(player);
                    }
                    else if (userinp == "no")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("invalid input !");
                    }
                    return "EXIT";
                } while (userinp == "yes" || userinp == "no");

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
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input !");
                    Thread.Sleep(500);
                }
            }
            while (UserInput == "1" && UserInput == "2" && UserInput == "3");
        }

        public static void Beginning(Player player)
        {
            Console.WriteLine("ur at the start of the game");
            
            string inputTest = Userinput(player);
            Thread.Sleep(1000);



        }

        public static void Exit(Player player)
        {
            string userinp = string.Empty;
            do
            {

                Console.WriteLine("would you like to save before exiting ?");
                userinp = Console.ReadLine();
                if (userinp == "yes")
                {

                }
                else if (userinp == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("invalid input !");
                    Exit(player);
                }
            } 
            while (userinp == "yes" && userinp == "no");
        }
    }
}

