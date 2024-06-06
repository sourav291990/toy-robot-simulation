
namespace toy_robot_simulation.Commands
{
    using toy_robot_simulation.Models;
    using toy_robot_simulation.Interfaces;
    internal class MoveCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Move();
        }
    }
}
