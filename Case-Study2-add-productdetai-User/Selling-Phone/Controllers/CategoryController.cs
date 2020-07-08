using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Selling_Phone.Models;
using Selling_Phone.ViewModels.Category;

namespace Selling_Phone.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(IProductRepository productRepository,
                                IWebHostEnvironment webHostEnvironment,
                                ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = categoryRepository.Gets();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    CategoryName = model.CategoryName
                };

                var newCate = categoryRepository.Create(category);
                return RedirectToAction("Index", "Category");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = categoryRepository.Get(id);
            if (category == null)
            {
                //ViewBag.Id = id.Value;
                return View("~/Views/Error/ProductNotFound.cshtml", id);
            }
            var editCat = new EditCategoryViewModel()
            {
                CategoryName = category.CategoryName,
                Id = category.CategoryId
            };
            return View(editCat);
        }

        [HttpPost]
        public IActionResult Edit(EditCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    CategoryId = model.Id,
                    CategoryName = model.CategoryName
                };
                var editCate = categoryRepository.Edit(category);
                if (editCate != null)
                {
                    return RedirectToAction("Index", "Category");
                }
            }
                return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = categoryRepository.Get(id);
            if (category == null)
            {

                return View("~/Views/Error/ProductNotFound.cshtml", id);
            }
            var editCat = new DeleteCategoryViewModel()
            {
                CategoryName = category.CategoryName,
                Id = category.CategoryId
            };
            return View(editCat);
        }
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            if (categoryRepository.Delete(id))
            {
                return RedirectToAction("Index","Category");
            }
            return View();
        }

    }
}
