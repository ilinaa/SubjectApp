namespace SubjectApp.model
{
    public class Subject : BaseModel
    {

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int NumberOfWeeklyClasses { get; set; }
        public List<string> Literature { get; set; } = new();

        public Subject()
        {
        }

        public Subject(long id, string name, string description, int numberOfWeeklyClasses, List<string> literature)
        {
            Id = id;
            Name = name;
            Description = description;
            NumberOfWeeklyClasses = numberOfWeeklyClasses;
            Literature = literature ?? [];
        }


        public override string ToString()
        {
            return String.Format("name: {0} \n description: {1} \n number of weekly classess: {2} \n Literature: {3} ", this.Name,
            this.Description, this.NumberOfWeeklyClasses, string.Join(",", Literature));
        }

    }
}