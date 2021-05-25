using System.Collections.Generic;
using System.Linq;

namespace EvolutionOfCode.Assignment1
{
    public static class _07Where
    {
        public static string[] Run(int[] numbers)
        {
            var strings = new List<string>();

            foreach (var number in numbers.Where(x => x % 2 == 0))
            {
                switch (number)
                {
                    case 0:
                        strings.Add("zero");
                        break;
                    case 2:
                        strings.Add("two");
                        break;
                    case 4:
                        strings.Add("four");
                        break;
                    case 6:
                        strings.Add("six");
                        break;
                    case 8:
                        strings.Add("eight");
                        break;
                }
            }

            return strings.ToArray();
        }
    }
}