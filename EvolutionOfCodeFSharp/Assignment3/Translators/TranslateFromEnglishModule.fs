module TranslateFromEnglishModule

open NumbersModule

let EnglishToSpanish number =
    match number with
    | One -> Spanish.Uno
    | Two -> Dos
    | Three -> Tres
    | Four -> Cuatro
    | Five -> Cinco
    | English.Six -> Seis
    | Seven -> Siete
    | Eight -> Ocho
    | Nine -> Nueve
    | Ten -> Diez

let EnglishToGerman number =
    match number with
    | One -> Eins
    | Two -> Zwei
    | Three -> Drei
    | Four -> Vier
    | Five -> Fünf
    | English.Six -> Sechs
    | Seven -> Sieben
    | Eight -> Acht
    | Nine -> Neun
    | Ten -> Zehn

let EnglishToFrench number =
    match number with
    | One -> Un
    | Two -> Deux
    | Three -> Trois
    | Four -> Quatre
    | Five -> Cinq
    | English.Six -> French.Six
    | Seven -> Sept
    | Eight -> Huit
    | Nine -> Neuf
    | Ten -> Dix

let EnglishToItalian number =
    match number with
    | One -> Italian.Uno
    | Two -> Due
    | Three -> Tre
    | Four -> Quattro
    | Five -> Cinque
    | English.Six -> Sei
    | Seven -> Sette
    | Eight -> Otto
    | Nine -> Nove
    | Ten -> Dieci