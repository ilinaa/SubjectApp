using SubjectApp.model;
using SubjectApp.presentation;
using SubjectApp.repository;
using SubjectApp.service;

namespace SubjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDatasourceConfigurator datasourceConfigurator = new JsonDatasourceConfigurator()
            {
                Path = "subjects.json"
            };

            try
            {
                IDatasourceConnectivity datasourceConnectivity = datasourceConfigurator.instantiateConnectivity();
                IRepository<Subject> jsonRepository = new Repository<Subject>(datasourceConnectivity);
                IRepository<Subject> inMemoryRepository = new InMemoryRepository();

                BaseIntegrationService<Subject> baseIntegrationService = new IntegrationService<Subject>()
                {
                    repositories = [jsonRepository, inMemoryRepository]
                };
                
                SubjectUI subjectUI = new SubjectUI(baseIntegrationService);
                ApplicationUI applicationUI = new ApplicationUI(subjectUI);

                applicationUI.Start();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}