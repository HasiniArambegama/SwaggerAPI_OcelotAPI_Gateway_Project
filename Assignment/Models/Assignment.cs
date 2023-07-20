namespace Assignment.Models
{
    public class Assignment
    {
        public int Assignment_Id { get; set; }

        public string? Assignment_Name { get; set; }

        public string? Module_Id { get; set; } //IT3020

        public string? Assignment_Credits { get; set; }

        public string? Assignment_Description { get; set; }

        public string? Assignment_Duration { get; set; } // week wise(6th week/ 8th week)
        
        public string? Academic_Year { get; set; } //2nd yr, 4th yr

    }
}
