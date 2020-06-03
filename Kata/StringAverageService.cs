using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class StringAverageService
    {
        private readonly Dictionary<string, int> _numberMapping = new Dictionary<string, int>
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };

        public string GetAverage(string input)
        {
            var sum = 0;
            foreach (var t in input.Split(' '))
            {
                if (_numberMapping.ContainsKey(t))
                {
                    sum += _numberMapping[t];
                }
                else
                {
                    return "n/a";
                }
            }

            return _numberMapping.FirstOrDefault(x => x.Value == sum / input.Split(' ').Length).Key;
        }
    }
}