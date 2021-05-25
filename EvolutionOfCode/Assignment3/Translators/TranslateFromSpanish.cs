using System;
using EvolutionOfCode.Assignment3.Enums;
using static EvolutionOfCode.Assignment3.Enums.EnglishNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.SpanishNumbersEnum;
using static EvolutionOfCode.Assignment3.Translators.TranslateFromEnglish;

namespace EvolutionOfCode.Assignment3.Translators
{
    public static class TranslateFromSpanish
    {
        public static EnglishNumbersEnum SpanishToEnglish(SpanishNumbersEnum number)
        {
            return number switch
            {
                Uno => One,
                Dos => Two,
                Tres => Three,
                Cuatro => Four,
                Cinco => Five,
                Seis => Six,
                Siete => Seven,
                Ocho => Eight,
                Nueve => Nine,
                Diez => Ten,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }

        public static GermanNumbersEnum SpanishToGerman(SpanishNumbersEnum number)
        {
            return EnglishToGerman(SpanishToEnglish(number));
        }

        public static FrenchNumbersEnum SpanishToFrench(SpanishNumbersEnum number)
        {
            return EnglishToFrench(SpanishToEnglish(number));
        }

        public static ItalianNumbersEnum SpanishToItalian(SpanishNumbersEnum number)
        {
            return EnglishToItalian(SpanishToEnglish(number));
        }
    }
}