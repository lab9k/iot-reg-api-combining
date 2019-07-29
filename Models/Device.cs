using System.Collections.Generic;

namespace iot_reg_combining_backend.Models {
  public class Device {
    public int Id { get; set; }
    public string Organization { get; set; }
    public string Reference { get; set; }
    public string Application { get; set; }
    public Type[] Types { get; set; }
    public string[] Categories { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public Dictionary<string, string> Meta { get; set; }
  }
}