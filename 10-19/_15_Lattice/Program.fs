
let rec factorial n =
    if n = 1I then
        n
    else
       n * (factorial <| n - 1I)

let ncr n r = factorial n / (factorial r * factorial (n - r))

[<EntryPoint>]
let main argv =
    let width = 20I
    let height = 20I
    printfn "%A" <| ncr (width + height) width
    0