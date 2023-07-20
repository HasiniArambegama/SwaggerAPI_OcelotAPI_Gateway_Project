namespace Degree.Models
{
    public class Degree
    {
        public int DegreeID { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; } //bachelors / masters / doctoral
        public int NoOfModules { get; set; }
        public int TotalCredits { get; set; }
        public int DurationInYears { get; set; }
        public string? Description{ get; set; }

    }
}
