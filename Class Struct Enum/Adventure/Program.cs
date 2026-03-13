namespace Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lisada bleeding + save game
            Random rng = new Random();
            Player player = new Player(3 ,100 ,0 , new List<string>(), new Player.Point2D(0, 0));
            string playAgain = "yes";

            do
            {
                Console.Clear();
                player.DisplayStats();
                EventSystem.NextEncounter(player, rng);
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

            
            

            
        }
    }
    }

