open System
open System.IO

let getNames path = 
    async {
        let! rawText = File.ReadAllTextAsync path |> Async.AwaitTask
        return rawText.Split (',', StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun str -> str.Replace ("\"", ""))
        |> Array.sort
    }

let getNameSum (name: string) =
    name.ToCharArray()
    |> Array.map (fun c -> (bigint (int c)) - 64I) |> Array.reduce (+)

let getNameValue index value =
    bigint (index + 1) * value

[<EntryPoint>]
let main argv =
    let namesLoc = "./names.txt"
    let names = getNames namesLoc |> Async.RunSynchronously
    let total = 
        names
        |> Array.map getNameSum
        |> Array.mapi getNameValue
        |> Array.reduce (+)
        
    printfn "%A" total
    0