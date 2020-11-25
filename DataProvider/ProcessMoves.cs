using System.Collections.Generic;
using System.Linq;
using DataAccess;

namespace DataProvider
{
    public static class ProcessMoves
    {
        public static IEnumerable<IMove> Parse(string input)
        {
            return input.Select(c => CreateMovement(c));
        }

        private static IMove CreateMovement(char character)
        {
            switch (character)
            {
                case 'L':
                    return new MoveLeft();
                case 'M':
                    return new MoveForward();
                case 'R':
                    return new MoveRight();
                default:
                    //throw new ArgumentException("Invalid movement. Valid movements are: 'L', 'M' and 'R'");
                    return null;
            }
        }
    }
}