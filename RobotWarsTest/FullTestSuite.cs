using System;
using RobotWars;
using Xunit;

namespace RobotWarsTest
{
    public class RobotWarsTest
    {
        [Fact]
        public void TestWithProvidedInput()
        {
            Grid grid = new Grid(5, 5);
            Robot robotOne = new Robot(1, 2, Direction.N, grid);
            robotOne.ReadCommands("LMLMLMLMM");

            Robot robotTwo = new Robot(3, 3, Direction.E, grid);
            robotTwo.ReadCommands("MMRMMRMRRM");
            
            Assert.Equal("1 3 N",robotOne.ProcessCommands());
            Assert.Equal("5 1 E", robotTwo.ProcessCommands());
        }
    }
}