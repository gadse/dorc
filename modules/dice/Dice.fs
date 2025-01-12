// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let asWord number =
    match number with
     | 1 -> "one"
     | 2 -> "two"
     | 3 -> "three"
     | 4 -> "four"
     | 5 -> "five"
     | 6 -> "six"
     | 7 -> "seven"
     | 8 -> "eight"
     | 9 -> "nine"
     | 10 -> "ten"
     | 11 -> "eleven"
     | 12 -> "twelve"
     | i -> i.ToString()

let printResult result sides =
    printf $"rolled a {result} on a {asWord sides}-sided die\n"

let rand n =
    (System.Random().Next n)

let roll count sides =
    [1 .. count] |>  List.map (fun _ -> printResult ((rand sides) + 1) sides)

[<EntryPoint>]
let main argv =
    ignore (
        roll (int argv.[0]) (int argv.[1])
    )
    0
    
