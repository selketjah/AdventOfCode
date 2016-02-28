namespace AdventOfCode.Domain

module FireHazard =
  
  open System
  open System.IO

  let loadFile =
    __SOURCE_DIRECTORY__ + "/inputs/firehazard.txt"
    |> File.ReadAllLines

  let data = 
    List.ofSeq loadFile |> List.toArray

  let grid = Array2D.zeroCreate<int> (1000) (1000)

