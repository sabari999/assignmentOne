namespace DataAccess
{
   
    public interface IMove
    {
        void ExecuteOn(Robot robot, out int penalty);
    }
}