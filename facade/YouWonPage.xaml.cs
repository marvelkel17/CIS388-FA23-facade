namespace facade;

public partial class YouWonPage : ContentPage
{
	public YouWonPage()
	{
		InitializeComponent();

		BindingContext = new MainPageViewModel();
	}

}