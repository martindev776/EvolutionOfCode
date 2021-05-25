using System;
using System.Collections.Generic;
using System.Linq;

namespace EvolutionOfCode.Assignment1
{
    public static class _08SwitchMethod
    {
        private static string MapToString(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 2:
                    return "two";
                case 4:
                    return "four";
                case 6:
                    return "six";
                case 8:
                    return "eight";
                default:
                    throw new Exception($"No case for {number}");
            }
        }

        public static string[] Run(int[] numbers)
        {
            var strings = new List<string>();

            foreach (var number in numbers.Where(x => x % 2 == 0))
            {
                var stringToAdd = MapToString(number);
                strings.Add(stringToAdd);
            }

            return strings.ToArray();
        }
    }
}