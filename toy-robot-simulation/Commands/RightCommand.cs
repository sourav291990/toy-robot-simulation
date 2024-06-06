namespace toy_robot_simulation.Commands
{
    using toy_robot_simulation.Interfaces;
    internal class RightCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Right();
        }
    }
}
