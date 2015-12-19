namespace AdventOfCode.Domain

open System
open System.IO

module ElvesWrappingPaper =

  type Cube = {  Length:int; Width:int; Height:int}

  let loadFile =
    File.ReadAllLines("./inputs/elves.txt") |> Seq.cast<string>

  let getCube (input:string) =
    let distances = input.Split [|'x'|]
    {Length = (int)distances.[0];  Width = (int)distances.[1]; Height = (int)distances.[2]}

  let getVolume (cube:Cube) : int =
    let lw = cube.Length * cube.Width
    let wh = cube.Width * cube.Height
    let hl = cube.Height * cube.Length
    lw + wh + hl

  let getSlack (cube:Cube) : int =
    let tosort = [ cube.Length; cube.Width; cube.Height ] |> List.sortBy (fun x -> x)
    tosort.[0] * tosort.[1]

  let getWrapperPaperTotal input =
    let cube = getCube input
    getVolume cube + getSlack cube



