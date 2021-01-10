using DBService.Repositories;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using PagingSortingTools;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly ILogger<StoreController> _logger;
        private IRepository productRepository;
        private ICategoryRepository categoryRepository;

        public StoreController(ILogger<StoreController> logger, IRepository productRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index([FromQuery(Name = "options")]
                QueryOptions productOptions,
                QueryOptions catOptions,
                long category)
        {
            ViewBag.Categories = categoryRepository.GetCategories(catOptions);
            ViewBag.SelectedCategory = category;
            return View(productRepository.GetProducts(productOptions, category));
        }
    }
}
