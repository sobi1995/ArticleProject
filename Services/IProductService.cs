using System.Collections.Generic;
using System.Threading.Tasks;
using Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Model;

namespace Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Services
{
    public interface IProductService
    {
         List<Product> GetAllAsync();
    }
}