namespace jogoapp;

public partial class iniciopage : ContentPage
{
		

	public iniciopage()
	{
        InitializeComponent();
    } 
    private void StartButton_continuar(object sender, EventArgs args)
	{
	Application.Current.MainPage = new ComecoPage();
	}
	
	private void StartButton_voltar(object sender, EventArgs args)
    {
     Application.Current.MainPage = new MainPage();
    }
   
}