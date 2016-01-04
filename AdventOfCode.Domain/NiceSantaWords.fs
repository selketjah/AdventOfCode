namespace AdventOfCode.Domain

open System
open System.IO

module NiceSantaWords =
  let loadFile =
    "B:/PROJECTS/AdventOfCode/AdventOfCode.Domain/inputs/santawords.txt"
    |> File.ReadAllLines

  let vowels = ['a', 'e', 'i', 'o', 'u']

  let matchPattern word =
    match word with
    | "ab" | "cd" | "pq" | "xy" -> false
    | _ -> true
