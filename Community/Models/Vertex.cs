namespace Community.Models
{
  public class Vertex
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public Location Position { get; set; }

    public override string ToString()
    {
      return Name;
    }

    public override bool Equals(object obj)
    {
      if (this == obj)
        return true;
      if (obj == null)
        return false;
      if (GetType() != obj.GetType())
        return false;
      Vertex other = (Vertex)obj;
      if (Id == null)
      {
        if (other.Id != null)
          return false;
      }
      else if (Id != other.Id)
        return false;
      return true;
    }
  }
}