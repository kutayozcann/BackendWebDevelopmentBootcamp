using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Data.Entities;
using Survivor.Models;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _db;

        public CompetitorsController(SurvivorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAllCompetitors()
        {
            var response = _db.Competitors
                .Where(c => c.IsDeleted == false)
                .Select(c => new CompetitorListResponse
                {
                    Id = c.Id,
                    FullName = c.FirstName + " " + c.LastName
                }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetCompetitorById(int id)
        {
            var competitor = _db.Competitors.Find(id);

            if (competitor is null) return NotFound();

            var response = new CompetitorListResponse
            {
                Id = competitor.Id,
                FullName = competitor.FirstName + " " + competitor.LastName
            };

            return Ok(response);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsByCategory(int categoryId)
        {
            var response = _db.Competitors
                .Where(c => c.CategoryId == categoryId)
                .Select(c => new CompetitorListResponse
                {
                    Id = c.Id,
                    FullName = c.FirstName + " " + c.LastName
                }).ToList();

            if (response.Count == 0) return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult PostCompetitor(CompetitorAddResponse request)
        {
            var newCompetitor = new CompetitorEntity()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                CategoryId = request.CategoryId
            };

            _db.Competitors.Add(newCompetitor);

            _db.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutCompetitor(int id, CompetitorUpdateResponse request)
        {
            var updateCompetitor = _db.Competitors.Find(id);

            if (updateCompetitor is null) return NotFound();

            updateCompetitor.FirstName = request.FirstName;
            updateCompetitor.LastName = request.LastName;
            updateCompetitor.CategoryId = request.CategoryId;
            updateCompetitor.ModifiedDate = DateTime.Now;

            _db.Competitors.Update(updateCompetitor);
            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompetitor(int id)
        {
            var competitor = _db.Competitors.Find(id);
            if (competitor is null) return NotFound();
            
            competitor.IsDeleted = true;
            competitor.ModifiedDate = DateTime.Now;
            _db.Competitors.Update(competitor);
            _db.SaveChanges();
            
            return Ok();
        }
    }
}