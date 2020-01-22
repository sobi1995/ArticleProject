using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Model._ApiResult;
using Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Services;

namespace Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }
        [HttpGet("getall")]
        public ApiResult<List<Model.Product>> GetAll()
        {
            var products = _ProductService.GetAllAsync();

            return products;
        }

        [HttpGet("getbyid/{id:int}")]
        public ApiResult<Model.Product> getbyid(int id)
        {
            var products = _ProductService.GetById(id);
            if(products==null){
                return NotFound();
            }
            return products;
          
        }
    }
}