using System.Collections.Generic;
using CandyShop.Models;

namespace CandyShop.ViewModels
{
  public class ListAllViewModel
  {
    // properties, constructors, methods, etc. go here
    public List<Treat> Treats { get; set; }
    public List<Flavor> Flavors { get; set; }

  }
}