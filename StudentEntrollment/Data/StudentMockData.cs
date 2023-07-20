namespace StudentEntrollment.Data
{
    public static class StudentMockData
    {
        public static List<Models.Student> StudentsList = new()
        {
            new Models.Student() { StudentId=1,Name="Anne",Address="156 Avenue St,NA",Age=25,Email="anne@gmail.com",Phone="071-8765908"},
            new Models.Student() { StudentId=2,Name="Peter",Address="666 Fourth Ave,CA",Age=26,Email="peter@gmail.com",Phone="077-2156987"},
            new Models.Student() { StudentId=3,Name="Ryan",Address="56 Roling St,NA",Age=22, Email="ryan@gmail.com",Phone="072-9078654"},
            new Models.Student() { StudentId=4,Name="Diana",Address="321 Wallmall St,DA",Age=21,Email="diana@gmail.com",Phone="072-8965345"},
            new Models.Student() { StudentId=5,Name="Jacob",Address="654 Person St, NJ",Age=20,Email="jacob@gmail.com",Phone="077-8965443"}
        };
    }
}
