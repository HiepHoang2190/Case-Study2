using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Selling_Phone.Models;
using Selling_Phone.ViewModels;

namespace Selling_Phone.Controllers
{
    public class ProductManagementController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICategoryRepository categoryRepository;

        public ProductManagementController(IProductRepository productRepository,
                                IWebHostEnvironment webHostEnvironment,
                                ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Categories = GetCategories();
            var products = productRepository.Gets();
            return View(products);
            return View();
        }
        public ViewResult Details(int id)
        {
            try
            {
                // var key =int.Parse(id.Value.ToString());
                ViewBag.Categories = GetCategories();
                var product = productRepository.Get(id);
                if (product == null)
                {
                    //ViewBag.Id = id.Value;
                    return View("~/Views/Error/ProductNotFound.cshtml", id);
                }
                return View(product);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    CategoryId = model.CategoryId,
                    Processor = model.Processor,
                    Screen = model.Screen,
                    OperatingSystem = model.OperatingSystem,
                    RearCamera = model.RearCamera,
                    FrontCamera = model.FrontCamera,
                    Memory = model.Memory,
                    HardDrive = model.HardDrive,
                    Sim = model.Sim,
                    BatteryCapacity = model.BatteryCapacity,
                    ProductDescription = model.ProductDescription

                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                product.AvatarPatch = fileName;

                var newPro = productRepository.Create(product);
                return RedirectToAction("Details", new { id = newPro.ProductId });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = GetCategories();
            var product = productRepository.Get(id);
            if (product == null)
            {
                //ViewBag.Id = id.Value;
                return View("~/Views/Error/ProductNotFound.cshtml", id);
            }
            var proEdit = new HomeEditViewModel()
            {
                AvatarPath = product.AvatarPatch,
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
                Id = product.ProductId,
                Processor = product.Processor,
                Screen = product.Screen,
                OperatingSystem = product.OperatingSystem,
                RearCamera = product.RearCamera,
                FrontCamera = product.FrontCamera,
                Memory = product.Memory,
                HardDrive = product.HardDrive,
                Sim = product.Sim,
                BatteryCapacity = product.BatteryCapacity,
                ProductDescription = product.ProductDescription
            };
            return View(proEdit);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                    CategoryId = model.CategoryId,
                    ProductId = model.Id,
                    AvatarPatch = model.AvatarPath,
                    Processor = model.Processor,
                    Screen = model.Screen,
                    OperatingSystem = model.OperatingSystem,
                    RearCamera = model.RearCamera,
                    FrontCamera = model.FrontCamera,
                    Memory = model.Memory,
                    HardDrive = model.HardDrive,
                    Sim = model.Sim,
                    BatteryCapacity = model.BatteryCapacity,
                    ProductDescription = model.ProductDescription
                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    product.AvatarPatch = fileName;
                    if (!string.IsNullOrEmpty(model.AvatarPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath, "images", model.AvatarPath);
                        System.IO.File.Delete(delFile);
                    }
                }
                var editPro = productRepository.Edit(product);
                if (editPro != null)
                {
                    return RedirectToAction("Details", new { id = editPro.ProductId });
                }
            }
            return View();

        }
        public IActionResult Delete(int id)
        {
            if (productRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private List<Category> GetCategories()
        {
            return categoryRepository.Gets().ToList();
        }
    }
}
