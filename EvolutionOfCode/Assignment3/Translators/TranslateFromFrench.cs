using System;
using EvolutionOfCode.Assignment3.Enums;
using static EvolutionOfCode.Assignment3.Enums.EnglishNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.FrenchNumbersEnum;
using static EvolutionOfCode.Assignment3.Translators.TranslateFromEnglish;

namespace EvolutionOfCode.Assignment3.Translators
{
    public static class TranslateFromFrench
    {
        public static EnglishNumbersEnum FrenchToEnglish(FrenchNumbersEnum number)
        {
            return number switch
            {
                Un => One,
                Deux => Two,
                Trois => Three,
                Quatre => Four,
                Cinq => Five,
                FrenchNumbersEnum.Six => EnglishNumbersEnum.Six,
                Sept => Seven,
                Huit => Eight,
                Neuf => Nine,
                Dix => Ten,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }

        public static SpanishNumbersEnum FrenchToSpanish(FrenchNumbersEnum number)
        {
            return EnglishToSpanish(FrenchToEnglish(number));
        }

        public static GermanNumbersEnum FrenchToGerman(FrenchNumbersEnum number)
        {
            return EnglishToGerman(FrenchToEnglish(number));
        }

        public static ItalianNumbersEnum FrenchToItalian(FrenchNumbersEnum number)
        {
            return EnglishToItalian(FrenchToEnglish(number));
        }
    }
}