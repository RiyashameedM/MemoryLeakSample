namespace SimpleSample;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}