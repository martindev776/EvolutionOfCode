using System;
using EvolutionOfCode.Assignment3.Enums;
using static EvolutionOfCode.Assignment3.Enums.EnglishNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.GermanNumbersEnum;
using static EvolutionOfCode.Assignment3.Translators.TranslateFromEnglish;

namespace EvolutionOfCode.Assignment3.Translators
{
    public static class TranslateFromGerman
    {
        public static EnglishNumbersEnum GermanToEnglish(GermanNumbersEnum number)
        {
            return number switch
            {
                Eins => One,
                Zwei => Two,
                Drei => Three,
                Vier => Four,
                Fünf => Five,
                Sechs => Six,
                Sieben => Seven,
                Acht => Eight,
                Neun => Nine,
                Zehn => Ten,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }

        public static SpanishNumbersEnum GermanToSpanish(GermanNumbersEnum number)
        {
            return EnglishToSpanish(GermanToEnglish(number));
        }

        public static FrenchNumbersEnum GermanToFrench(GermanNumbersEnum number)
        {
            return EnglishToFrench(GermanToEnglish(number));
        }

        public static ItalianNumbersEnum GermanToItalian(GermanNumbersEnum number)
        {
            return EnglishToItalian(GermanToEnglish(number));
        }
    }
}