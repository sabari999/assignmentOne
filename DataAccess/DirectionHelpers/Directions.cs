using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   
    public abstract class Directions
    {
        protected internal abstract Position MoveForward(Position coordinate);
        protected internal abstract Directions RotateRight();
        protected internal abstract Directions RotateLeft();
    }
}