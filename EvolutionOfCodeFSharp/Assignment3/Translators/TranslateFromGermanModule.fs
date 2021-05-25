module TranslateFromGermanModule

open NumbersModule
open TranslateFromEnglishModule

let GermanToEnglish number =
    match number with
    | Eins -> One
    | Zwei -> Two
    | Drei -> Three
    | Vier -> Four
    | Fünf -> Five
    | Sechs -> English.Six
    | Sieben -> Seven
    | Acht -> Eight
    | Neun -> Nine
    | Zehn -> Ten

let GermanToSpanish = GermanToEnglish >> EnglishToSpanish
let GermanToFrench = GermanToEnglish >> EnglishToFrench
let GermanToItalian = GermanToEnglish >> EnglishToItalian