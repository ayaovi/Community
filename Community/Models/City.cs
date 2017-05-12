using System.Collections.Generic;

namespace Community.Models
{
  public class City
  {
    public static List<Location[]> Blocks {get; set;} = new List<Location[]>
    {
      new[] {new Location{X = 0, Y = 0}, new Location{X = 119, Y = 0}, new Location{X = 158, Y = 68}, new Location{X = 77, Y = 68}, new Location{X = 77, Y = 112}, new Location{X = 0, Y = 112}},
      new[] {new Location{X = 139, Y = 0}, new Location{X = 226, Y = 0}, new Location{X = 226, Y = 68}, new Location{X = 178, Y = 68}},
      new[] {new Location{X = 246, Y = 0}, new Location{X = 328, Y = 0}, new Location{X = 328, Y = 68}, new Location{X = 246, Y = 68}},
      new[] {new Location{X = 348, Y = 0}, new Location{X = 490, Y = 0}, new Location{X = 511, Y = 68}, new Location{X = 435, Y = 68}, new Location{X = 435, Y = 90}, new Location{X = 348, Y = 90}},
      new[] {new Location{X = 510, Y = 0}, new Location{X = 600, Y = 0}, new Location{X = 600, Y = 68}, new Location{X = 531, Y = 68}},
      new[] {new Location{X = 0, Y = 132}, new Location{X = 77, Y = 132}, new Location{X = 77, Y = 190}, new Location{X = 0, Y = 190}},
      new[] {new Location{X = 97, Y = 88}, new Location{X = 226, Y = 88}, new Location{X = 226, Y = 250}, new Location{X = 97, Y = 250}},
      new[] {new Location{X = 246, Y = 88}, new Location{X = 328, Y = 88}, new Location{X = 328, Y = 200}, new Location{X = 246, Y = 200}},
      new[] {new Location{X = 246, Y = 220}, new Location{X = 328, Y = 220}, new Location{X = 328, Y = 300}, new Location{X = 246, Y = 350}},
      new[] {new Location{X = 348, Y = 110}, new Location{X = 435, Y = 110}, new Location{X = 435, Y = 190}, new Location{X = 348, Y = 190}},
      new[] {new Location{X = 348, Y = 210}, new Location{X = 435, Y = 210}, new Location{X = 435, Y = 250}, new Location{X = 348, Y = 300}},
      new[] {new Location{X = 455, Y = 88}, new Location{X = 600, Y = 88}, new Location{X = 600, Y = 250}, new Location{X = 455, Y = 250}},
      new[] {new Location{X = 0, Y = 210}, new Location{X = 77, Y = 210}, new Location{X = 77, Y = 250}, new Location{X = 0, Y = 295}},
      new[] {new Location{X = 0, Y = 315}, new Location{X = 77, Y = 270}, new Location{X = 100, Y = 400}, new Location{X = 0, Y = 400}},
      new[] {new Location{X = 97, Y = 270}, new Location{X = 226, Y = 270}, new Location{X = 226, Y = 400}, new Location{X = 120, Y = 400}},
      new[] {new Location{X = 246, Y = 370}, new Location{X = 328, Y = 320}, new Location{X = 328, Y = 400}, new Location{X = 246, Y = 400}},
      new[] {new Location{X = 348, Y = 320}, new Location{X = 435, Y = 270}, new Location{X = 470, Y = 400}, new Location{X = 348, Y = 400}},
      new[] {new Location{X = 455, Y = 270}, new Location{X = 600, Y = 270}, new Location{X = 600, Y = 400}, new Location{X = 490, Y = 400}}
    };
  }
}