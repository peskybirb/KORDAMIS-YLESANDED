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

        /// <summary>
        /// Abandomed concept that was supposed to show player damage but I don't have the skill nor the time to make it work correctly
        /// </summary>
        /// <param name="damage">the amount of damage the player takes in int format</param>
        public void PlayerTakesDamage(int damage)
        {
            
            if (StatEffectName == string.Empty)
            {
                Console.WriteLine($"| HP: {HP} - {damage}  | Statuseffect: none | Money: {Money} |");
                Console.Write($"| Inventory: ");
                foreach (string item in Inventory)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"| HP: {HP} - {damage} | Statuseffect: {StatEffectName} | Money: {Money} |");
                Console.Write($"| Inventory: ");
                foreach (string item in Inventory)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("\n");
            }
            Thread.Sleep(500);
            Console.Clear();
            Stats();
        }

        /// <summary>
        /// Displays the stats of the player
        /// </summary>
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

        /// <summary>
        /// Method to make the player lose hp over time and while the player can still move around the game 
        /// my way of thesting multi threading, it might not work correctly.
        /// </summary>
        public void Hot()
        {
            if (StatusEffect == true)
            {
                StatEffectName = "Hot";
                for (int i = 0; i < 5; i++)
                {
                    
                    HP -= 5;
                    Console.WriteLine("You are Hot! You lose 5 HP.");
                    Thread.Sleep(2000);
                }
                StatusEffect = false;
                StatEffectName = string.Empty;
            }
            
        }
    }
}
