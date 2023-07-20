namespace Degree.Data
{
    public static class DegreeMockData
    {
        public static List<Models.Degree> DegreesList = new()
        {
            new Models.Degree() {DegreeID=1,Name="B.Ed (Hons) in Biological Sciences", Type="Bachelors", NoOfModules=40, DurationInYears=4, TotalCredits=120, Description="This programme aims to produce teachers who are competent to teach secondary schools"} ,
            
            new Models.Degree() {DegreeID=2,Name="Master of Science in Information Technology", Type="Masters", NoOfModules=24, DurationInYears=2, TotalCredits=90, Description="This programme aims to provide a core of advanced knowledge in Information Technology supplemented by a range of options"},
           
            new Models.Degree() {DegreeID=3,Name="BSc (Hons) in Information Technology", Type="Bachelors", NoOfModules=40, DurationInYears=4, TotalCredits=120, Description="The programme is designed for technically focused students who required to develop strong professional & academic capabilities in programming"},
            
            new Models.Degree() {DegreeID=4,Name="BSc Engineering (Hons) in Civil Engineering", Type="Bachelors", NoOfModules=40, DurationInYears=4, TotalCredits=140, Description="With a strong focus on building theoretical and practical based study, this degree incorporates the students to gain hand in experience in real time assignment"},
            
            new Models.Degree() {DegreeID=5,Name="Master of Science in Information Systems", Type="Masters", NoOfModules=25, DurationInYears=2, TotalCredits=100, Description="This programme covers areas of critical importance to IT employers, such as project and change management, emerging technologies, IT strategy and governance"}

        };
    }
}
