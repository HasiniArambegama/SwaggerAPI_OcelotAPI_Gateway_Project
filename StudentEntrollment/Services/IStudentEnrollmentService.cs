namespace StudentEntrollment.Services
{
    public interface IStudentEnrollmentService
    {
        List<Models.Student> GetAllStudents();
        Models.Student? GetStudent(int id);
        Models.Student? AddStudent(Models.Student student);
        Models.Student? UpdateStudent(Models.Student student);
        bool? DeleteStudent(int id);
    }
}
