let charToInt c = int c - int '0'

let s = System.IO.File.ReadAllLines("day1.txt")
let first = s.[0]
            |> Seq.toList 
            |> List.map charToInt 
List.windowed 2 first
|> List.append [[first.[(List.length first)-1];first.[0]]]
|> List.filter (fun xs -> xs.[1]=xs.[0]) 
|> List.map (fun xs -> xs.[0])
|> List.sum

