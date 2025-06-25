namespace SubjectApp.presentation
{
    public class ApplicationUI(SubjectUI subjectUI)
    {
        public Command Command { get; set; }
        public SubjectUI SubjectUI = subjectUI;

        public void Start()
        {

            bool running = true;

            while (running)
            {
                Console.Write(SubjectUI.GetMenu());
                string? line = Console.ReadLine();
                if (int.TryParse(line, out int commandValue))
                {
                    if (Enum.IsDefined(typeof(Command), commandValue))
                    {
                        Command = (Command)commandValue;

                        switch (Command)
                        {
                            case Command.RETRIEVE_ALL:
                                SubjectUI.GetAllSubjects();
                                break;

                            case Command.RETRIEVE_DETAILS_MENU:
                                SubjectUI.GetAllSubjectsWithIndex();

                                Console.Write("Select a subject number for details: ");
                                string? detailInput = Console.ReadLine();

                                if (int.TryParse(detailInput, out int index))
                                {
                                    try
                                    {
                                        SubjectUI.ShowSubjectDetails(index);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Error: {ex.Message}");
                                    }
                                }
                                break;

                            case Command.EXIT:
                                Command = Command.EXIT;
                                running = false;
                                break;

                            default:
                                Console.WriteLine("Invalid command!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Please enter a number from the menu.");
                    }
                }
            }

            Console.WriteLine("Program exited.");
        }

    }
}