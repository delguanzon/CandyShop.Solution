using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
  public class Treat
  {
    // properties, constructors, methods, etc. go here
    
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Treat Name can't be empty!")]
    public string Name { get; set; }
    public string Description { get; set; }    
    public int Price { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }

  }
}