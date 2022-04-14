using System;
using System.ComponentModel.DataAnnotations;

namespace assignment_crudelicious.Models
{

  public class Pet
  {

    [Key]
    public int PetId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
  }

}