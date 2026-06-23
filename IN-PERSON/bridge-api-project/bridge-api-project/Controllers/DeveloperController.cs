using bridge_api_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bridge_api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly ApplicationDbContext dbcontext;

        public DeveloperController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("GetDevelopers")]
        public async Task<IEnumerable<Developer>> GetDevelopers()
        {
            return await dbcontext.Developers.ToListAsync();
        }


        [HttpGet]
        [Route("GetDevelopersById/{id}")]
        public async Task<Developer> GetDevelopersById(int id)
        {
            return await dbcontext.FindAsync<Developer>(id);
        }


        [HttpPost]
        [Route("AddDeveloper")]
        public async Task<Developer> AddDeveloper(Developer developer)
        {
            dbcontext.Add(developer);
            await dbcontext.SaveChangesAsync();
            return developer;
        }


        [HttpPut]
        [Route("UpdateDeveloper/{id}")]
        public async Task<Developer> UpdateDeveloper(Developer developer)
        {
            dbcontext.Update(developer);
            await dbcontext.SaveChangesAsync();
            return developer;
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeveloper(int id)
        {
            var developer = await dbcontext.Developers.FindAsync(id);

            if (developer == null)
            {
                return NotFound();
            }

            dbcontext.Developers.Remove(developer);
            await dbcontext.SaveChangesAsync();

            return NoContent();
        }
    }
}
