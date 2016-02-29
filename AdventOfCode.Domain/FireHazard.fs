namespace AdventOfCode.Domain

module FireHazard =
  
  open System
  open System.IO

  type Coordinate = int * int
  type Action = | TurnOn | TurnOff | Toggle

  let loadFile =
    __SOURCE_DIRECTORY__ + "/inputs/firehazard.txt"
    |> File.ReadAllLines

  let data = 
    List.ofSeq loadFile |> List.toArray

  let grid = Array2D.zeroCreate<int> (1000) (1000)

  let parse (input:string) =
    let keywords = 
      [|
        "turn off"
        "turn on"
        "toggle"
        "through"
      |]
    
    let [| start'; end' |] =
      input.Split(keywords, StringSplitOptions.RemoveEmptyEntries)
      |> Array.map(fun x -> x.Trim().Split(',') |> Array.map int |> function [|x; y|] -> x, y)
      
    let action =
      if input.StartsWith "turn on" then TurnOn
      elif input.StartsWith "turn off" then TurnOff
      else Toggle
     
    action, start', end'

  
  let execute (action, (startX, startY), (endX, endY)) =
    for x in startX..endX do
      for y in startY..endY do
       match action with
       | TurnOn -> grid.[x, y] <- 1
       | TurnOff  -> grid.[x, y] <- 0
       | Toggle  -> grid.[x, y] <- abs(grid.[x, y] + (-1))

  let instructions =
    data
    |> Array.map parse
    |> Array.iter execute

  let mutable count = 0

  grid
  |> Array2D.iter(fun x -> count <- count + x)



  



