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
            - tingimuslaused ja switch-case lülitid
            - tsüklid
            - meetodid 🤌
            - klassid 🤌
            - liht ja komposiitandmetüübid
            - enum 🤌
            - castimine 🤌
            - töö failidega
            */
            bool playerAlive = true;
            Player player = new Player(100, false, string.Empty, 0, new List<string>() {"püss","nuga","Kollane taco" }, "SMenu");
            Random rng = new Random();
            do
            {
                Stages.StageSelect(player, rng);
            }
            while (playerAlive == true);



        }

    }
}
