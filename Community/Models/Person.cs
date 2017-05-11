using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Community.Models
{
  public class Person
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public Location Position { get; set; } = default(Location);
  }
}