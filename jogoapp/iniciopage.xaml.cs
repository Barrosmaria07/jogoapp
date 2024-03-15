namespace jogoapp;

public partial class iniciopage : ContentPage
{
		

	public iniciopage()
	{
        InitializeComponent();
    } 
private void StartButton_continuar(object sender, EventArgs args)
	{
	Application.Current.MainPage = new comecopage();
	}
	private void StartButton_voltar(object sender, EventArgs args)
{
Application.Current.MainPage = new MainPage();
}
   
}