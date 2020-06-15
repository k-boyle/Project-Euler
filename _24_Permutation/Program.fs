let rec permutations = function
        | []      -> seq [List.empty]
        | x :: xs -> Seq.collect (insertions x) (permutations xs)
    and insertions x = function
        | []             -> [[x]]
        | (y :: ys) as xs -> (x::xs)::(List.map (fun x -> y::x) (insertions x ys))

[<EntryPoint>]
let main argv =
    let numbers = [ 0..9 ]
    let permutations = permutations numbers
    let mill = permutations |> Seq.sort |> Seq.indexed |> Seq.find (fun (i, s) -> i = 999999)
    printfn "%A" mill
    0