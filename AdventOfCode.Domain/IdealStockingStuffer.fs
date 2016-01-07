namespace AdventOfCode

open System.Security.Cryptography
open System.Text

module IdealStockingStuffer =
  let input = "yzbqklnj"
  let testInput = "pqrstuv1048970"B

  let md5 (data : byte array) : string =
      use md5 = MD5.Create()
      (StringBuilder(), md5.ComputeHash(data))
      ||> Array.fold (fun sb b -> sb.Append(b.ToString("x2")))
      |> string

  let toBytes extension = Encoding.ASCII.GetBytes(input + extension.ToString())

  let rec checkHash tail =
    let hash = md5 (toBytes tail)
    if hash.StartsWith("00000") then
      printf "%i" tail
    else
      checkHash (tail + 1)
