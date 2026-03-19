namespace Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lisada bleeding + save game
            Random rng = new Random();
            
            string playAgain = "yes";


            //rewrite this abit from ss
            World map = new World("helloworld",new Player.Point2D(3,9), new Player.Point2D(6,8));
            Player player = new Player(3, 100, 0, new List<string>(), map.StartingPoint);

            do
            {
                Console.Clear();

                Console.WriteLine("---------------------------------------------------------");
                player.DisplayStats();
                Console.WriteLine("---------------------------------------------------------");

                bool didPlayerWin = EventSystem.CheckWin(player.PlayerLocation, map.Goal);
                if(didPlayerWin)
                {
                    return;
                }

                EventSystem.NextEncounter(player,map,rng);
                EventSystem.NextLocation(player, map);

                player.CheckHelth();

                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                if(player.Lives <= 0)
                {
                    Console.WriteLine("said surma , kas soovid uuesti mängida ?");
                    if (playAgain == "yes")
                    {
                        player.Lives = 3;
                    }


                }

            }while(player.Lives > 0 || playAgain == "yes");



            if (player.Lives > 0)
            {
                Console.WriteLine("Winner winner chicken dinner");
            }
        }
    }
    }

