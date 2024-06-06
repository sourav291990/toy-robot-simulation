namespace toy_robot_simulation.Models
{
    using toy_robot_simulation.Interfaces;
    using toy_robot_simulation.Models.Enums;
    internal class ToyRobot : IRobot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }


        public void Place(int xCoordinate, int yCoordinate, Direction facing)
        {
            if (xCoordinate < 0 || xCoordinate > 4)
            {
                Console.WriteLine($"Cannot place to {xCoordinate} in X-Axis");
                return;
            }
            if (yCoordinate < 0 || yCoordinate > 4)
            {
                Console.WriteLine($"Cannot place to {yCoordinate} in Y-Axis");
                return;
            }
            X = xCoordinate;
            Y = yCoordinate;
            Facing = facing;
        }

        public void Move()
        {
            switch (Facing)
            {
                case Direction.NORTH:
                    if (Y < 4)
                        Y++;
                    break;
                case Direction.SOUTH:
                    if (Y > 0)
                        Y++;
                    break;
                case Direction.EAST:
                    if (X > 0)
                        X++;
                    break;
                case Direction.WEST:
                    if (X > 0)
                        X++;
                    break;
            }
        }

        public void Left()
        {
            if (Facing == Direction.NORTH)
            {
                Facing = Direction.WEST;
            }
            else
            {
                Facing--;
            }
        }

        public void Right()
        {
            if (Facing == Direction.WEST)
            {
                Facing = Direction.NORTH;
            }
            else
            {
                Facing++;
            }
        }
        public void Report()
        {
            Console.WriteLine($"{X} {Y} {Facing}");
        }

    }
}
