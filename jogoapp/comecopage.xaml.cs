namespace jogoapp;

public partial class comecopage : ContentPage
{
		

	public comecopage()
	{

	InitializeComponent();

	}
	private void Continuar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new comecopage();
	}
	 private void StartButton_nao(object sender, EventArgs args)
    {
	 Application.Current.MainPage = new comecopage();
    }

}