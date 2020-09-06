using System;

namespace Kata
{
    public class SumStringsService
    {
        public string Add(string a, string b)
        {
            long aNum = 0;
            long bNum = 0;
            if (a != "")
            {
                aNum = Convert.ToInt64(a);
            }
            if (b != "")
            {
                bNum = Convert.ToInt64(b);
            }
            var result = aNum + bNum;

            return result.ToString();
        }
    }
}