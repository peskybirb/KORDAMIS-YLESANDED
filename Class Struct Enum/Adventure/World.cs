using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Adventure.Player;

namespace Adventure
{
    internal class World
    {

        int[,] Map {  get; set; }
        string WorldName { get; set; }
        Point2D StartingPoint { get; set; }
        Point2D Goal {  get; set; }

        /// <summary>
        /// Constructor for default world, with the size of 10x10
        /// </summary>
        /// <param name="thisWorldName">Name for this world</param>
        /// <param name="start"></param>
        /// <param name="end"></param>

        public World(int[,] thisMap,string thisWorldName , Point2D start , Point2D end) 
        {
            Map = NewMap(10,5);
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }
        
        /// <summary>
        /// Constructor for default world, with the size of 10x10
        /// </summary>
        /// <param name="thisMap">2d array fpr the map of the world, contains integer that represents different worlds</param>
        /// <param name="thisWorldName">Name for this world</param>
        /// <param name="start"></param>
        /// <param name="end"></param>

        public World(string thisWorldName , Point2D start , Point2D end) 
        {
            Map = NewMap(10,5);
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }
        /// <summary>
        /// Method to generate a new map  randomly
        /// </summary>
        /// <param name="size">the size of the map , both x and y integers</param>
        /// <param name="maxEventInteger">the integer id of the las possible even to put in the array</param>
        /// <returns>new generated map</returns>
        private int[,] NewMap(int size, int maxEventInteger)
        {
            int[,] newmap = new int[size, 10];
            Random rng = new Random();
            for(int i = 0; i < size;i++)
            {

                for(int j = 0;j < size;j++)
                {
                    newmap[i, j] = rng.Next(1, maxEventInteger + 1);
                }

            }


            return newmap;
        }
    }

}

