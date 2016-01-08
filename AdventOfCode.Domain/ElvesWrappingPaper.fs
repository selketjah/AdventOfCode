namespace AdventOfCode.Domain

open System
open System.IO

module ElvesWrappingPaper =

  type Cube = {  Length:int; Width:int; Height:int}

  let sampleData =
    "B:/PROJECTS/AdventOfCode/AdventOfCode.Domain/inputs/elves.txt"
    |> File.ReadAllLines

  let parseCube (input:string) =
    let dimensions =
      input.Split 'x'
      |> Array.map int
    {Length = dimensions.[0];  Width = dimensions.[1]; Height = dimensions.[2]}

  let volume (cube:Cube) : int =
    let lw = cube.Length * cube.Width * 2
    let wh = cube.Width * cube.Height * 2
    let hl = cube.Height * cube.Length * 2
    lw + wh + hl

  let slack (cube:Cube) : int =
    let sorted =
      (*
      [| cube.Length; cube.Width; cube.Height |]
      |> Array.sort
      sorted.[0] * sorted.[1]
      *)

      [ cube.Length; cube.Width; cube.Height ]
      |> List.sort
      |> Seq.take 2
      |> Seq.reduce (*)

      //|> Seq.fold (fun acc x -> acc * x) 1
      //sorted.[0] * sorted.[1]

  let wrapperPaperVolumePerPresent input =
    let cube = parseCube input
    volume cube + slack cube

  let calculateWrappingPaperVolumeOfPresents =
    sampleData
    |> Array.map wrapperPaperVolumePerPresent
    |> Array.sum
