namespace BallColordemo
{
    public class Ball
    {
        private int size;
        private Color color;
        private int throwCount;

        // Constructor
        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            this.throwCount = 0;
        }

        // Pop the ball
        public void Pop()
        {
            size = 0;
        }

        // Throw the ball
        public void Throw()
        {
            // Only increase count if ball has not been popped
            if (size != 0)
            {
                throwCount++;
            }
        }

        // Return number of throws
        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}