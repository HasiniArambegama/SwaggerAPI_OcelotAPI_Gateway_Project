using Assignment.Models;
using Assignment.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService ?? throw new ArgumentNullException(nameof(assignmentService));
        }


        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <returns>return list of assignments</returns>
        // GET: api/<AssignmentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_assignmentService.GetAssignments());
        }

        /// <summary>
        /// Get assignment by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return assignment with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _assignmentService.GetAssignment(id) != null ? Ok(_assignmentService.GetAssignment(id)) : NoContent();
        }

        /// <summary>
        /// Add assignment
        /// </summary>
        /// <param name= "assignment"></param>
        /// <returns>return the addedd assignment</returns>
        [HttpPost]
        public IActionResult post([FromBody] Models.Assignment assignment)
        {
            return Ok(_assignmentService.AddAssignment(assignment));
        }

        /// <summary>
        /// Update assignment
        /// </summary>
        /// <param name="assignment"></param>
        /// <returns>return the updated assignment</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Assignment assignment)
        {
            return Ok(_assignmentService.UpdateAssignment(assignment));
        }

        /// <summary>
        /// Delete the assignment by the passing the ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _assignmentService.DeleteAssignment(id);

            return result.HasValue & result == true ? Ok($"assignment with ID: {id} deleted successfully.")
                : BadRequest($"Unable to delete the assignment with ID: {id}.");
        }
    }
}
