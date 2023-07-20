using StudentEntrollment.Data;
using StudentEntrollment.Models;

namespace StudentEntrollment.Services
{
    public class StudentEnrollmentService : IStudentEnrollmentService
    {
        List<Student> IStudentEnrollmentService.GetAllStudents()
        {
            return StudentMockData.StudentsList;
        }

        Student? IStudentEnrollmentService.GetStudent(int id)
        {
            return StudentMockData.StudentsList.FirstOrDefault(std => std.StudentId == id);
        }

        Student? IStudentEnrollmentService.AddStudent(Student student)
        {
            StudentMockData.StudentsList.Add(student);
            return student;
        }

        Student? IStudentEnrollmentService.UpdateStudent(Student student)
        {
            Models.Student? selectedStudent = StudentMockData.StudentsList.FirstOrDefault(std => std.StudentId == student.StudentId);
            if (selectedStudent != null)
            {
                selectedStudent.Name = student.Name;
                selectedStudent.Age = student.Age;
                selectedStudent.Address = student.Address;
                selectedStudent.Email = student.Email;
                selectedStudent.Phone = student.Phone;

                return selectedStudent;
            }
            return selectedStudent;
        }

        bool? IStudentEnrollmentService.DeleteStudent(int id)
        {
            Models.Student? selectedStudent = StudentMockData.StudentsList.FirstOrDefault(std => std.StudentId == id);
            if (selectedStudent != null)
            {
                StudentMockData.StudentsList.Remove(selectedStudent);
                return true;
            }
            return false;
        }
    }
}
