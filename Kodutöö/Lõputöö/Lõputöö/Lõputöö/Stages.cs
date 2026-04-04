using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// Beginnig ✅
// Fire starts 
// Escape chp 1
// Escape chp 2
// Escape chp 3
// Escape chp 4
// Final escape

// Good ending
// Bad ending 1
// Bad ending 2
namespace Lõputöö
{
    public class Stages
    {
        public enum StageNames
        {
            GoodEnding, BadEnding1, BadEnding2, Beginning, FireStart, EscapeChp1, EscapeChp2, EscapeChp3, EscapeChp4, FinalEscape, SMenu, Save, Load, Exit, FinalWords
        }

        /// <summary>
        /// The saving feature , it saves the game and exits the game after that.
        /// </summary>
        /// <param name="player">imports player details to be saved</param>
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
                else
                {
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

        /// <summary>
        /// Looks at the player gameStage and places the player in the corresponding stage method so the game can continue.
        /// </summary>
        /// <param name="player">imports player details</param>
        /// <param name="rng">imports a random in case it is needed in one of the stages</param>
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
                    FireStart(player);

                    break;

                case nameof(StageNames.EscapeChp1):
                    Console.Clear();
                    player.Stats();
                    EscapeChp1(player,rng);

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

        public static string JumpCheck(Player player,Random rng)
        {
            int userimp = 0;
            do
            {
                Console.Clear();
                player.Stats();
                Console.WriteLine("The road ahead of me is on fire \nHow much runway should I get to jump over the fire ? (1m-10m)");
                userimp = int.Parse(Userinput(player));

            } while (userimp >= 10 && userimp < 0);

            int fallinornah = rng.Next(1,100);

            switch(userimp.ToString()) 
            {
                  case "1":
                    player.HP -= 70;
                    return "OHHH nooo nnonoon burns burns burrrnnnssssss";
                    
                    break;

                  case "2":

                    if (fallinornah >= 20)
                    {
                        return "Phew that was close but I made it";

                    }
                    else
                    {
                        player.HP -= 32;
                        return "Ou ou ou ou this burns";
                    }

                    break;

                  case "3":
                    player.HP -= 10;
                    return "eeaaeaa mm I burnt the hairs off my legs";

                  break;

                  case "4":

                    return "Phew that was close but I made it";

                  break;
                        
                  case "5":

                    return "Phew that was close but I made it";
                     
                    break;

                  case "6":

                    return "This was closer my legs almost gave out at the last step but I made it";

                  break;

                  case "7":
                    player.HP -= 8;
                    return "*Panting* I almost fell in, too long runway";

                  break;

                  case "8":

                    if (fallinornah >= 50)
                    {
                        return "Phew that was close but I made it";

                    }
                    else
                    {
                        player.HP -= 43;
                        return "OHHH nooo nnonoon burns burns burrrnnnssssss";
                    }
                  break;

                  case "9":

                    if (fallinornah >= 75)
                    {
                        return "Phew that was close but I made it";

                    }
                    else
                    {
                        player.HP -= 69;
                        return "OHHH nooo nnonoon burns burns burrrnnnssssss";
                    }

                        break;
                    
                  case "10":

                    player.HP -= 97;
                    return "NONONONOONO TOO LONG RUNWAY I TRIPPED AND FELL IN THE FIRE OHHH NOOOO";

                  break;
                    default:
                        return "Phew that was close but I made it";
                    break;
            }
        }

        /// <summary>
        /// Loads savedata from the SaveGame.txt file and put it into the player class so it can be used in the game.
        /// </summary>
        /// <param name="player">imports player details to change them</param>
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
                if (statEffectName == string.Empty)
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

        /// <summary>
        /// Gets user iput and also checks if te user wants the exit the game.imports player cuz it might need to forward the data to the save function.
        /// </summary>
        /// <param name="player">imports player </param>
        /// <returns></returns>
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

        /// <summary>
        /// The start menu where u can start a new game , load game or exit
        /// </summary>
        /// <param name="player">loads in the player details from the player class</param>
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

        /// <summary>
        /// Beginning of the game has the story intro and the first ending branch which requires 2 keyitems that are obtained from both bad endings.
        /// </summary>
        /// <param name="player">imports the player detains</param>
        public static void Beginning(Player player)
        {
            Console.WriteLine("P.S. if you are done reading the text press enter");
            Console.ReadLine();
            Console.Clear();
            player.Stats();
            Console.WriteLine("Hmm.. it's quite hot outside today\nI wonder how hot is it outside");
            Console.WriteLine("Check weather ? yes/no");
            string userinp = Userinput(player);
            if (userinp == "yes")
            {
                Console.WriteLine("I open the weather app on my phone");
                Console.WriteLine("""
                    date: 10.08.2018
                    Temperature: 57F
                    Humidity: 19%
                    Wind Speed: 45mph

                    Warning: High risk of fire today, avoid open flames and be cautious when outdoors.
                    """);
                Console.ReadLine();
            }
            Console.WriteLine("Boss: hey I know you have to leave early today but could you\nmaybe turn off the electricity tower on the line 27.\nNot nessesary so if you can't its fine I'll just do it tomorrow");
            Console.ReadLine();
            if (!player.Inventory.Contains("Keycard"))
            {
                Console.WriteLine("Sorry boss I dont have the Keycard on me at the moment");
                Console.ReadLine();
            }
            else if (player.Inventory.Contains("Keycard"))
            {
                Console.WriteLine("I'll see what I can do");
                Console.WriteLine("I enter the control room with the keycard and see the lever to turn off the electricity tower");
                Console.WriteLine("Pull it ? yes/no");
                userinp = Userinput(player);
                if (userinp == "yes")
                {
                    Console.WriteLine("I pull the lever but it braks off clean");
                    if (player.Inventory.Contains("Spare lever"))
                    {
                        Console.WriteLine("Thank god I came prepared");
                        Console.ReadLine();
                        player.GameStage = nameof(StageNames.GoodEnding);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("OHH SHI this is bad let's just hope noone notices");
                        Console.ReadLine();
                        player.GameStage = nameof(StageNames.FireStart);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("I decide to not pull the lever since it looked abit broken");
                    Console.ReadLine();
                    player.GameStage = nameof(StageNames.FireStart);
                    return;
                }

            }

            Console.WriteLine("Boss: it's alright I'll turn it off tomorrow then");
            Console.ReadLine();
            player.GameStage = nameof(StageNames.FireStart);
        }

        /// <summary>
        /// Asks the user if they want to exit the game or nah, tbh I dont think I used this anywhere bit it exists so I'll still comment it.
        /// </summary>
        /// <param name="player">immports player details</param>
        public static void Exit(Player player)
        {
            string userinp = string.Empty;
            do
            {

                Console.WriteLine("would you like to save before exiting ?");
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
                    Exit(player);
                }
            }
            while (userinp == "yes" && userinp == "no");
        }

        /// <summary>
        /// Start of the so called Chapter 2 of the whole story where you get a few choices that affect the later gameplay rather short overall.
        /// </summary>
        /// <param name="player">imports player details</param>
        public static void FireStart(Player player)
        {
            string userinp = string.Empty;
            Console.WriteLine("Mmmm... I should get up from bed its 7.10am already");
            Console.ReadLine();
            Console.WriteLine("a steaming coffee would be nice on my one free day off\n");
            Console.ReadLine();
            Console.WriteLine("I get up drowsy in PJ's go to my kitchen and make myself a coffee\n");
            Console.ReadLine();
            Console.WriteLine("What the hell is that *There seems to be a massive smoke cloud about 5 miles away*");
            Console.WriteLine("Report fire ? yes/no");
            userinp = Userinput(player);
            if (userinp == "yes")
            {
                Console.WriteLine("*I take my phone and call 911*");
                Console.WriteLine("""
                    911 > 911, what's your emergency ?
                    me  > Hello, I would like to report a fire about 5 miles away from #$@!@.
                    911 > Can you give us more details about the fire ?
                    me  > Sure, its coming from the north side of the city.
                    911 > Ok we're on it , but currentl there is no danger to #$@!@.
                    me  > Alright, thank you.
                    """);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I wonder if I can see what's going on in the news");
                Console.WriteLine("*I slump down onto the sofa and check the news*");
                Console.ReadLine();
                Console.WriteLine("""
                    Channel 1 news > Buy this vaccume cleaner NOW! it sucks.
                    Channel 2 news > Snakes don't have eyelids. If you see a snake blink, that's a legless lizard.
                    Channel 3 news > Squidgame now in Hindian language, watch it now on Channel 3.
                    Cartoon Network > New episode of Spongebob Squarepants coming out in 5 minutes, stay tuned.
                    """);
                Console.ReadLine();
                Console.WriteLine("I guess they got it under control");
                Console.ReadLine();

            }
            Console.WriteLine("Do I pack my things just incase ?");
            userinp = Userinput(player);
            if (userinp == "yes")
            {
                Console.WriteLine("I m gonna need my money, Clothes and let's add a water bottle too");
                player.Inventory.Add("Clothes");
                player.Inventory.Add("Water bottle");
                player.Money = 2762.64;
                Console.ReadLine();
                player.GameStage = nameof(StageNames.EscapeChp1);
            }
            else
            {
                Console.WriteLine("Nah why should I they got it under control");
                Console.ReadLine();
                player.GameStage = nameof(StageNames.EscapeChp1);
            }

        }

        /// <summary>
        /// this is the Escape chapter 1 where ou have a choice to go by car or walk both have their own consequences and first place where player might actully die.
        /// </summary>
        /// <param name="player">imports player details</param>
        /// <param name="rng">imports random for the rng choice</param>
        public static void EscapeChp1(Player player,Random rng)
        {

            string userinp = string.Empty;
            string Choice1 = string.Empty;
            Console.WriteLine("Ohh a notification, maybe she replied to me finally\n");
            Console.ReadLine();
            Console.WriteLine("""
                EMERGANCY ALERT:
                A large fire has enveloped the city  perimeter
                a city wide evacuation has been ordered, please
                follow the emergency evacuation routes and stay safe.
                """);
            Console.ReadLine();
            Console.WriteLine("I should really get moving. The sky is so orange from the fire");
            Console.ReadLine();
            do
            {
                Console.Clear();
                player.Stats();
                do
                {
                    Console.WriteLine("should I go by car or walk tho ? car/walk");
                    userinp = Userinput(player);
                    if (userinp == "car")
                    {
                        CarRoute(player);
                    }
                    else if (userinp == "walk")
                    {
                        WalkRoute(player,rng);
                    }
                    else
                    {
                        Console.WriteLine("I can't do that (press enter twice)");
                    }
                } while (userinp == "walk" && userinp == "car");


            } while (Userinput(player) != "car" && Userinput(player) != "walk");

            player.GameStage = nameof(StageNames.EscapeChp2);
            //next chapters gonna be short af cuz this took way too much time.
        }

        /// <summary>
        /// A method for the EscapeChp1 cause it was really painful making it all in 1 method
        /// </summary>
        /// <param name="player">Imports player details</param>
        public static void CarRoute(Player player)
        {
            Console.WriteLine("I get in my car and start driving away");
            Console.ReadLine();
            Console.WriteLine("Suddenly a burning tree falls on my car");
            player.HP -= 33;
            Console.ReadLine();
            Console.Clear();
            player.Stats();
            Console.WriteLine("I manage to make it out but I notice my clothes are burnt");
            if (player.Inventory.Contains("Water bottle"))
            {
                Console.WriteLine("Do I pour it on me to cool down ? yes/no");
                string Choice1 = Userinput(player);
                if (Choice1 == "yes")
                {
                    Console.WriteLine("This feels so nice");
                }
                else
                {
                    player.StatusEffect = true;
                    player.StatEffectName = "Hot";
                    // https://www.youtube.com/watch?v=rUbmW4qAh8w <--- koht kus sain idee selle jaoks  
                    Thread Thread2 = new Thread(player.Hot);
                    Thread2.Start();
                }
            }

        }

        /// <summary>
        /// same as CarRoute but for the walking route, also has a choice in the middle that can lead to taking some damage.
        /// </summary>
        /// <param name="player">import player details</param>
        /// <param name="rng">to forward it to the Jumpcheck</param>
        public static void WalkRoute(Player player, Random rng)
        {
            string userinp = string.Empty;
            Console.Clear();
            player.Stats();
            Console.WriteLine("it seems the more dangerous option but I think its the best");
            Console.ReadLine();
            Console.WriteLine("Holy shi- the fire has evolved so much already everything is burning");
            Console.ReadLine();
            string textoutput = JumpCheck(player,rng);
            Console.WriteLine(textoutput);
        }

        /// <summary>
        /// First Bad ending choice wher eu can either go to the hospital(bad) or move faster towards the exit(good)
        /// </summary>
        /// <param name="player">Imports player data to change data</param>
        public static void EscapeChp2(Player player)
        {
            string userinp = string.Empty;
            Console.WriteLine("I manage to get out of the worst zone, the fire is behind me");
            Console.ReadLine();
            Console.WriteLine("It's so dam unclear here there is ash floating around everywhere");
            Console.ReadLine();
            do
            {
                Console.WriteLine("Omgg it's the hospital, maybe there is someone there to help me\nShould I go to check ? yes/no");
                userinp = Userinput(player);
                if (userinp == "yes")
                {
                    Console.WriteLine("let's see if there is anyone around");
                    player.GameStage = nameof(StageNames.BadEnding1);
                }
                else
                {
                    Console.WriteLine("I bet everyone already evacuated I should just keep moving");
                    player.GameStage = nameof(StageNames.EscapeChp3);
                }
            } while (userinp == "yes" && userinp == "no");
        }
    }
}

