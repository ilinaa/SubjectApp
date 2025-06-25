
using SubjectApp.model;

public static class DataInitializer
{
    public static List<Subject> GetSubjects()
    {
        return new()
    {
        new Subject
        {
            Id = 4,
            Name = "Geography",
            Description = "Study of Earth's landscapes.",
            NumberOfWeeklyClasses = 3,
            Literature = new List<string> { "World Atlas", "Physical Geography Handbook" }
        },
        new Subject
        {
            Id = 5,
            Name = "Chemistry",
            Description = "Study of substances.",
            NumberOfWeeklyClasses = 4,
            Literature = new List<string> { "Organic Chemistry", "Periodic Table Essentials" }
        },
        new Subject
        {
            Id = 6,
            Name = "Art",
            Description = "Visual arts",
            NumberOfWeeklyClasses = 3,
            Literature = new List<string> { "Art History", "Sketchbook" }
        }

     };
    }

}