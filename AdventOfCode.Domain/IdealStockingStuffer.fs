namespace AdventOfCode

open System.Security.Cryptography
open System.Text

module IdealStockingStuffer =
  let input = "yzbqklnj"
  let extention = 1

  let testInput = "pqrstuv1048970"B

  let md5 (data : byte array) : string =
      use md5 = MD5.Create()
      (StringBuilder(), md5.ComputeHash(data))
      ||> Array.fold (fun sb b -> sb.Append(b.ToString("x2")))
      |> string

  let concat = input + extention.ToString()

  let toBytes = Encoding.ASCII.GetBytes(concat)

  let hash = md5 toBytes;
