using Microsoft.AspNetCore.Mvc;
namespace Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Controllers.v2
{   
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/[controller]")]
     [ApiController]
    public class ApiVersionController:ControllerBase
    {
            [HttpGet()]
    public string Get() => "Space Potatoes v2";
    }
}