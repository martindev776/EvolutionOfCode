module Assignment1

let MapToString number =
    match number with
    | 0 -> "zero"
    | 2 -> "two"
    | 4 -> "four"
    | 6 -> "six"
    | 8 -> "eight"
    | _ -> raise (new System.Exception($"No case for {number}"))

let Run numbers =
    numbers
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map MapToString