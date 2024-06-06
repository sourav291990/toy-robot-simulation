using toy_robot_simulation.Models.Enums;

namespace toy_robot_simulation.Interfaces
{
    internal interface IRobot
    {
        /// <summary>
        /// put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST
        /// </summary>
        /// <param name="xAxis"></param>
        /// <param name="yAxis"></param>
        /// <param name="direction"></param>
        void Place(int xCoordinate, int yCoordinate, Direction facing);

        /// <summary>
        /// will move the toy robot one unit forward in the direction it is currently facing
        /// </summary>
        void Move();

        /// <summary>
        /// will rotate the robot 90 degrees clockwise in the specified direction without changing the position of the robot
        /// </summary>
        void Left();

        /// <summary>
        /// will rotate the robot 90 degrees anti clockwise in the specified direction without changing the position of the robot
        /// </summary>
        void Right();

        /// <summary>
        /// prints the X,Y and F of the robot
        /// </summary>
        void Report();
    }
}
