namespace Kontroll_töö
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.


            /*
              
             
            string Nimi = "";
            Console.WriteLine("Mis on sinu nimi ?");
            Nimi = Console.ReadLine();
            if (Nimi != "Nipitiri")
            {
                Console.WriteLine("Sa ei ole nipitiri, ootan vaid teda :c");
            }


            */


            //2.


            /*
              
             
            string Vastus = "";
            Console.WriteLine("Kas sulle meeldivad tulbid ?"); // lower case jah
            Vastus = Console.ReadLine();
            if (Vastus == "jah")
            {
                Console.WriteLine("Mulle kaaa");
            }
            else
            {
                Console.WriteLine("Ei saa aru sisust");
            }


            */

            /*
             
             
            // 3.


            int tundideArv = 0;
            Console.WriteLine("Mitu tundi sa see nädal mängisid?");
            tundideArv = int.Parse(Console.ReadLine());

            if (tundideArv == 0)
            {
                Console.WriteLine("Kahju et sul aega mängida pole :c");
            }
            else if (tundideArv > 0 && tundideArv < 10)
            {
                Console.WriteLine("mõõdukas mängija, Tubli");
            }            
            else if (tundideArv >= 10 && tundideArv < 20)
            {
                Console.WriteLine("Natukene paljuks läheb, kodutööd kannatavad");
            }            
            else if (tundideArv >= 20 && tundideArv < 40)
            {
                Console.WriteLine("Liiga palju mängid, kas kooli ültse jõuad?");
            }            
            else if (tundideArv > 40)
            {
                Console.WriteLine("Siin aitab ainult psühholoog");
            }


            */


            //4.


            int Skoor = 0;
            Console.WriteLine("Mis oli sinu viimatine Jalkpalli tulemus?");
            Skoor = int.Parse(Console.ReadLine());

            switch(Skoor)
            {
                case 0:
                    Console.WriteLine("PUDRUJALG OLED VÄ ?!?!");
                break;

                case 1:
                    Console.WriteLine("täitsa ok");
                break;
                    
                case 2:
                    Console.WriteLine("no see juba on parem");
                break;
                                        
                case 3:
                    Console.WriteLine("wow Messi");
                break;

                default:
                    Console.WriteLine("Ei tunne sellist skoori, see liiga suur minu jaoks");
                break;



            }
            


        }

    }
}
