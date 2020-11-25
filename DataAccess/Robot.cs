namespace DataAccess
{
    public class Robot
    {
        private readonly Arena arena;
        private Directions direction;
        private Position position;

        public Robot(Position position, Directions direction, Arena arena)
        {
            this.position = position;
            this.direction = direction;
            this.arena = new Arena();
        }

        public Position Coordinate
        {
            get { return position.Clone(); }
        }

        public Directions Direction
        {
            get { return direction; }
        }

        public virtual void RotateLeft()
        {
            direction = direction.RotateLeft();
        }

        public virtual void RotateRight()
        {
            direction = direction.RotateRight();
        }

        public virtual void MoveForward11(out int penalty)
        {
            penalty = 0;
            Position newRobotPosition = direction.MoveForward(position);
            //if (!arena.IsInside(newRobotPosition))
            //{
            //    //need to implement fine
            //}
            if (newRobotPosition.X < 0 || newRobotPosition.Y < 0)
            {
                penalty = 1;
            }

            position = newRobotPosition;
        }

        public virtual int MoveForward1()
        {
            Position newRobotPosition = direction.MoveForward(position);
            //if (!arena.IsInside(newRobotPosition))
            //{
            //    //need to implement fine
            //}

            int collision = 0;
            if (position.X < 0 || position.Y < 0)
            {
                collision = 1;
            }

            position = newRobotPosition;

            return collision;
        }

        public virtual int MoveForward(out int penalty)
        {
            penalty = 0;
            Position newRobotPosition = direction.MoveForward(position);
            if (!arena.IsInside(newRobotPosition))
            {
                penalty = 1;
            }

            newRobotPosition.X = newRobotPosition.X >= 5 ? newRobotPosition.X - 1 : newRobotPosition.X < 0 ? newRobotPosition.X + 1 : newRobotPosition.X;
            newRobotPosition.Y = newRobotPosition.Y >= 5 ? newRobotPosition.Y - 1 : newRobotPosition.Y < 0 ? newRobotPosition.Y +1 : newRobotPosition.Y;

            position = newRobotPosition;

            return penalty;
        }

    }
}
