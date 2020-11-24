namespace DataAccess
{
    public class MoveLeft : IMove
    {
        public void ExecuteOn(Robot robot, out int penalty)
        {
            robot.RotateLeft();
            penalty = 0;
        }
    }
}