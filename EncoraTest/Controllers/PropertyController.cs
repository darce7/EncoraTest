using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EncoraTestBLL.Models;
using System.Net.Http;
using Newtonsoft.Json;
using EncoraTestBLL.DLL;

namespace EncoraTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;

        public PropertyController(ILogger<PropertyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Property>> Get()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://samplerspubcontent.blob.core.windows.net/public/properties.json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<PropertyResult>(responseBody);

            return result.Properties
            .ToArray();

        }


        [HttpPost]
        public void Post([FromBody] Property property)
        {
            PropertyDTO.saveProperty(property); //Here i used a static class because there's no logic to apply to this object first, in bigger solution i would use another layer a service layer to sent the object to the DTO object.
        }
    }
}