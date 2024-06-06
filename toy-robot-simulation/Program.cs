// See https://aka.ms/new-console-template for more information
using toy_robot_simulation.Models;
using toy_robot_simulation.Commands;
using toy_robot_simulation.Interfaces;

Console.WriteLine("Welcome to toy-robot-simulation.....");
Console.WriteLine("Please ensure that the command.txt file exists in the below path for this program to run");
string commandFilePath = Directory.GetCurrentDirectory() + "\\command.txt";
Console.WriteLine(commandFilePath);
Console.WriteLine("Initializing the robot...");
IRobot robot = new ToyRobot();
var factory = new CommandFactory();

Console.WriteLine("Reading the commands");
var commands = File.ReadAllLines(commandFilePath);
foreach (var command in commands)
{
    var cmd = factory.CreateCommand(command);
    Console.WriteLine($"Executing {cmd.GetType().Name}...");
    cmd.Execute(robot);
}
Console.Read();
