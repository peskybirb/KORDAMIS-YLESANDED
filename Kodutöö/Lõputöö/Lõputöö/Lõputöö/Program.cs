using Lõputöö;
namespace Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*	C	
            - oma programm, selle miinimumnõuded on:
            = koodinõuded:
            - muutujad, 🤌
            - tingimuslaused ja switch-case lülitid 🤌
            - tsüklid 🤌
            - meetodid 🤌
            - klassid 🤌
            - liht ja komposiitandmetüübid 🤌
            - enum 🤌
            - castimine 🤌
            - töö failidega 🤌

            - mul pole mangugi ja mul on koik kasutatud smh 
            - gg long asf projekt
            */
            bool playerAlive = true;
            Player player = new Player(100, false, string.Empty, 0, new List<string>() {"Phone" }, "SMenu");
            Random rng = new Random();
            do
            {
                Stages.StageSelect(player, rng);
                Console.Clear();

                if (player.HP <= 0)
                {
                    playerAlive = false;
                    Console.WriteLine("You have died. Game over.");
                }
            }
            while (playerAlive == true);

            Console.WriteLine("            --- YOU HAVE DIED ---");
            Console.ReadLine();


        }

    }
}
