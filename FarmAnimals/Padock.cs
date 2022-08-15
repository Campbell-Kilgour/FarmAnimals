using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{

    public class Padock
    {
        public int xSize { get; set; }
        public int ySize { get; set; }

        public Padock(int xSize, int ySize)
        {

            this.xSize = xSize; 
            this.ySize = ySize;

        }
    }
}
