using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        public struct Location
        {
            public Location(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int? X { get; set; } = 0;
            public int? Y { get; set; } = 0;

        }

        public Player(
            int lives,
            int health,
            int money,
            List<string> backpack,
            Location playerLocation
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
        public Location PlayerLocation { get; set; }

    }
}
