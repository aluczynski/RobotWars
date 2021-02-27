namespace RobotWars
{

    public class Grid
    {
        public Grid[,] grid; 
        
        public Grid(int upperX, int upperY)
        {
            grid = new Grid[upperX, upperY];
        }
    }
    public class Square
    {
        public int x;
        public int y;
    }
}