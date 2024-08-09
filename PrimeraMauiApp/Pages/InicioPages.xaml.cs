namespace PrimeraMauiApp.Pages;

public partial class InicioPages : ContentPage
{
	public InicioPages()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LibrosPages());	
    }

    private void btnControlesComunes_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ControlesComunesPages());
    }
}