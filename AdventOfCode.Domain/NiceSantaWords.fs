namespace AdventOfCode.Domain

module NiceSantaWords =

  open System
  open System.IO
  open System.Text
  open System.Text.RegularExpressions

  let loadFile =
    __SOURCE_DIRECTORY__ + "/inputs/santawords.txt"
    |> File.ReadAllLines

  let data = 
    List.ofSeq loadFile |> List.toArray

  let matchPattern (word:string) =
    match word with
    | word when word.Contains("ab") -> false
    | word when word.Contains("cd") -> false
    | word when word.Contains("pq") -> false
    | word when word.Contains("xy") -> false
    | _ -> true
    
  let matchVowel (letter:char) =
    match letter with
    | 'a' | 'e' | 'i' | 'o' | 'u' -> true
    | _ -> false

  let (|DoubleLetters|_|) input =
     let m = Regex.Match(input,@"(.)\1")
     if (m.Success) then Some input else None
     
  let (|ThreeVowels|_|) input =
     let m = Regex.Match(input,@"(?i)\\b(?=([^aeiou]*[aeiou]){2,})[a-z]{10}\\b")
     if (m.Success) then Some input else None

  let doubleLetters word =
    match word with
    | DoubleLetters ab -> true
    | _ -> false

  let threeVowels word =
    word
    |> Seq.filter (fun l -> matchVowel l)
    |> Seq.length
    |> (fun x -> x >= 3)

  let niceSantaWords =
    data
    |> Array.filter(fun w -> matchPattern w && doubleLetters w && threeVowels w)
    |> Array.length
    
 