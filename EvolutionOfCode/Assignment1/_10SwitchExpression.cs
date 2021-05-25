using System;
using System.Collections.Generic;
using System.Linq;

namespace EvolutionOfCode.Assignment1
{
    public static class _10SwitchExpression
    {
        private static string MapToString(int number)
        {
            return number switch
            {
                0 => "zero",
                2 => "two",
                4 => "four",
                6 => "six",
                8 => "eight",
                _ => throw new Exception($"No case for {number}")
            };
        }

        public static string[] Run(int[] numbers)
        {
            return numbers
                .Where(x => x % 2 == 0)
                .Select(MapToString)
                .ToArray();
        }
    }
}