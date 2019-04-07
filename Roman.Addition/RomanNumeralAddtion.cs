using System;
using System.Collections.Generic;

namespace Roman.Addition
{
    public class RomanNumeralAddtion
    {
        List<char> numerals = new List<char> { 'M','D','C','L','X', 'V', 'I' };

        HashSet<char> nonRepeatables = new HashSet<char> {'D','L', 'V' };

        Dictionary<char, int> numeralCounts = new Dictionary<char, int>();

        public RomanNumeralAddtion()
        {
            foreach (var numeral in numerals)
            {
                numeralCounts[numeral] = 0;
            }
        }

        public string Add(string roman1, string roman2)
        {
            addNumerals(roman1);
            addNumerals(roman2);

            var reverse = new List<char>(numerals);
            reverse.Reverse();
            foreach (var numeral in reverse)
            {
                var i = numerals.IndexOf(numeral);
                if (nonRepeatables.Contains(numeral))
                {
                    if (numeralCounts[numerals[i]] > 1)
                    {
                        numeralCounts[numerals[i]] -= 2;
                        numeralCounts[numerals[i - 1]] += 1;
                    }
                }
                else
                {
                    if (numeralCounts[numeral] > 3)
                    {
                        numeralCounts[numeral] -= 5;
                        numeralCounts[numerals[i - 1]] += 1;
                    }

                    if (numeralCounts[numeral] < -1)
                    {
                        numeralCounts[numeral] += 5;
                        numeralCounts[numerals[i - 1]]--;
                    }
                }
            }

            var result = "";
            foreach (var kvp in numeralCounts)
            {

                for (var i = 0; i < Math.Abs(kvp.Value); i++)
                {
                    if (kvp.Value >= 0)
                        result += kvp.Key;
                    else result = result.Insert(result.Length - 1, kvp.Key.ToString());
                }
            }

            return result;
        }

        private void addNumerals(string allChars)
        {
            for (var i = 0; i < allChars.Length; i++)
            {
                if ((i == allChars.Length - 1) || !(numerals.IndexOf(allChars[i]) > numerals.IndexOf(allChars[i + 1])))
                    numeralCounts[allChars[i]]++;
                else
                    numeralCounts[allChars[i]]--;
            }
        }
    }
}