using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Model;

namespace Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Services
{
    public class ProductService : IProductService
    {
        List<Product> Products = new List<Product>();
        public ProductService()
        {
            Products.Add(new Product()
            {
                Id = 10,
                Name = "Test",
                Price = 25000,
                IsExit = true

            });
        }
        public List<Product> GetAllAsync()
        {
            return Products;
        }

        public Product GetById(int id)
        {
           return Products.Where(x=> x.Id==id).FirstOrDefault();
        }
    }
}