using Adventure.Enemys;
using static Adventure.Enemys.BaseEnemy;
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
            World map = new World("helloworld", new Player.Point2D(3, 9), new Player.Point2D(6, 8));
            Player player = new Player(3, 100, 0, new List<string>(), map.StartingPoint);

            List<BaseEnemy> enemies = new List<BaseEnemy>()
            { 
                new BaseEnemy("Small skeleton", 4, 1, "clink clank clank - clack", 1),
                new BaseEnemy("Malfunctioning Robot", 10, 1, "Beep boop fuck you ", 1),
                new BaseEnemy("Borat", 7, 1, "aee what's up vanilla face", 1)
            };


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

