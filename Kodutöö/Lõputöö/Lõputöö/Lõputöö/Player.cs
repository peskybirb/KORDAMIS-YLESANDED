using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lõputöö
{
    public class Player
    {       //siin asub player asjad
        public Player(
            int hp,
            bool stEffect,
            string stEffectName,
            double money,
            List<string> inventory,
            string stage
            )
        {
            HP = hp;
            StatusEffect = stEffect;
            StatEffectName = stEffectName;
            Money = money;
            Inventory = inventory;
            GameStage = stage;
        }
        public int HP { get; set; } = 100;
        public bool StatusEffect { get; set; } = false;
        public string StatEffectName { get; set; } = string.Empty;
        public double Money { get; set; } = 0;
        public List<string> Inventory { get; set; }
        public string GameStage { get; set; } = string.Empty;

        public void Stats()
        {
            if(StatEffectName == string.Empty)
            {
                Console.WriteLine($"| HP: {HP} | Statuseffect: none | Money: {Money} |");
                Console.Write($"| Inventory: ");
                foreach (string item in Inventory)
                {
                    Console.Write(item+", ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"| HP: {HP} | Statuseffect: {StatEffectName} | Money: {Money} |");
                Console.Write($"| Inventory: ");
                foreach (string item in Inventory)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("\n");
            }
        }
        public void Hot()
        {
            if (StatusEffect == true)
            {
                StatEffectName = "Hot";
                for (int i = 0; i < 5; i++)
                {
                    HP -= 5;
                    Console.WriteLine("You are Hot! You lose 5 HP.");
                    Thread.Sleep(20000);
                }
            }
            
        }
    }
}
