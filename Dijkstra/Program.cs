using System;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstra
{
  class Program
  {
    static void Main(string[] args)
    {
      var verticesPosition = new[]
      {
        new[]{ 0, 122 }, new[]{ 87, 122 }, new[]{ 87, 78 }, new[]{ 168, 78 },
        new[]{ 129, 0 }, new[]{ 236, 78 }, new[]{ 236, 0 }, new[]{ 338, 78 },
        new[]{ 338, 0 }, new[]{ 338, 100 }, new[]{ 445, 100 }, new[]{ 338, 200 },
        new[]{ 445, 78 }, new[]{ 521, 78 }, new[]{ 500, 0 }, new[]{ 600, 78 },
        new[]{ 338, 210 }, new[]{ 338, 310 }, new[]{ 236, 210 }, new[]{ 236, 360 },
        new[]{ 445, 260 }, new[]{ 600, 260 }, new[]{ 480, 400 }, new[]{ 338, 400 },
        new[]{ 236, 400 }, new[]{ 236, 260 }, new[]{ 87, 260 }, new[]{ 110, 400 },
        new[]{ 0, 305 }, new[]{ 87, 200 }, new[]{ 0, 200 }, new[]{ 445, 200 },

      };
      var vertices = Enumerable.Range(0, 6)
                               .Select(i => new Vertex
                               {
                                 Id = "Node_" + i,
                                 Name = "Node_" + i
                               })
                               .ToList();

      var edges = new List<Edge>
      {
        new Edge
        {
          Id = "Edge_0",
          Source = vertices[0],
          Destination = vertices[1]
        },
        new Edge
        {
          Id = "Edge_1",
          Source = vertices[0],
          Destination = vertices[2]
        },
        new Edge
        {
          Id = "Edge_2",
          Source = vertices[0],
          Destination = vertices[3]
        },
        new Edge
        {
          Id = "Edge_3",
          Source = vertices[1],
          Destination = vertices[4]
        },
        new Edge
        {
          Id = "Edge_4",
          Source = vertices[2],
          Destination = vertices[4]
        },
        new Edge
        {
          Id = "Edge_4",
          Source = vertices[2],
          Destination = vertices[5]
        },
        new Edge
        {
          Id = "Edge_4",
          Source = vertices[2],
          Destination = vertices[3]
        },
        new Edge
        {
          Id = "Edge_4",
          Source = vertices[3],
          Destination = vertices[5]
        },
        new Edge
        {
          Id = "Edge_4",
          Source = vertices[4],
          Destination = vertices[5]
        }
      };

      var dijkstra = new Dijkstra(vertices, edges);
      var shortesPath = dijkstra.FindShortestPath(vertices[0], vertices[5]);
      Console.WriteLine(shortesPath.Count);

      foreach (Vertex vertex in shortesPath)
      {
        Console.Write(vertex + " ");
      }
      Console.WriteLine();
    }
  }
}