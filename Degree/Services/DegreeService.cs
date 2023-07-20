using Degree.Data;

namespace Degree.Services
{
    public class DegreeService : IDegreeService
    {
        //get all degrees
        List<Models.Degree> IDegreeService.GetAllDegrees()
        {
            return DegreeMockData.DegreesList;
        }

        //get selected degree
        Models.Degree? IDegreeService.GetDegree(int id)
        {
            return DegreeMockData.DegreesList.FirstOrDefault(degree => degree.DegreeID == id);
        }

        //add a degree
        Models.Degree? IDegreeService.AddDegree(Models.Degree degree)
        {
            if (degree != null)
            {
                DegreeMockData.DegreesList.Add(degree);
            }
            return degree;
        }

        //update degree
        Models.Degree? IDegreeService.UpdateDegree(Models.Degree degree)
        {
            //checking the degree is existed in the list
            Models.Degree? selectedDegree = DegreeMockData.DegreesList.FirstOrDefault(dgr => dgr.DegreeID == degree.DegreeID);
            if (selectedDegree != null)
            {
                selectedDegree.Name = degree.Name;
                selectedDegree.Type = degree.Type;
                selectedDegree.NoOfModules = degree.NoOfModules;
                selectedDegree.TotalCredits = degree.TotalCredits;
                selectedDegree.DurationInYears = degree.DurationInYears;
                selectedDegree.Description = degree.Description;

                return selectedDegree;
            }
            return null;
        }

        //delete a degree
        bool? IDegreeService.DeleteDegree(int id)
        {
            //checking required degree is existed
            Models.Degree? selectedDegree = DegreeMockData.DegreesList.FirstOrDefault(degree => degree.DegreeID == id);

            if (selectedDegree != null)
            {
                DegreeMockData.DegreesList.Remove(selectedDegree);
                return true;
            }
            return false;
        }
    }
}
