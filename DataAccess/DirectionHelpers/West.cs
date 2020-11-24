using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class West : Directions
    {
        protected internal override Position MoveForward(Position coordinate)
        {
            return new Position(coordinate.X - 1, coordinate.Y);
        }

        protected internal override Directions RotateRight()
        {
            return new North();
        }

        protected internal override Directions RotateLeft()
        {
            return new South();
        }

        public override string ToString()
        {
            return "W";
        }
    }
}