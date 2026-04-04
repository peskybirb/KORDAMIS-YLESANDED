using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lõputöö
{
    internal class Endings
    {
        /// <summary>
        /// Good ending to the story
        /// </summary>
        /// <param name="player">Imports player details</param>
        public static void GoodEnding(Player player)
        {
            string documentaryusrl = "https://www.youtube.com/watch?v=F3OX1PR2SCM";
            Console.WriteLine("""
                The lever works and the power is cut
                I can finally go home and rest.
                """);


            Console.Clear();

            Console.WriteLine("""
                A game inspired by the fires of California 2018

                non of the people nor companys are real and this is a work of fiction,
                any similiarity to real people or companys is purely coincidental.


                """);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("""
                CONGRATS ON FINISHING THE GAME:

                THANK YOU FOR PLAYING MY GAME, I HOPE YOU ENJOYED IT!

                >w<
                """);

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Would you want to watch a documentary about the fires ?");
            string watchdoc = Stages.Userinput(player);
            if (watchdoc == "yes")
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = documentaryusrl,
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("Have a nice day!");
            }
            Console.WriteLine("You will return to Main menu now");
            Console.ReadLine();
            player.GameStage = "SMenu";
        }

        /// <summary>
        /// The bad ending that happens at the hospital where we left off at EscapeChp2
        /// Player obtains keyItem "Security keycard"
        /// </summary>
        /// <param name="player">Imports player details</param>
        public static void BadEnding1(Player player)
        {
            
            Console.WriteLine("""
                I enter the Hospital and look around to see noone there.
                
                I find a Security keycard on the table and take it 
                """);
            player.Inventory.Add("Keycard");
            Console.ReadLine();
            Console.Clear();
            player.Stats();
            Console.WriteLine("""
                SUDDENLY!!
                The floor above the entrance collapses down blocking my exit.
                I run around the hospital to find anoter unblocked exit but there none.
                """);
            Console.ReadLine();
            Console.Clear();
            player.Stats();
            Console.WriteLine("The smoke fills my lungs and I fall unconscious");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("""
                You got the Bad ending #1

                Keep playing the get the other endings!
                """);
            player.GameStage = "Beginning";
            player.Money = 0;
            player.StatEffectName = string.Empty;
            player.StatusEffect = false;

        }

        /// <summary>
        /// The bad ending 2 to the story which happens at the end of the game 
        /// player obtains keyItem "Spare lever"
        /// </summary>
        /// <param name="player"></param>
        public static void BadEnding2(Player player)
        {
            Console.WriteLine("""
                I make it out of the city but all the city is burned down
                there is absolutly nothing left of it.

                I find a small Lever in the Strangers car I ask nicely
                and they let me keep it as a memory of the city and the people I met there.
                """);
            player.Inventory.Add("Spare lever");
            player.GameStage = "Beginning";
            player.Money = 0;
            player.StatEffectName = string.Empty;
            player.StatusEffect = false;
            Console.WriteLine("""
                You got the Bad ending #2

                Keep playing the get the other endings!

                """);
            Console.WriteLine("You will be sent back to the beginning now (press enter)");
            Console.ReadLine();
        }


    }
}
