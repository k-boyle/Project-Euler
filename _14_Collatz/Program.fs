let getGollatz (n: int64) : int64 = if n % 2L = 0L then n / 2L else 3L * n + 1L

let collatzSeq (n: int64) : seq<int64> =
    seq {
        let mutable i = n 
        while (i > 1L) do
            yield i 
            i <- getGollatz i
        yield 1L
    }

[<EntryPoint>]
let main argv =
    let maxLength = 
        seq { for i in 1L..1000000L do collatzSeq i }
        |> Seq.maxBy (fun col -> Seq.length col)
        |> Seq.head
    printfn "%d" maxLength
    0
