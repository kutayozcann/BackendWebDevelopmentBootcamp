using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Data;
using Survivor.Data.Entities;
using Survivor.Models.Categories;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SurvivorDbContext _db;

        public CategoriesController(SurvivorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _db.Categories
                .Where(category => category.IsDeleted == false)
                .Select(c => new { c.Id, c.Name }).ToList();

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _db.Categories.Find(id);

            if (category is null) return NotFound();

            var response = new CategoryListResponse
            {
                Id = category.Id,
                Name = category.Name
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult PostCategory(CategoryAddResponse request)
        {
            var newCategory = new CategoryEntity
            {
                Name = request.Name
            };
            _db.Categories.Add(newCategory);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutCategory(int id, CategoryAddResponse request)
        {
            var category = _db.Categories.Find(id);
            if (category is null) return NotFound();

            category.Name = request.Name;

            _db.Categories.Update(category);
            _db.SaveChanges();
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _db.Categories.Find(id);
            if (category is null) return NotFound();
            
            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;
            _db.Categories.Update(category);
            _db.SaveChanges();
            
            return Ok();
        }
    }
}