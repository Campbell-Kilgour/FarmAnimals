using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    public class Paddock
    {
        private int[] padockSize; // Size of padock 

        private List<Sheep> herd; // List of all sheep in Padock

        private int herdSize; // Change this to change the herd size

        // Constructor
        public Paddock(int[] padockSize, int herdSize)
        {
            this.padockSize = new int[2] { padockSize[0], padockSize[1] };

            // Adds number of sheep to padock from herdSize
            herd = new List<Sheep>();
            for (int sheepIdx = 0; sheepIdx < herdSize; sheepIdx++)
            {
                herd.Add(new Sheep(new int[2] { padockSize[0], padockSize[1] }));
            }
        }

        // Return average herd location
        public int[] GetHerdAvgLocation()
        {
            int[] location = new int[2] { 0, 0 };

            int[] totals = new int[2] { 0, 0 };

            // Finds average herd location 
            foreach (Sheep sheep in herd)
            {
                totals[0] += sheep.xLocation;
                totals[1] += sheep.yLocation;   
            }
            location[0] = totals[0] / herd.Count;
            location[1] = totals[1] / herd.Count;

            return location;
        }  
    }
}
