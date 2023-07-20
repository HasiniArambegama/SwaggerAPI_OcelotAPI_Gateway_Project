namespace Staff.Data
{
    public static class StaffMockDataService
    {
        public static List<Models.Staff> Staffs = new List<Models.Staff>()
        {
            new Models.Staff { Id = 1, Name = "Jenny Watson", Address = "133 Main St,Lincoln,NE 69584 ", Age = 45, Position = "Senior Lecturer", StudyArea = "IT" },
            new Models.Staff { Id = 2, Name = "Milley Andrew", Address = "456 Elmore Lane, Greenboro, NC 0987", Age = 35, Position = "Junior Lecturer", StudyArea = "Data Science"  },
            new Models.Staff { Id = 3, Name = "Tom Cruise", Address = "789 Hawk Lane, New Jersey,NJ 3845", Age = 55, Position = "Senior Lecturer", StudyArea = "Software Engineering"  },
            new Models.Staff { Id = 4, Name = "Harry Stewart ", Address = "185 West 74th Street,New York,NY 3445", Age = 40, Position = "Senior Lecturer", StudyArea = "IT"  },
            new Models.Staff { Id = 5, Name = "Sara Lance", Address = "654 Fifth St NY", Age = 50, Position = "Professor", StudyArea = "Data Science"   }

        };

    }
}
