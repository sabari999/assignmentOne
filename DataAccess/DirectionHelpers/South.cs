using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class South : Directions
    {
        protected internal override Position MoveForward(Position coordinate)
        {
            return new Position(coordinate.X, coordinate.Y - 1);
        }

        protected internal override Directions RotateRight()
        {
            return new West();
        }

        protected internal override Directions RotateLeft()
        {
            return new East();
        }

        public override string ToString()
        {
            return "S";
        }
    }
}