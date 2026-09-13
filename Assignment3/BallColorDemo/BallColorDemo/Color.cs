namespace BallColordemo
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        // Constructor with RGBA
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        // Constructor with RGB
        // Alpha defaults to 255
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        // Get and set Red
        public int Red
        {
            get { return red; }
            set { red = value; }
        }

        // Get and set Green
        public int Green
        {
            get { return green; }
            set { green = value; }
        }

        // Get and set Blue
        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        // Get and set Alpha
        public int Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        // Calculate grayscale value
        public int GetGrayscale()
        {
            return (red + green + blue) / 3;
        }
    }
}