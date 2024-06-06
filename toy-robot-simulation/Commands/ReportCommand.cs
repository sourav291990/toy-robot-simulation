namespace toy_robot_simulation.Commands
{
    using toy_robot_simulation.Interfaces;
    internal class ReportCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Report();
        }
    }
}
