namespace Assignment.Data
{
    public class AssignmentMockDataService
    {
        public static List<Models.Assignment> Assignments = new List<Models.Assignment>()
        {
            new Models.Assignment{ Assignment_Id = 1, Assignment_Name = "MTIT Cloud Assignment 1", Module_Id = "IT4020", Assignment_Credits = "10%", Assignment_Description = "Cloud assignment 1 based on cloud technologies", Assignment_Duration = "8th Week", Academic_Year = "4th Yr 1st Sem" },
            new Models.Assignment{ Assignment_Id = 2, Assignment_Name = "MTIT Cloud Assignment 2", Module_Id = "IT4020", Assignment_Credits = "10%", Assignment_Description = "Cloud assignment 2 based on microservices technology", Assignment_Duration = "9th Week", Academic_Year = "4th Yr 1st Sem" },
            new Models.Assignment{ Assignment_Id = 3, Assignment_Name = "SQA Assignment 1", Module_Id = "IT4100", Assignment_Credits = "15%", Assignment_Description = "Research paper writing", Assignment_Duration = "10th Week", Academic_Year = "4th Yr 1st Sem" },
            new Models.Assignment{ Assignment_Id = 4, Assignment_Name = "OOP Assignment 1", Module_Id = "IT2030", Assignment_Credits = "10%", Assignment_Description = "Individual assignment based on OOP concepts", Assignment_Duration = "7th Week", Academic_Year = "2nd Yr 1st Sem" },
            new Models.Assignment{ Assignment_Id = 5, Assignment_Name = "SPM Assignment 3", Module_Id = "IT2020", Assignment_Credits = "5%", Assignment_Description = "Individual assignment based on UML diagrams", Assignment_Duration = "10th Week", Academic_Year = "2nd Yr 1st Sem" },
        };

    }
}
