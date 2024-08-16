using System.Collections.ObjectModel;

namespace PrimeraMauiApp.Pages;

public partial class ControlesComunesPages : ContentPage
{
	public ObservableCollection<string> Frutas { get; set; } = new ObservableCollection<string>();
	public ControlesComunesPages()
	{
		InitializeComponent();
        Frutas = new ObservableCollection<string>
        {
            "Manzana",
            "Banana",
            "Naranja",
            "Fresa",
            "Uva"
        };
        BindingContext = this;
    }
}