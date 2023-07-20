
using Microsoft.AspNetCore.Mvc;
using Staff.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Staff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService ?? throw new ArgumentNullException(nameof(staffService));
        }

        /// <summary>
        /// Get all staff
        /// </summary>
        /// <returns>return the list of staff</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_staffService.GetStaffs());
        }

        /// <summary>
        /// Get staff by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _staffService.GetStaff(id) != null ? Ok(_staffService.GetStaff(id)) : NoContent();
        }

        /// <summary>
        /// Add staff
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>Return the added staff</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Staff staff)
        {
            return Ok(_staffService.AddStaff(staff));
        }

        /// <summary>
        /// Update the staff
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>Return the updated staff</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Staff staff)
        {
            return Ok(_staffService.UpdateStaff(staff));
        }

        /// <summary>
        /// Delete the staff with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _staffService.DeleteStaff(id);

            return result.HasValue & result == true ? Ok($"staff with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the staff with ID:{id}.");
        }
    }
}
