using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace AdventOfCode.CSharp
{
  public class SantasFloor
  {

    public string FloorInstructions()
    {
      return File.ReadAllText(@"E:\labdays\AdventOfCode\AdventOfCode.CSharp\inputs\floors.txt");
    }

    public int EndFloor()
    {
      return FloorInstructions().Sum(f => MapFloor(f));
    }

    public int MapFloor(char c)
    {
      switch (c)
      {
        case '(':
          return 1;
        case ')':
          return -1;
        default:
          return 0;
      }
    }
  }
}