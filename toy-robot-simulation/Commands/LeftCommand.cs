namespace toy_robot_simulation.Commands
{
    using toy_robot_simulation.Interfaces;
    internal class LeftCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Left();
        }
    }
}
