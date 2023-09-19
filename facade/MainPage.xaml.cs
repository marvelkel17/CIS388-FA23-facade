using System;

namespace facade;

public partial class MainPage : ContentPage
{
    int count = 0;

    public bool DidWin { get; set; } = false;

    public MainPage()
    {
        InitializeComponent();
    }

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(GameOverPage)}?DidWin={DidWin}");
    }

    async void YouWon(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(YouWonPage)}?DidWin={DidWin}");
    }
}
