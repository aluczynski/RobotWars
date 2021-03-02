using System;

namespace RobotWars
{

    public class Grid
    {
        private int upperX;
        private int upperY;
        public Square[,] grid; 
        
        public Grid(int upperX, int upperY)
        {
            if (upperX < 0 || upperY < 0)
            {
                throw new ArgumentException("Arena size cannot be negative");
            }

            this.upperX = upperX;
            this.upperY = upperY;
            grid = new Square[upperX,upperY];
            for (int i = 0; i < upperX; i++)
            {
                for (var j = 0; j < upperY; j++)
                {
                    grid[i, j] = new Square();
                }
            }
        }

        public int UpperX() => upperX;
        public int UpperY() => upperY;
    }
    public class Square
    {
        public int x;
        public int y;
    }
}