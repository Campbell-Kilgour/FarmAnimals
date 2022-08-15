namespace FarmAnimals
{
    public class Animal
    {
        public int xLocation { get; }
        public int yLocation { get; }
        private Padock padock;
        public int speed { get; set; }

        public Animal(int xLocation, int yLocation, Padock padock)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.padock = padock;
        }

        public Animal(Padock padock)
        {
            this.padock = padock;

            Random xRand = new Random();
            Random yRand = new Random();

            // Generate random location if non is supplied
            this.xLocation = xRand.Next(padock.xSize);
            this.yLocation = yRand.Next(padock.ySize);
        }

        // The move method for an animal
        private void Move(int xDir, int yDir)
        {
            // If dir is a negative then move down or left at speed
            if (xDir < 0) //Move left
            {
                xLocation -= speed;
            }
            else if (xDir > 0) // Move Right
            {
                xLocation += speed;
            }

            if (yDir < 0) // Moves down
            {
                yLocation -= speed;
            }else if (yDir > 0) // Moves up
            {
                yLocation += speed;
            } 
        }
    }
}