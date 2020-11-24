using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class North : Directions
    {
        protected internal override Position MoveForward(Position coordinate)
        {
            return new Position(coordinate.X, coordinate.Y + 1);
        }

        protected internal override Directions RotateRight()
        {
            return new East();
        }

        protected internal override Directions RotateLeft()
        {
            return new West();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}