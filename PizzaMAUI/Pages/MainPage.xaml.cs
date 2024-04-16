namespace PizzaMAUI.Pages;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
    }


    async void TapGesturRecognizer_Tapped(System.Object sender,
       Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}
