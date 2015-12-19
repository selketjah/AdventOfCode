namespace AdventOfCode.Tests

open NUnit.Framework
open Swensen.Unquote

open AdventOfCode.Domain.ElvesWrappingPaper

[<TestFixture>]
module ElvesWrappingPaperTests =

  [<Test>]
  let ``given one input line 1x2x3 it returns a rectangle`` () =
    let expected = { Length=1; Width=2; Height=3 }
    let result = getCube "1x2x3"
    test <@ expected = result @>
