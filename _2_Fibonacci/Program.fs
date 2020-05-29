[<EntryPoint>]
let main argv =
    let fib = Seq.unfold (fun (x, y) -> Some(x + y, (y, x + y))) (1, 1)
    let sum =
        fib
        |> Seq.takeWhile (fun x -> x <= 4000000)
        |> Seq.filter (fun x -> x % 2 = 0)
        |> Seq.sum
        
    printfn "%d" sum
    0 // return an integer exit code
