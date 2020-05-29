let multipleof x y = x % y = 0

[<EntryPoint>]
let main argv =
    let multiples = seq {
        for i in 1 .. 999 do
            let curr = multipleof i
            if curr 3 || curr 5 then
                i
    }
    
    printfn "%d" (multiples |> Seq.sum)
    0 // return an integer exit code
