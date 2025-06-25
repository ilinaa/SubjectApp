using SubjectApp.model;
using SubjectApp.service;

namespace SubjectApp.presentation
{
    public class SubjectUI(BaseIntegrationService<Subject> baseIntegrationService)
    {
        private readonly BaseIntegrationService<Subject> BaseIntegrationService = baseIntegrationService;

        public string GetMenu()
        {
            return String.Format("1. Retrieve all subjects\n2. Retrieve details about a specific subject\n3. Exit program\n");
        }
        public void GetAllSubjects()
        {
            var subjects = BaseIntegrationService.GetAllSubjects();
            Console.WriteLine("Subjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($" - {subject.Name}");
            }
        }

        public void GetAllSubjectsWithIndex()
        {
            var subjects = BaseIntegrationService.GetAllSubjects().ToList();
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {subjects[i].Name}");
            }
        }

        public void ShowSubjectDetails(int index)
        {

            var details = BaseIntegrationService.GetById(index);


            Console.WriteLine(details);
        }
    }
}