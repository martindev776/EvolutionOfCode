module TranslateFromFrenchModule

open NumbersModule
open TranslateFromEnglishModule

let FrenchToEnglish number =
    match number with
    | Un -> One
    | Deux -> Two
    | Trois -> Three
    | Quatre -> Four
    | Cinq -> Five
    | French.Six -> English.Six
    | Sept -> Seven
    | Huit -> Eight
    | Neuf -> Nine
    | Dix -> Ten

let FrenchToSpanish = FrenchToEnglish >> EnglishToSpanish
let FrenchToGerman = FrenchToEnglish >> EnglishToGerman
let FrenchToItalian = FrenchToEnglish >> EnglishToItalian