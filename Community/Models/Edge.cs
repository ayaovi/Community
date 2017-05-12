using System;

namespace Community.Models
{
  public class Edge
  {
    public Edge(string id, Vertex source, Vertex destination)
    {
      Id = id;
      Source = source;
      Destination = destination;
      Weight = (int)Math.Sqrt((Destination.Position.X - Source.Position.X) * (Destination.Position.X - Source.Position.X) + 
      (Destination.Position.Y - Source.Position.Y) * (Destination.Position.Y - Source.Position.Y));
    }

    public string Id { get; set; }
    public Vertex Source { get; set; }
    public Vertex Destination { get; set; }
    public int Weight { get; set; }

    public override string ToString()
    {
      return $"{Source} {Destination}";
    }
  }
}