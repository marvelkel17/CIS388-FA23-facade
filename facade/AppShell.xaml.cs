namespace facade;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(GameOverPage), typeof(GameOverPage));

        Routing.RegisterRoute(nameof(YouWonPage), typeof(YouWonPage));

    }
}
