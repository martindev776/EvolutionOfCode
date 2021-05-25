namespace EvolutionOfCode.Assignment1
{
    public static class _02ForLoop
    { 
        public static string[] Run(int[] numbers)
        {
            string[] strings = new string[numbers.Length];
            int evensIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
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
            }

            string[] returnStrings = new string[evensIndex];
            for (int i = 0; i < evensIndex; i++)
            {
                returnStrings[i] = strings[i];
                i++;
            }

            return returnStrings;
        }
    }
}