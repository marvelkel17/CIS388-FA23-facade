using System;

namespace facade;

public partial class MainPage : ContentPage
{



    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainPageViewModel();
    }

    
}
