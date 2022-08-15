using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    public class Sheep : Animal
    {
        public Sheep(int xLocation, int yLocation, Padock padock) : base(xLocation, yLocation, padock)
        {
            this.speed = 2;
        }

        public Sheep(Padock padock) : base(padock)
        {
            speed = 2;
        }

        /// <summary>
        /// Figures out and moves a sheep
        /// </summary>
        public void Think(int[] herdLocation)
        {

            // Find distance from herd centre

        }
    }
}
