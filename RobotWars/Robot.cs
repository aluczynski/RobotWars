using System;

namespace RobotWars

{
    public class Robot : Square
    {
        private Direction _direction;
        private char[] _commands = {};
        
        public Robot(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            _direction = direction;
        }

        public string ProcessCommands(char[] commands)
        {
            foreach (var command in commands)
            {
                Move(command);
            }

            string finalMessage = $"{x} {y} {_direction.ToString()}";
            return finalMessage;
        }
        
        public void Move(char command)
        {
            switch (command)
            {
                case 'M':
                    MoveForward();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'L':
                    RotateLeft();
                    break;
            }
        }

        private void MoveForward()
        {
            switch (_direction)
            {
                case Direction.N:
                    y += 1;
                    break;
                case Direction.E:
                    x += 1;
                    break;
                case Direction.S:
                    y -= 1;
                    break;
                case Direction.W:
                    x -= 1;
                    break;
            }
        }

        private void RotateRight()
        {
            switch (_direction)
            {
                case Direction.N:
                    _direction = Direction.E;
                    break;
                case Direction.E:
                    _direction = Direction.S;
                    break;
                case Direction.S:
                    _direction = Direction.W;
                    break;
                case Direction.W:
                    _direction = Direction.N;
                    break;
            }
        }

        private void RotateLeft()
        {
            switch (_direction)
            {
                case Direction.N:
                    _direction = Direction.W;
                    break;
                case Direction.E:
                    _direction = Direction.N;
                    break;
                case Direction.S:
                    _direction = Direction.E;
                    break;
                case Direction.W:
                    _direction = Direction.S;
                    break;
            }
        }
    }
    public enum Direction
    {
        N,
        S,
        E,
        W
    }
}