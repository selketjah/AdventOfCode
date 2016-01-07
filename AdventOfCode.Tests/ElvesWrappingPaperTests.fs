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
  let `` given cube 1x2x3 it returns volume 22 `` () =
    let expected = 22
    let cube = { Length=1; Width=2; Height=3 }
    let result = getVolume cube
    test <@ expected = result @>

  [<Test>]
  let `` given cube 1x2x3 it returns slack 2 `` () =
    let expected = 2
    let cube = { Length=1; Width=2; Height=3 }
    let result = getSlack cube
    test <@ expected = result @>

  [<Test>]
  let `` given cube 1x2x3 it returns total wrapping paper of 24 `` () =
    let expected = 24
    let input = "1x2x3"
    let result = getWrapperPaperTotal input
    test <@ expected = result @>