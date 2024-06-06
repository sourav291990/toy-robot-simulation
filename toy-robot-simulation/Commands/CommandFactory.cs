using toy_robot_simulation.Interfaces;
using toy_robot_simulation.Models.Enums;

namespace toy_robot_simulation.Commands
{
    internal class CommandFactory
    {
        public CommandFactory() { }
        public ICommand CreateCommand(string command)
        {
            var commandParts = command.Split(' ', ',');
            switch (commandParts[0].ToLowerInvariant())
            {
                case "place":
                    return new PlaceCommand(Convert.ToInt16(commandParts[1]), Convert.ToInt16(commandParts[2]), Enum.Parse<Direction>(commandParts[3].ToUpperInvariant()));
                case "move":
                    return new MoveCommand();
                case "left":
                    return new LeftCommand();
                case "right":
                    return new RightCommand();
                case "report":
                    return new ReportCommand();
                default:
                    throw new ArgumentException("Invalid command supplied...");
            }
        }
    }
}
