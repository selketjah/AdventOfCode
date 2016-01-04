namespace AdventOfCode.Domain

open System
open System.IO
open System.Text

module NiceSantaWords =
  let loadFile =
    "B:/PROJECTS/AdventOfCode/AdventOfCode.Domain/inputs/santawords.txt"
    |> File.ReadAllLines

  let vowels = ['a', 'e', 'i', 'o', 'u']

  let matchPattern (word:string) =
    match word with
    | word when word.Contains("ab") -> false
    | word when word.Contains("cd") -> false
    | word when word.Contains("pq") -> false
    | word when word.Contains("xy") -> false
    | _ -> true
