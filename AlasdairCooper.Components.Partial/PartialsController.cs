using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.IO;

namespace AlasdairCooper.Components.Partial
{
    public class PartialsController : Controller
    {
        [HttpPost("/{controller}/{name}")]
        public async Task<IActionResult> Render(string name, [FromHeader] string type = null!)
        {
            Type actualType = Type.GetType(type) ?? throw new ArgumentNullException(nameof(type));
            using StreamReader reader = new(Request.Body, Encoding.UTF8);
            var body = await reader.ReadToEndAsync();
            return PartialView(name, JsonSerializer.Deserialize(body, actualType));
        }
    }
}
