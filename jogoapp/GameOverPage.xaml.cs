namespace jogoapp;

public partial class GameOverPage : ContentPage
{
		
	public GameOverPage()
	{

	InitializeComponent();

	}
	private void StartButton_voltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}


}
