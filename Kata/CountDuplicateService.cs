namespace Kata
{
    public class CountDuplicateService
    {
        public int count(string inputString)
        {
            int result = 0;
            var inputArray = inputString.ToUpper().ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j] && inputArray[i] != ' ')
                    {
                        result++;
                        inputString = inputString.ToUpper().Replace(inputArray[i], ' ');
                        inputArray = inputString.ToCharArray();
                    }
                }
            }

            return result;
        }
    }
}