namespace AdventOfCode

module SantasFloor =

  open System
  open System.IO

  let loadFile =
    __SOURCE_DIRECTORY__ + "/inputs/floors.txt"
    |> File.ReadAllText

  let split = 
    List.ofSeq loadFile |> List.toArray

  let addFloor s =
    match s with
    | '(' -> 1
    | ')' -> -1
    | _ ->  0

  let floorCount = 
    split
    |> Array.map addFloor 
    |> Array.sum

  let positionBasement =
    split
    |> Array.map addFloor
    |> Array.scan (+) 0
    |> Array.findIndex(fun f -> f = -1)

