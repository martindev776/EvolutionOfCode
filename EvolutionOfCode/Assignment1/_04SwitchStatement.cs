namespace EvolutionOfCode.Assignment1
{
    public static class _04SwitchStatement
    {
        public static string[] Run(int[] numbers)
        {
            var strings = new string[numbers.Length];
            var evensIndex = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    switch (i)
                    {
                        case 0:
                            strings[evensIndex] = "zero";
                            break;
                        case 2:
                            strings[evensIndex] = "two";
                            break;
                        case 4:
                            strings[evensIndex] = "four";
                            break;
                        case 6:
                            strings[evensIndex] = "six";
                            break;
                        case 8:
                            strings[evensIndex] = "eight";
                            break;
                    }

                    evensIndex++;
                }
            }

            var returnStrings = new string[evensIndex];
            for (var i = 0; i < evensIndex; i++)
            {
                returnStrings[i] = strings[i];
                i++;
            }

            return returnStrings;
        }
    }
}