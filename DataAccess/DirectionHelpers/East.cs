using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class East : Directions
    {
        protected internal override Position MoveForward(Position Position)
        {
            return new Position(Position.X + 1, Position.Y);
        }

        protected internal override Directions RotateRight()
        {
            return new South();
        }

        protected internal override Directions RotateLeft()
        {
            return new North();
        }

        public override string ToString()
        {
            return "E";
        }
    }
}