using EcommerceCaseStudy2.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCaseStudy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("get-Product")]
        public IEnumerable<Product> GetProduct()
        {
            return new List<Product>();
        }
        [HttpPost]
        [Route("save-Product")]
        public void SaveProduct(Product product)
        {
            
        }
    }
}
