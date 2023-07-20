using Microsoft.AspNetCore.Mvc;
using StudentEntrollment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentEntrollment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentEnrollmentController : ControllerBase
    {
        private readonly IStudentEnrollmentService _studentEnrollmentService;

        public StudentEnrollmentController(IStudentEnrollmentService studentEnrollmentService)
        {
            _studentEnrollmentService = studentEnrollmentService ?? throw new ArgumentNullException(nameof(studentEnrollmentService));
        }


        // GET: api/<StudentEnrollmentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentEnrollmentService.GetAllStudents());
        }

        // GET api/<StudentEnrollmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _studentEnrollmentService.GetStudent(id) != null ? Ok(_studentEnrollmentService.GetStudent(id)) : NoContent();
        }

        // POST api/<StudentEnrollmentController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Student student)
        {
            return Ok(_studentEnrollmentService.AddStudent(student));
        }

        // PUT api/<StudentEnrollmentController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Models.Student student)
        {
            return Ok(_studentEnrollmentService.UpdateStudent(student));
        }

        // DELETE api/<StudentEnrollmentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _studentEnrollmentService.DeleteStudent(id);

            return result.HasValue & result == true ? Ok($"student with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the student wiht ID: {id}.");
        }
    }
}
