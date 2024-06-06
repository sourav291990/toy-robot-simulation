namespace toy_robot_simulation.Commands
{
    using toy_robot_simulation.Interfaces;
    using toy_robot_simulation.Models.Enums;

    internal class PlaceCommand(int x, int y, Direction facing) : ICommand
    {
        private readonly int _x = x;
        private readonly int _y = y;
        private readonly Direction _facing = facing;

        public void Execute(IRobot robot)
        {
            robot.Place(_x, _y, _facing);
        }
    }
}
