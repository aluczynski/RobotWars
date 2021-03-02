using System;

namespace RobotWars

{
    public class Robot : Square
    {
        private Direction _direction;
        private char[] _commands;
        private Grid grid;

        public Robot(int x, int y, Direction direction,Grid grid)
        {
            this.x = x;
            this.y = y;
            _direction = direction;
            this.grid = grid;
        }

        public string ProcessCommands()
        {
            foreach (var command in _commands)
            {
                if (!IsNextMoveOutOfGrid(command))
                    Move(command);
            }

            string finalMessage = $"{x} {y} {_direction.ToString()}";
            return finalMessage;
        }

        private void Move(char command)
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

        private bool IsNextMoveOutOfGrid(char command)
        {
            if (command == 'M')
            {
                switch (_direction)
                {
                    case Direction.N:
                        return y >= grid.UpperY();
                    case Direction.E:
                        return x >= grid.UpperX();
                    case Direction.S:
                        return y <= 0;
                    case Direction.W:
                        return x <= 0; 
                }
            }
            return false;
        }

        public void ReadCommands(string inputCommands)
        {
            _commands = inputCommands.ToCharArray();
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