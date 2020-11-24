namespace DataAccess
{
    public class MoveForward : IMove
    {
        public void ExecuteOn(Robot robot, out int penalty)
        {
            robot.MoveForward(out penalty);
        }
    }
}