using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    // public string Genger { get; set; }
    // public int PhoneNumber { get; set; }
    // public string Email { get; set; }
    // public int Age { get; set; }
  }
}