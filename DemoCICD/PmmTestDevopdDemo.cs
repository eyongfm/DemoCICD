namespace DemoCICD
{
    public class PmmTestDevopdDemo
    {
        public int CountOccurrance(string stringToCheck, string stringToFind)
        {
            if (stringToCheck == null) return -1;
            if (stringToFind == null) return 0;
            var stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];
            var occuranceCount = 0;

            for (var charIndex = 0; charIndex <= stringAsCharArray.GetUpperBound(0); charIndex++)
            {
                if (stringAsCharArray[charIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }
    }
}