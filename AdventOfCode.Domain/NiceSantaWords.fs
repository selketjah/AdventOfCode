namespace AdventOfCode.Domain

open System
open System.IO

module NiceSantaWords =
  let loadFile =
    "B:/PROJECTS/AdventOfCode/AdventOfCode.Domain/inputs/santawords.txt"
    |> File.ReadAllLines
