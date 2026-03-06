namespace CubProfileJoseph;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

   
    private async void OnTipClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Campus Tip", "Check out the library's third floor for the quietest study spots!", "OK");
    }


    private async void OnGoToProfileClicked(object sender, EventArgs e)
    {
       
        await Navigation.PushAsync(new ProfilePage());
    }
}