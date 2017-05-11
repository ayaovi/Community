using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Community.Models
{
  public class Player
  {
    [DisplayName("Your Nickname")]
    [Required(ErrorMessage = "A Nickname is required")]
    [StringLength(20)]
    public string UserName { get; set; }
  }
}