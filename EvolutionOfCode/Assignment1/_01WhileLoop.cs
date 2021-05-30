namespace EvolutionOfCode.Assignment1
{
    public static class _01WhileLoop
    {
        public static string[] Run(int[] numbers)
        {
            string[] strings = new string[numbers.Length];
            int evensIndex = 0;
            int i = 0;
            while (i < numbers.Length)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] == 0)
                        strings[evensIndex] = "zero";

                    if (numbers[i] == 2)
                        strings[evensIndex] = "two";

                    if (numbers[i] == 4)
                        strings[evensIndex] = "four";

                    if (numbers[i] == 6)
                        strings[evensIndex] = "six";

                    if (numbers[i] == 8)
                        strings[evensIndex] = "eight";

                    evensIndex++;
                }

                i++;
            }

            string[] returnStrings = new string[evensIndex];
            i = 0;
            while (i < evensIndex)
            {
                returnStrings[i] = strings[i];
                i++;
            }

            return returnStrings;
        }
    }
} 