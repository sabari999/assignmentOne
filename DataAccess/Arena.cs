using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Arena
    {
        private const int height = 5; //fixed postition
        private const int width = 5; //fixed position

        
        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public virtual bool IsInside(Position coordinate)
        {
            if (coordinate.X < 0 || coordinate.Y < 0)
            {
                return false;
            }
            return coordinate.X < width && coordinate.Y < height;
        }
    }
}
