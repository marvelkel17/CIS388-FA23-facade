namespace facade;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(GameOverPage), typeof(GameOverPage));

        Routing.RegisterRoute(nameof(YouWonPage), typeof(YouWonPage));

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        //Routing.RegisterRoute("MainPage", typeof(MainPage));

        //Routing.RegisterRoute("MainPage/YouWonPage", typeof(YouWonPage));

        //Routing.RegisterRoute("MainPage/GameOverPage", typeof(GameOverPage));

    }
}
