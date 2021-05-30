using System.Collections.Generic;

namespace EvolutionOfCode.Assignment1
{
    public static class _05List
    {
        public static string[] Run(int[] numbers)
        {
            var strings = new List<string>();

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    switch (i)
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
            }

            return strings.ToArray();
        }
    }
}