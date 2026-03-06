namespace CubProfileJoseph;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void OnCheerClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("School Spirit", "Go Jaguars! Fight on!", "OK");
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}