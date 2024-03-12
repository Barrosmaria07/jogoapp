using Microsoft.Maui.Controls;

namespace jogoapp;

public partial class MainPage : ContentPage
{
		

	public MainPage()
	{

	InitializeComponent();

	}
	private void StartButton_comecar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new iniciopage();
	}
	private void StartButton_sobre(object sender, EventArgs args)
    {
        framesobre.IsVisible= true;
    }
    private void voltar(object sender, EventArgs args)
    {
	  framesobre.IsVisible= false;
    }


}


  

