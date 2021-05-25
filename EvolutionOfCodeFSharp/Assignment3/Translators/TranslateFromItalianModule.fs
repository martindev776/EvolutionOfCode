module TranslateFromItalianModule

open NumbersModule
open TranslateFromEnglishModule

let ItalianToEnglish number =
    match number with
    | Italian.Uno -> One
    | Due -> Two
    | Tre -> Three
    | Quattro -> Four
    | Cinque -> Five
    | Sei -> English.Six
    | Sette -> Seven
    | Otto -> Eight 
    | Nove -> Nine
    | Dieci -> Ten 

let ItalianToSpanish = ItalianToEnglish >> EnglishToSpanish
let ItalianToGerman = ItalianToEnglish >> EnglishToGerman
let ItalianToFrench = ItalianToEnglish >> EnglishToFrench