namespace AdventOfCode.Tests

open NUnit.Framework
open Swensen.Unquote

open AdventOfCode.Domain.ElvesWrappingPaper

[<TestFixture>]
module ElvesWrappingPaperTests =

  [<Test>]
  let ``given one input line 1x2x3 it returns a rectangle `` () =
    let expected = { Length=1; Width=2; Height=3 }
    let result = getCube "1x2x3"
    test <@ expected = result @>

  [<Test>]
  let `` given cube 1x2x3 it returns volume 11 `` () =
    let expected = (1*2) + (2*3) + (3*1)
    let cube = { Length=1; Width=2; Height=3 }
    let result = getVolume cube
    test <@ expected = result @>

  [<Test>]
  let `` given cube 1x2x3 it returns slack 2 `` () =
    let expected = 2
    let cube = { Length=1; Width=2; Height=3 }
    let result = getSlack cube
    test <@ expected = result @>