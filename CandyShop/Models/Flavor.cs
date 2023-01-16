namespace CandyShop.Models
{
  public class Flavor
  {
    // properties, constructors, methods, etc. go here    
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Flavor Name can't be empty!")]
    public string Name { get; set; }
    public string Description { get; set; }
    public List<FlavorTreat> Treats { get; set; }
    
  }
}