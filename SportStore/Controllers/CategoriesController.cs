using DBService.Models;
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
    public class CategoriesController : Controller
    {
        private readonly ILogger<CategoriesController> _logger;
        private ICategoryRepository repository;

        public CategoriesController(ILogger<CategoriesController> logger, ICategoryRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public IActionResult Index(QueryOptions options)
            => View(repository.GetCategories(options));

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            repository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult EditCategory(long id)
        {
            ViewBag.EditId = id;
            return View("Index", repository.Categories);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            repository.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            repository.DeleteCategory(category);
            return RedirectToAction(nameof(Index));
        }
    }
}
