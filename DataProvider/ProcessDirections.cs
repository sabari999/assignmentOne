using DataAccess;

namespace DataProvider
{

    public static class ProcessDirections
    {
        public static Directions Create(string value)
        {
            switch (value.ToUpper())
            {

                case "E":
                    return new East();
                case "W":
                    return new West();
                case "N":
                    return new North();
                case "S":
                    return new South();
                default:
                    //throw new ArgumentException("Unable to parse direction (valid directions are: 'N', 'E', 'W', 'S')");
                    return null;
            }
        }
    }
}