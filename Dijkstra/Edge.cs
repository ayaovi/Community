using System;

namespace Dijkstra
{
  class Edge
  {
    public Edge(string id, Vertex source, Vertex destination)
    {
      Id = id;
      Source = source;
      Destination = destination;
      Weight = (int)Math.Sqrt((Destination.X - Source.X) * (Destination.X - Source.X) + (Destination.Y - Source.Y) * (Destination.Y - Source.Y));
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