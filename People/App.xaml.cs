namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepoAg { get; private set; }

    public App(PersonRepository repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        PersonRepoAg = repo;
    }
}
