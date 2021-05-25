using System;
using EvolutionOfCode.Assignment3.Enums;
using static EvolutionOfCode.Assignment3.Enums.EnglishNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.ItalianNumbersEnum;
using static EvolutionOfCode.Assignment3.Translators.TranslateFromEnglish;

namespace EvolutionOfCode.Assignment3.Translators
{
    public static class TranslateFromItalian
    {
        public static EnglishNumbersEnum ItalianToEnglish(ItalianNumbersEnum number)
        {
            return number switch
            {
                Uno => One,
                Due => Two,
                Tre => Three,
                Quattro => Four,
                Cinque => Five,
                Sei => Six,
                Sette => Seven,
                Otto => Eight,
                Nove => Nine,
                Dieci => Ten,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }
        public static SpanishNumbersEnum ItalianToSpanish(ItalianNumbersEnum number)
        {
            return EnglishToSpanish(ItalianToEnglish(number));
        }

        public static GermanNumbersEnum ItalianToGerman(ItalianNumbersEnum number)
        {
            return EnglishToGerman(ItalianToEnglish(number));
        }

        public static FrenchNumbersEnum ItalianToFrench(ItalianNumbersEnum number)
        {
            return EnglishToFrench(ItalianToEnglish(number));
        }
    }
}