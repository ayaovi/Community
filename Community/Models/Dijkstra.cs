using System;
using System.Linq;
using System.Collections.Generic;

namespace Community.Models
{
  public class Dijkstra
  {
    public IReadOnlyList<Vertex> Vertices { get;  }
    public IReadOnlyList<Edge> Edges { get; }

    private readonly Dictionary<Vertex, int> _distance = new Dictionary<Vertex, int>();
    private readonly HashSet<Vertex> _settledNodes  = new HashSet<Vertex>();
    private readonly HashSet<Vertex> _unSettledNodes  = new HashSet<Vertex>();
    private readonly Dictionary<Vertex, Vertex> _predecessors = new Dictionary<Vertex, Vertex>();

    public Dijkstra(IReadOnlyList<Vertex> vertices, IReadOnlyList<Edge> edges)
    {
      Vertices = vertices;
      Edges = edges;
    }

    private void Execute(Vertex source)
    {
      _distance.Add(source, 0);
      _unSettledNodes.Add(source);

      while (_unSettledNodes.Count > 0)
      {
        var node = GetMinimum();
        _settledNodes.Add(node);
        _unSettledNodes.Remove(node);
        FindMinimalPaths(node);
      }
    }


    public List<Vertex> FindShortestPath(Vertex source, Vertex destination)
    {
      _settledNodes.Clear();
      _unSettledNodes.Clear();
      _distance.Clear();
      _predecessors.Clear();

      Execute(source);

      var path = new List<Vertex>();
      var step = destination;
      if (_predecessors[step] == null)
      {
        return null;
      }
      path.Add(step);

      while(_predecessors.Keys.Contains(step))
      {
        step = _predecessors[step];
        path.Add(step);
      }

      path.Reverse();
      return path;
    }

    private void FindMinimalPaths(Vertex node)
    {
      var neighbours = GetNeighbours(node);

      foreach (Vertex neighbour in neighbours)
      {
        if (GetShortestPathTo(neighbour) > GetShortestPathTo(node) + GetCost(node, neighbour))
        {
          _distance[neighbour] = GetShortestPathTo(node) + GetCost(node, neighbour);
          _predecessors[neighbour] = node;
          _unSettledNodes.Add(neighbour);
        }
      }
    }

    private int GetCost(Vertex node, Vertex neighbour)
    {
      foreach (Edge edge in Edges)
      {
        if (edge.Source.Equals(node) && edge.Destination.Equals(neighbour))
        {
          return edge.Weight;
        }
      }
      throw new ArgumentException("THis should not happen");
    }

    private List<Vertex> GetNeighbours(Vertex node)
    {
      return Edges.Where(edge => edge.Source.Equals(node) && !IsSettled(edge.Destination))
                  .Select(edge => edge.Destination)
                  .ToList();
    }

    private bool IsSettled(Vertex node)
    {
      return _settledNodes.Contains(node);
    }

    private Vertex GetMinimum()
    {
      Vertex minimum = null;

      foreach (Vertex vertex in _unSettledNodes)
      {
        if (minimum != null)
        {
          if (GetShortestPathTo(vertex) < GetShortestPathTo(minimum))
          {
            minimum = vertex;
          }
        }
        else
        {
          minimum = vertex;
        }
      }
      return minimum;
    }

    public int GetShortestPathTo(Vertex destination)
    {
      return _distance.Keys.Contains(destination) ? _distance[destination] : int.MaxValue;
    }
  }
}