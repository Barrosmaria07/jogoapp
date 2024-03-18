namespace jogoapp;

public partial class ComecoPage : ContentPage
{
		
	public ComecoPage()
	{

	InitializeComponent();

	}
	private void StartButton_sim(object sender, EventArgs args)
	{
		Application.Current.MainPage = new FimPage();
	}
	 private void StartButton_nao(object sender, EventArgs args)
    {
	    Application.Current.MainPage = new GameOverPage();
    }

}
