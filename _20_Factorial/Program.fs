open System

let rec factorial n =
    match n with
    | _ when n > 1I -> n * factorial (n - 1I)
    | _ -> 1I

let rec sumDigits n =
    match n with
    | _ when n > 0I -> n % 10I + sumDigits (n / 10I)
    | _ -> 0I

[<EntryPoint>]
let main argv =
    let sum = 100I |> factorial |> sumDigits
    printfn "%A" sum
    0