using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        public struct Point2D
        {
            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int? X { get; set; } = 0;
            public int? Y { get; set; } = 0;

            public override string ToString()
            {
                return $"{X} , {Y}";
            }

        }

        public Player(
            int lives,
            int health,
            int money,
            List<string> backpack,
            Point2D playerLocation
            )
        {
            Lives = lives;
            Heatlh = health;
            Money = money;
            Backpack = backpack;
            PlayerLocation = playerLocation;
        }
        public int? Lives { get; set; } = 3;
        public int? Heatlh { get; set; } = 100;
        public int Money { get; set; }
        public List<string> Backpack { get; set; }
        public Point2D PlayerLocation { get; set; }

        internal void DisplayStats()
        {
            Console.WriteLine($"Lives remaining: {Lives}\nHealth remaining: {Heatlh}\nMoney left: {Money}");
        }
        public void CheckHelth()
        {
            if(Heatlh <= 0)
            {
                Lives--;
                Heatlh = 100;
            }


        }
    }
}
