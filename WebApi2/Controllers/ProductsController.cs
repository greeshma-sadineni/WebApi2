using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product {
            Id=100578,
            Name="Austin and Barbeque AABQ WIFI Food Thermometer",
            Description="Termometer med wifi for en optimal innertemparature",
            Price=399
            },
             new Product {
            Id=1009334,
            Name="Anderson  Electrisk Tandare Ecl1.1",
            Description="Electric stormasker tandare helt utan gas och bransle",
            Price=299
            },
              new Product {
            Id=100987,
            Name="Webber NonSticky Spray",
            Description="BBQ-oljspray som motverkar att ravaror fasten pa gallret",
            Price=99
            },

         };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}