using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class MoveRight : IMove
    {
        public void ExecuteOn(Robot robot, out int penalty)
        {
            robot.RotateRight();
            penalty = 0;
        }
    }
}