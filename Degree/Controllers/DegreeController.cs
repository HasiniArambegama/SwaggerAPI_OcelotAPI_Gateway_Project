using Degree.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Degree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DegreeController : ControllerBase
    {
        private readonly IDegreeService _degreeService;

        public DegreeController(IDegreeService degreeService)
        {
            _degreeService = degreeService ?? throw new ArgumentNullException(nameof(degreeService));
        }

        // GET
        //get all degree programs
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_degreeService.GetAllDegrees());
        }


        // GET 
        //get required degree based on ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _degreeService.GetDegree(id) != null ? Ok(_degreeService.GetDegree(id)) : NoContent();
        }

        // POST
        //add new degree
        [HttpPost]
        public IActionResult Post([FromBody] Models.Degree degree)
        {
            return Ok(_degreeService.AddDegree(degree));
        }

        // PUT 
        //update degree based on ID
        [HttpPut]
        public IActionResult Put([FromBody] Models.Degree degree)
        {
            return Ok(_degreeService.UpdateDegree(degree));
        }

        // DELETE 
        // delete degree based on ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _degreeService.DeleteDegree(id);

            return result.HasValue & result == true ? Ok($"Degree with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the degree wiht ID: {id}.");
        }
    }
}
