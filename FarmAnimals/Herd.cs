using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    
    /// <summary>
    /// A herd is a group a sheep
    /// </summary>
    public class Herd
    {
        private List<Sheep> herd;

        public Herd(int numOfSheep, Padock padock)
        {
            herd = new List<Sheep>();

            for (int sheepIdx = 0; sheepIdx < numOfSheep; sheepIdx++)
            {
                herd.Add(new Sheep(padock));
            }
        }

        /// <summary>
        /// Returns average location of the herd
        /// </summary>
        /// <returns></returns>
        public float[] HerdLocation()
        {
            float[] location = new float[2];

            int xTotal = 0;
            int yTotal = 0;

            for(int sheepIdx = 0; sheepIdx < herd.Count; sheepIdx++)
            {
                xTotal += herd[sheepIdx].xLocation;
                yTotal += herd[sheepIdx].yLocation;
            }

            location[0] = xTotal / herd.Count;
            location[1] = yTotal / herd.Count;   

            return location;
        }
    }
}
