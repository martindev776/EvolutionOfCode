using System;
using EvolutionOfCode.Assignment3.Enums;
using static EvolutionOfCode.Assignment3.Enums.EnglishNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.SpanishNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.GermanNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.FrenchNumbersEnum;
using static EvolutionOfCode.Assignment3.Enums.ItalianNumbersEnum;

namespace EvolutionOfCode.Assignment3.Translators
{
    public static class TranslateFromEnglish
    {
        public static SpanishNumbersEnum EnglishToSpanish(EnglishNumbersEnum number)
        {
            return number switch
            {
                One => SpanishNumbersEnum.Uno,
                Two => Dos,
                Three => Tres,
                Four => Cuatro,
                Five => Cinco,
                EnglishNumbersEnum.Six => Seis,
                Seven => Siete,
                Eight => Ocho,
                Nine => Nueve,
                Ten => Diez,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }

        public static GermanNumbersEnum EnglishToGerman(EnglishNumbersEnum number)
        {
            return number switch
            {
                One => Eins,
                Two => Zwei,
                Three => Drei,
                Four => Vier,
                Five => Fünf,
                EnglishNumbersEnum.Six => Sechs,
                Seven => Sieben,
                Eight => Acht,
                Nine => Neun,
                Ten => Zehn,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }

        public static FrenchNumbersEnum EnglishToFrench(EnglishNumbersEnum number)
        {
            return number switch
            {
                One => Un,
                Two => Deux,
                Three => Trois,
                Four => Quatre,
                Five => Cinq,
                EnglishNumbersEnum.Six => FrenchNumbersEnum.Six,
                Seven => Sept,
                Eight => Huit,
                Nine => Neuf,
                Ten => Dix,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }

        public static ItalianNumbersEnum EnglishToItalian(EnglishNumbersEnum number)
        {
            return number switch
            {
                One => ItalianNumbersEnum.Uno,
                Two => Due,
                Three => Tre,
                Four => Quattro,
                Five => Cinque,
                EnglishNumbersEnum.Six => Sei,
                Seven => Sette,
                Eight => Otto,
                Nine => Nove,
                Ten => Dieci,
                _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
            };
        }
    }
}