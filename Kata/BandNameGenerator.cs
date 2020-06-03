using System;
using System.Linq;

namespace Kata
{
    public class BandNameGenerator
    {
        public string Generate(string s)
        {
            var firstWord = s.First().ToString().ToUpper();
            var otherWord = s.Substring(1); ;
            if (isTheSame(s))
            {
                return firstWord + otherWord + otherWord;
            }
            else
            {
                return "The " + firstWord + otherWord;
            }
        }

        public Boolean isTheSame(string s)
        {
            var firstWord =  s.First().ToString().ToUpper();
            var EndWord =   s.Last().ToString().ToUpper();
            return firstWord == EndWord;
        }
    }
}