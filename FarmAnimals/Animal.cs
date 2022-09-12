namespace FarmAnimals
{
    public class Animal
    {
        public int xLocation { get; }
        public int yLocation { get; }
        public int speed { get; set; }

        public Animal(int xLocation, int yLocation)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
        }

        public Animal(int[] padockSize)
        {
            Random xRand = new Random();
            Random yRand = new Random();

            // Generate random location if non is supplied
            this.xLocation = xRand.Next(padockSize[0]);
            this.yLocation = yRand.Next(padockSize[1]);
        }
    }
}