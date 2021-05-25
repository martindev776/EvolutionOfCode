module TranslateFromSpanishModule

open NumbersModule
open TranslateFromEnglishModule

let SpanishToEnglish number =
    match number with
    | Spanish.Uno -> One
    | Dos -> Two
    | Tres -> Three
    | Cuatro -> Four
    | Cinco -> Five
    | Seis -> English.Six
    | Siete -> Seven
    | Ocho -> Eight
    | Nueve -> Nine
    | Diez -> Ten

let SpanishToGerman = SpanishToEnglish >> EnglishToGerman
let SpanishToFrench = SpanishToEnglish >> EnglishToFrench
let SpanishToItalian = SpanishToEnglish >> EnglishToItalian