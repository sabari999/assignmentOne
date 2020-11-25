using DataAccess;

namespace DataProvider
{
    public class ProcessLocation
    {
        private readonly Arena arena;
              
        public Robot Parse(string x, string y, string direction)
        {
            return new Robot(new Position(int.Parse(x), int.Parse(y)), ProcessDirections.Create(direction), arena);
        }
    }
}