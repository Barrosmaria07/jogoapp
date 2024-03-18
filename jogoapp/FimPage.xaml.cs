namespace jogoapp;

public partial class FimPage : ContentPage
{
		
	public FimPage()
	{

	InitializeComponent();

	}
	private void StartButton_jogardenovo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}


}
