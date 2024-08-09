using PrimeraMauiApp.Models;
using PrimeraMauiApp.Repositories;
using System.Collections.ObjectModel;

namespace PrimeraMauiApp.Pages;

public partial class LibrosPages : ContentPage
{
	Book bookSelected;
	BooksRepo booksRepo = new BooksRepo();
    ObservableCollection<Book>? books = new ObservableCollection<Book>();
	public LibrosPages()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        books = await booksRepo.ObtenerLibrosAsync();
        CollectionBooks.ItemsSource = books;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}