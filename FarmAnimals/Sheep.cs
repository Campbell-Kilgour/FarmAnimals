using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    public class Sheep : Animal
    {
        public int XLocation { get; }
        public int YLocation { get; }

        private int speed = 5; // Change this to change max speed of sheep

        public Sheep(int xLocation, int yLocation) : base(xLocation, yLocation)
        {
        }

        public Sheep(int[] padockSize) : base(padockSize)
        {
            // Generates a random location for sheep
            Random random = new Random();


        }

        /// <summary>
        /// Takes input and returns a new sheep location 
        /// </summary>
        public void Think(int[] herdLocation)
        {

            // Find distance from herd centre

        }
    }
}
