namespace PizzaMAUI.Pages;

public partial class AllPizzaPage : ContentPage
{
	private readonly AllPizzaViewModel _allPizzaViewModel;
    public AllPizzaPage(AllPizzaViewModel allPizzaViewModel)
    {
       
        InitializeComponent();
        _allPizzaViewModel = allPizzaViewModel;
        BindingContext = _allPizzaViewModel;
    }
    void searchBar_TextChanged( System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        if(!string.IsNullOrWhiteSpace(e.OldTextValue) && string.IsNullOrWhiteSpace(e.NewTextValue))
        {
            _allPizzaViewModel.SearchPizzasCommand.Execute(null);
        }
    }
}