namespace AdventOfCode.Domain

module FireHazard =
  
  open System
  open System.IO

  let loadFile =
    __SOURCE_DIRECTORY__ + "/inputs/firehazard.txt"
    |> File.Readlines

  let data = 
    List.ofSeq loadFile |> List.toArray