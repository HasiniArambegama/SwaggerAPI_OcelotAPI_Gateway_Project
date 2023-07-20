namespace Assignment.Services
{
    public interface IAssignmentService
    {
        List<Models.Assignment> GetAssignments();
        Models.Assignment? GetAssignment(int id);
        Models.Assignment? AddAssignment(Models.Assignment assignment);
        Models.Assignment? UpdateAssignment(Models.Assignment assignment);
        bool? DeleteAssignment(int id);
    }
}
