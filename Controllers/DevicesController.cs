using System.Collections.Generic;
using iot_reg_combining_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace iot_reg_combining_backend.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class DevicesController : ControllerBase {
    [HttpGet]
    public ActionResult<IEnumerable<Device>> Get() {
      return new Device[] {
        new Device {
          Organization = "Jef's house",
          Categories = new[] {"Sensor"},
          Id = 1,
          Latitude = 51.0507,
          Longitude = 3.70557,
          Reference = "Digipolis",
          Types = new[] {
            new Type {
              Application = "Cats",
              Description = "Senses cats",
              Name = "Cats"
            }
          },
          Application = "Sensor",
          Meta = new Dictionary<string, string> {
            {
              "data processing",
              "A cat will sense the presence of people or other cats and will use this information to purr dramatically loud."
            }, {
              "what is this?",
              "CAAS - Cat as a sensor"
            }
          }
        },
        new Device {Organization = "Digipolis Antwerpen"},
      };
    }
  }
}