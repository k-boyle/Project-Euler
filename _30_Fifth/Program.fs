let getDigits n =
    seq {
        let mutable i = n
        while (i > 0) do
            yield float <| i % 10
            i <- i / 10
    }

let isPartialNarcissistic n =
    n
    |> getDigits
    |> Seq.map (fun i -> int (i ** 5.0))
    |> Seq.reduce (+)
    |> n.Equals

[<EntryPoint>]
let main argv =
    let numbers = [ 2..999999 ]
    let narcissistics =
        numbers
        |> List.filter isPartialNarcissistic
        |> List.reduce (+)
    printf "%A" narcissistics
    0