using CrazyMusicians.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;

namespace CrazyMusicians.Controllers;

// Controller for managing musicians. Provides CRUD operations and search functionality.
[Route("api/[controller]")]
[ApiController]
public class MusiciansController : ControllerBase
{
    private static readonly List<Musician> _musicians = new List<Musician>()
    {
        new Musician()
        {
            Id = 1, FullName = "Ahmet Çalgı", Profession = "Famous Instrument Player",
            FunFact = "Always plays the wrong note, but very funny"
        },
        new Musician()
        {
            Id = 2, FullName = "Zeynep Melodi", Profession = "Popular Melody Writer",
            FunFact = "Her songs ara misunderstood but very popular"
        },
        new Musician()
        {
            Id = 3, FullName = "Cemil Akor", Profession = "Crazy Chordist",
            FunFact = "Changes chords often, but surprisingly talented"
        },
        new Musician()
        {
            Id = 4, FullName = "Fatma Nota", Profession = "Surprise Note Producer",
            FunFact = "Constantly prepares surprises while producing notes"
        },
        new Musician()
        {
            Id = 5, FullName = "Hasan Ritim", Profession = "Rhythm Monster",
            FunFact = "He makes each beat in his own way, it never fits, but it's funny"
        },
        new Musician()
        {
            Id = 6, FullName = "Elif Armoni", Profession = "Master of Harmony",
            FunFact = "She sometimes plays harmonies wrong, but he is very creative"
        },
        new Musician()
        {
            Id = 7, FullName = "Ali Perde", Profession = "Pitch Applicator",
            FunFact = "Plays every pitch differently, always surprising"
        },
        new Musician()
        {
            Id = 8, FullName = "Ayşe Rezonans", Profession = "Resonance Expert",
            FunFact = "Specializes in resonance, but sometimes makes a lot of noise"
        },
        new Musician()
        {
            Id = 9, FullName = "Murat Ton", Profession = "Intonation Enthusiast",
            FunFact = "The differences in intonation are sometimes funny, but quite interesting"
        },
        new Musician()
        {
            Id = 10, FullName = "Selin Akor", Profession = "Chord Wizard",
            FunFact = "When she change chords, sometimes it creates a magical atmosphere"
        }
    };

    // Returns all musicians in the list.
    [HttpGet]
    public ActionResult<Musician> GetAll()
    {
        return Ok(_musicians);
    }

    // Returns a musician by their ID. Returns 404 if the musician is not found.
    [HttpGet("{id:int:min(1)}")]
    public ActionResult<Musician> GetById(int id)
    {
        var musician = _musicians.FirstOrDefault(m => m.Id == id);
        if (musician == null)
            return NotFound($"Musician with Id {id} not found");
        return Ok(musician);
    }

    // Searches for musicians by their full name. Returns 400 if the search term is empty, and 404 if no results are found.
    [HttpGet("search")]
    public IActionResult Search([FromQuery] string fullName)
    {
        if (string.IsNullOrEmpty(fullName))
            return BadRequest("Full name is required");

        var result = _musicians.Where(m => m.FullName.Contains(fullName, StringComparison.OrdinalIgnoreCase)).ToList();

        if (!result.Any())
            return NotFound($"Musician with FullName {fullName} not found");

        return Ok(result);
    }

    // Adds a new musician to the list. Validates the model and returns 400 if validation fails.
    [HttpPost]
    public ActionResult<Musician> Post([FromBody] Musician musician)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var id = _musicians.Max(m => m.Id) + 1;
        musician.Id = id;

        _musicians.Add(musician);
        return CreatedAtAction(nameof(GetById), new { id = musician.Id }, musician);
    }

    // Updates an existing musician by their ID. Returns 404 if the musician is not found, and 400 if validation fails.
    [HttpPut("{id:int:min(1)}")]
    public IActionResult Put(int id, [FromBody] Musician musician)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var musicianToUpdate = _musicians.FirstOrDefault(m => m.Id == id);
        if (musicianToUpdate == null)
            return NotFound($"Musician with Id {id} not found");

        musicianToUpdate.FullName = musician.FullName;
        musicianToUpdate.Profession = musician.Profession;
        musicianToUpdate.FunFact = musician.FunFact;

        return Ok(musicianToUpdate);
    }

    // Partially updates a musician using JSON Patch. Returns 400 if the patch document is null, and 404 if the musician is not found.
    [HttpPatch("{id:int:min(1)}")]
    public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Musician>? patch)
    {
        if (patch == null)
            return BadRequest("Patch Doc is null");

        var musicianToPatch = _musicians.FirstOrDefault(m => m.Id == id);
        if (musicianToPatch == null)
            return NotFound($"Musician with Id {id} not found");

        patch.ApplyTo(musicianToPatch); // Applies the patch document to the musician object.
        return NoContent();
    }

    // Deletes a musician by their ID. Returns 404 if the musician is not found.
    [HttpDelete("{id:int:min(1)}")]
    public IActionResult Delete(int id)
    {
        var musician = _musicians.FirstOrDefault(m => m.Id == id);
        if (musician == null)
            return NotFound($"Musician with Id {id} not found");

        _musicians.Remove(musician);
        return NoContent();
    }
}