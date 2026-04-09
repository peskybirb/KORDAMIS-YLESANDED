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
            Player player = new Player(100, false, string.Empty, 0, new List<string>() { "Phone" }, "");
            if (!File.Exists("AutoSave.txt"))
            {
                player.GameStage = "SMenu";
            }
            else
            {
                player.GameStage = "CMenu";
            }

            Random rng = new Random();
            
            do
            {
                Stages.StageSelect(player, rng);
                Console.Clear();

                if (player.HP <= 0)
                {
                    playerAlive = false;
                    Console.WriteLine("You have died. Game over.");
                    // unused but donsent cause problems 
                }
            }
            while (playerAlive == true);

        }
    }
}
