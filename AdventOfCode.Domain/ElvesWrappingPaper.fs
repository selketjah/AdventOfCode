namespace AdventOfCode.Domain

open System
open System.IO

module ElvesWrappingPaper =

  type Cube = {  Length:int; Width:int; Height:int}

  let loadFile =
    "B:/PROJECTS/AdventOfCode/AdventOfCode.Domain/inputs/elves.txt"
    |> File.ReadAllLines

  let getCube (input:string) =
    let distances = input.Split [|'x'|]
    {Length = (int)distances.[0];  Width = (int)distances.[1]; Height = (int)distances.[2]}

  let getVolume (cube:Cube) : int =
    let lw = cube.Length * cube.Width * 2
    let wh = cube.Width * cube.Height * 2
    let hl = cube.Height * cube.Length * 2
    lw + wh + hl

  let getSlack (cube:Cube) : int =
    let tosort = [ cube.Length; cube.Width; cube.Height ] |> List.sortBy (fun x -> x)
    tosort.[0] * tosort.[1]

  let getWrapperPaperTotal input =
    let cube = getCube input
    getVolume cube + getSlack cube

  let getWrappingPaper =
    loadFile 
    |> Array.map getWrapperPaperTotal
    |> Array.sum



