namespace Exercises.SessionExcerises
{
    public static class ValueTypeOperations
    {
        public static int ReturnYCoord(int xCoord, int numberToAddToXCoord)
        {
            xCoord = xCoord + numberToAddToXCoord;
            int yCoord = xCoord;
            xCoord = xCoord + numberToAddToXCoord;

            return yCoord;
        }
    }
}
