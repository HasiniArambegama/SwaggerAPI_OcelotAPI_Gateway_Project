using Assignment.Data;
using Assignment.Models;

namespace Assignment.Services
{
    public class AssignmentService:IAssignmentService
    {
        //Get all assignments
        public List<Models.Assignment> GetAssignments()
        {
            return AssignmentMockDataService.Assignments;
        }

        //Search relavant assignment
        public Models.Assignment? GetAssignment(int id)
        {
            return AssignmentMockDataService.Assignments.FirstOrDefault(x => x.Assignment_Id == id);
        }

        //Add assignment
        public Models.Assignment? AddAssignment(Models.Assignment assignment)
        {
            AssignmentMockDataService.Assignments.Add(assignment);
            return assignment;
        }

        //Update assignment
        public Models.Assignment? UpdateAssignment(Models.Assignment assignment)
        {
            Models.Assignment selectedAssignment = AssignmentMockDataService.Assignments.FirstOrDefault(x => x.Assignment_Id == assignment.Assignment_Id);
            if (selectedAssignment != null)
            {
                selectedAssignment.Assignment_Name = assignment.Assignment_Name;
                selectedAssignment.Module_Id = assignment.Module_Id;
                selectedAssignment.Assignment_Credits = assignment.Assignment_Credits;
                selectedAssignment.Assignment_Description = assignment.Assignment_Description;
                selectedAssignment.Assignment_Duration = assignment.Assignment_Duration;    
                selectedAssignment.Academic_Year = assignment.Academic_Year;
                return selectedAssignment;
            }
            return selectedAssignment;
        }

        //Delete assignment
        public bool? DeleteAssignment(int id)
        {
            Models.Assignment selectedAssignment = AssignmentMockDataService.Assignments.FirstOrDefault(x => x.Assignment_Id == id);
            if (selectedAssignment != null)
            {
                AssignmentMockDataService.Assignments.Remove(selectedAssignment);
                return true;
            }
            return false;
        }
    }
}
