﻿using System;
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
        new[]{ 0, 305 }, new[]{ 87, 200 }, new[]{ 0, 200 }, new[]{ 445, 200 }
      };

      var verticesConnection = new[]
      {
        new[]{0, 1}, new[]{1, 0}, new[]{1, 2}, new[]{2, 1}, new[]{1, 29}, new[]{29, 1}, 
        new[]{2, 3}, new[]{3, 2}, new[]{3, 4}, new[]{4, 3}, new[]{3, 5}, new[]{5, 3}, 
        new[]{5, 6}, new[]{6, 5}, new[]{5, 7}, new[]{7, 5}, new[]{5, 18}, new[]{18, 5}, 
        new[]{7, 8}, new[]{8, 7}, new[]{7, 9}, new[]{9, 7}, new[]{9, 10}, new[]{10, 9}, 
        new[]{9, 11}, new[]{11, 9}, new[]{10, 12}, new[]{12, 10}, new[]{10, 31}, new[]{31, 10}, 
        new[]{12, 13}, new[]{13, 12}, new[]{13, 14}, new[]{14, 13}, new[]{13, 15}, new[]{15, 13}, 
        new[]{11, 31}, new[]{31, 11}, new[]{11, 16}, new[]{16, 11}, new[]{31, 20}, new[]{20, 31}, 
        new[]{20, 21}, new[]{21, 20}, new[]{20, 17}, new[]{17, 20}, new[]{20, 22}, new[]{22, 20}, 
        new[]{16, 17}, new[]{17, 16}, new[]{16, 18}, new[]{18, 16}, new[]{17, 23}, new[]{23, 17}, 
        new[]{17, 19}, new[]{19, 17}, new[]{19, 24}, new[]{24, 19}, new[]{19, 25}, new[]{25, 19}, 
        new[]{18, 25}, new[]{25, 18}, new[]{25, 26}, new[]{26, 25}, new[]{26, 27}, new[]{27, 26}, 
        new[]{26, 28}, new[]{28, 26}, new[]{26, 29}, new[]{29, 26}, new[]{29, 30}, new[]{30, 29}
      };

      var vertices = Enumerable.Range(0, verticesPosition.Length)
                               .Select(i => new Vertex
                               {
                                 Id = "Node_" + i,
                                 Name = "Node_" + i,
                                 X = verticesPosition[i][0],
                                 Y = verticesPosition[i][1]
                               })
                               .ToList();

      var edges = Enumerable.Range(0, verticesConnection.Length)
                               .Select(i => new Edge("Edge_" + i,vertices[verticesConnection[i][0]],vertices[verticesConnection[i][1]]))
                               .ToList();

      var dijkstra = new Dijkstra(vertices, edges);
      var shortesPath = dijkstra.FindShortestPath(vertices[31], vertices[26]);

      foreach (Vertex vertex in shortesPath)
      {
        Console.Write(vertex + " ");
      }
      Console.WriteLine();
    }
  }
}