namespace Degree.Services
{
    public interface IDegreeService
    {
        List<Models.Degree> GetAllDegrees();
        Models.Degree? GetDegree(int id);
        Models.Degree? AddDegree(Models.Degree degree);
        Models.Degree? UpdateDegree(Models.Degree degre);
        bool? DeleteDegree(int id);
    }
}
